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
        public partial class MainScreen : UserControl
    {
        int Min, Hour, Day, Month, Year;
        

        public MainScreen()
        {
            InitializeComponent();
        }
        
        
        
        private void newButton_Click_1(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "BusinessInformationScreen");


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            balanceSheetInformationButton.Text = MainForm.businessName + "\t" + "\t" + MainForm.modifiedDate;
        }

        private void feedbackButton_Click_1(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "FeedbackScreen");
        }

        private void helpButton_Click_1(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "HelpScreen");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "BalanceSheetInformationScreen");
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            Min = DateTime.Now.Minute;
            Hour = DateTime.Now.Hour;
            Day = DateTime.Now.Day;
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
            timeLabel.Text = Month + "/" + Day + "/" + Year + "  " + Hour + ":" + Min;
            Refresh();



            
        }
    }
}
