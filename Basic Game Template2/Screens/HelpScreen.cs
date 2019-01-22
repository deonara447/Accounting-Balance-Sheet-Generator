using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Game_Template2
{
    public partial class HelpScreen : UserControl
    {
        public HelpScreen()
        {
            InitializeComponent();
        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "MainScreen");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MainForm.businessName = "Untitled Template";
            MainForm.fiscalMonthEnd = "";
            MainForm.beginningOfPeriod = 0;
            MainForm.netIncome = 0;
            MainForm.drawings = 0;
            MainForm.modifiedDate = "1/19/19";
            MainForm.currentAssetAmounts.Clear();
            MainForm.currentAssetNames.Clear();
            MainForm.fixedAssetAmounts.Clear();
            MainForm.fixedAssetNames.Clear();
            MainForm.currentLiabilityAmounts.Clear();
            MainForm.currentLiabilityNames.Clear();
            MainForm.longTermLiabilityAmounts.Clear();
            MainForm.longTermLiabilityNames.Clear();
            MainForm.ChangeScreen(this, "BalanceSheetInformationScreen");

            MainForm.reset = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "FeedbackScreen");
        }

        private void HelpScreen_Load(object sender, EventArgs e)
        {
            //shows help screen text
            informationLabel.Text = "Taskbar \n" +
                "Home - The main screen of the program where all the program features are one click away! This is the screen you see once you log in \n" +
                "New - Creates a new template \n" +
                "Close - Closes the program \n" +
                "Save - Saves the information inputted so it can be accesses again later \n" +
                "Delete - Removes the current balance sheet from the saved balance sheets \n" +
                "Print - Prints your balance sheet \n" +
                "Clear - Removes all data from your template \n" +
                "Feedback - To tell us how you like our program so far and to make suggestions \n" +
                "\n" +
                "How to create a balance sheet \n" +
                "1. Select 'New' in the taskbar \n" +
                "2. Input all you business information requires into the indicated placess \n" +
                "3. When you are ready, select 'Save' in the task bar and then select 'Balance Sheet' in the tabs at the bottom \n" +
                "4. If you wish, select 'Print' in the taskbar to print your completed balance sheet";
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            int Min = DateTime.Now.Minute;
            int Hour = DateTime.Now.Hour;
            int Day = DateTime.Now.Day;
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;
            timeLabel.Text = Month.ToString("00") + "/" + Day.ToString("00") + "/" + Year.ToString("00") + "  " + Hour.ToString("00") + ":" + Min.ToString("00");
            Refresh();
        }

        
    }
}
