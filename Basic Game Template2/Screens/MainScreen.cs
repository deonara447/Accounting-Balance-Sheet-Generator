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
        public MainScreen()
        {
            InitializeComponent();
        }
        
        private void newButton_Click_1(object sender, EventArgs e)
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

            MainForm.reset = true;

            MainForm.ChangeScreen(this, "BalanceSheetInformationScreen");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            balanceSheetInformationButton.Text = MainForm.businessName + "                                         " + MainForm.modifiedDate;
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
            int Min, Hour, Day, Month, Year;
            Min = DateTime.Now.Minute;
            Hour = DateTime.Now.Hour;
            Day = DateTime.Now.Day;
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
            timeLabel.Text = Month.ToString("00") + "/" + Day.ToString("00") + "/" + Year.ToString("00") + "  " + Hour.ToString("00") + ":" + Min.ToString("00");
            Refresh();
        }
    }
}
