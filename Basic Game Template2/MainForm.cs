using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;

namespace Basic_Game_Template2
{
    public partial class MainForm : Form
    {
        bool fullScreen = false;  // true: program runs fullscreen || false: program runs in window
        public static List<double> currentAssetAmounts = new List<double>();
        public static List<string> currentAssetNames = new List<string>();
        public static List<double> fixedAssetAmounts = new List<double>();
        public static List<string> fixedAssetNames = new List<string>();
        public static List<double> currentLiabilityAmounts = new List<double>();
        public static List<string> currentLiabilityNames = new List<string>();
        public static List<double> longTermLiabilityAmounts = new List<double>();
        public static List<string> longTermLiabilityNames = new List<string>();

        public static string businessName;
        public static string fiscalMonthEnd;
        public static double beginningOfPeriod;
        public static double netIncome;
        public static double drawings;

        public static string modifiedDate;


        public MainForm()
        {
            InitializeComponent();

            //Cursor.Hide();

            // open the main menu for the game
            LoginScreen ms = new LoginScreen();
            this.Controls.Add(ms);

            #region open in full screen or not
            if (fullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;

                int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
                // centre the new screen in the middle of the form
                ms.Location = new Point((screenWidth - ms.Width) / 2, (screenHeight - ms.Height) / 2);
            }
            else
            {
                // centre the new screen in the middle of the form
                ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            }
            #endregion
        }

        /// <summary>
        /// Will remove the current UserControl on the screen and replace it with
        /// a new one
        /// </summary>
        /// <param name="current">The UserControl to be closed</param>
        /// <param name="next">The name of the UserControl to be opened</param>
        public static void ChangeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            ///If any screens, (UserControls), are added to the program they need to
            ///be added within this switch block as well.
            switch (next)
            {
                case "LoginScreen":
                    ns = new LoginScreen();
                    break;
                case "MainScreen":
                    ns = new MainScreen();
                    break;
                case "FeedbackScreen":
                    ns = new FeedbackScreen();
                    break;
                case "HelpScreen":
                    ns = new HelpScreen();
                    break;
                case "BalanceSheetInformationScreen":
                    ns = new BalanceSheetInformationScreen();
                    break;
                case "BalanceSheetTemplateScreen":
                    ns = new BalanceSheetTemplateScreen();
                    break;

            }

            //centres the control on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);

            f.Controls.Add(ns);
            ns.Focus();

            
        }
    }
}
