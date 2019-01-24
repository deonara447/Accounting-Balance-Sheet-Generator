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
    public partial class BalanceSheetTemplateScreen : UserControl
    {
        public BalanceSheetTemplateScreen()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //changes screen to 'main screen'
            MainForm.ChangeScreen(this, "MainScreen");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //Resets all variables and lists to their original states
            MainForm.businessName = "Untitled Template";
            MainForm.fiscalMonthEnd = "Unknown";
            MainForm.beginningOfPeriod = 0;
            MainForm.netIncome = 0;
            MainForm.drawings = 0;
            MainForm.modifiedDate = "Unknown";
            MainForm.currentAssetAmounts.Clear();
            MainForm.currentAssetNames.Clear();
            MainForm.fixedAssetAmounts.Clear();
            MainForm.fixedAssetNames.Clear();
            MainForm.currentLiabilityAmounts.Clear();
            MainForm.currentLiabilityNames.Clear();
            MainForm.longTermLiabilityAmounts.Clear();
            MainForm.longTermLiabilityNames.Clear();

            //so that when screen changes to 'business information screen' all data is reset
            MainForm.reset = true;

            //change screen to 'business information screen'
            MainForm.ChangeScreen(this, "BalanceSheetInformationScreen");


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "FeedbackScreen");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "HelpScreen");
        }

        private void businessInformationButton_Click(object sender, EventArgs e)
        {
            //changes screen to balance sheet information screen'
            MainForm.ChangeScreen(this, "BalanceSheetInformationScreen");
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            MainForm.businessName = "Untitled Template";
            MainForm.fiscalMonthEnd = "Unknown";
            MainForm.beginningOfPeriod = 0;
            MainForm.netIncome = 0;
            MainForm.drawings = 0;
            MainForm.modifiedDate = "Unknown";
            MainForm.currentAssetAmounts.Clear();
            MainForm.currentAssetNames.Clear();
            MainForm.fixedAssetAmounts.Clear();
            MainForm.fixedAssetNames.Clear();
            MainForm.currentLiabilityAmounts.Clear();
            MainForm.currentLiabilityNames.Clear();
            MainForm.longTermLiabilityAmounts.Clear();
            MainForm.longTermLiabilityNames.Clear();

            MainForm.reset = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MainForm.businessName = "Untitled Template";
            MainForm.fiscalMonthEnd = "Unknown";
            MainForm.beginningOfPeriod = 0;
            MainForm.netIncome = 0;
            MainForm.drawings = 0;
            MainForm.modifiedDate = "Unknown";
            MainForm.currentAssetAmounts.Clear();
            MainForm.currentAssetNames.Clear();
            MainForm.fixedAssetAmounts.Clear();
            MainForm.fixedAssetNames.Clear();
            MainForm.currentLiabilityAmounts.Clear();
            MainForm.currentLiabilityNames.Clear();
            MainForm.longTermLiabilityAmounts.Clear();
            MainForm.longTermLiabilityNames.Clear();

            MainForm.reset = true;

            MainForm.ChangeScreen(this, "MainScreen");
        }

        private void BalanceSheetTemplateScreen_Load(object sender, EventArgs e)
        {
            //loads balance sheet information and outputs it into a balance sheet
            businessNameLabel.Text = MainForm.businessName;
            endOfMonthLabel.Text = MainForm.fiscalMonthEnd;
            beginningEquityAmountLabel.Text = MainForm.beginningOfPeriod.ToString("0.00");
            netIncomeAmountLabel.Text = MainForm.netIncome.ToString("0.00");
            drawingsAmountLabel.Text = MainForm.drawings.ToString("0.00");
            changeInEquityAmount.Text = (MainForm.netIncome - MainForm.drawings).ToString("0.00") + "";
            endEquityAmountLabel.Text = (MainForm.beginningOfPeriod + MainForm.netIncome - MainForm.drawings).ToString("0.00");
            totalLiabilitiesAndEquityAmountLabel.Text = (MainForm.beginningOfPeriod + MainForm.netIncome - MainForm.drawings + MainForm.longTermLiabilityAmounts.Sum() + MainForm.currentLiabilityAmounts.Sum()).ToString("0.00");

            //lists assets and liabilities
            for (int i = 0; i < MainForm.currentAssetNames.Count(); i++)
            {
                currentAssetNamesLabel.Text += MainForm.currentAssetNames[i] + "\n";
            }

            currentAssetNamesLabel.Text += "Total Current Assets";

            for (int i = 0; i < MainForm.currentAssetAmounts.Count(); i++)
            {
                currentAssetAmountsLabel.Text += MainForm.currentAssetAmounts[i].ToString("0.00") + "\n";
            }

            currentAssetAmountsLabel.Text += MainForm.currentAssetAmounts.Sum().ToString("0.00");

            for (int i = 0; i < MainForm.fixedAssetNames.Count(); i++)
            {
                fixedAssetNamesLabel.Text += MainForm.fixedAssetNames[i] + "\n";
            }

            fixedAssetNamesLabel.Text += "Total Fixed Assets";

            for (int i = 0; i < MainForm.fixedAssetAmounts.Count(); i++)
            {
                fixedAssetAmountsLabel.Text += MainForm.fixedAssetAmounts[i].ToString("0.00") + "\n";
            }

            fixedAssetAmountsLabel.Text += MainForm.fixedAssetAmounts.Sum().ToString("0.00");
            TotalAssetAmountLabel.Text += (MainForm.fixedAssetAmounts.Sum() + MainForm.currentAssetAmounts.Sum()).ToString("0.00");

            for (int i = 0; i < MainForm.currentLiabilityNames.Count(); i++)
            {
                currentLiabilityNamesLabel.Text += MainForm.currentLiabilityNames[i] + "\n";
            }

            currentLiabilityNamesLabel.Text += "Total Current Liabilities";

            for (int i = 0; i < MainForm.currentLiabilityAmounts.Count(); i++)
            {
                currentLiabilityAmountsLabel.Text += MainForm.currentLiabilityAmounts[i].ToString("0.00") + "\n";
            }

            currentLiabilityAmountsLabel.Text += MainForm.currentLiabilityAmounts.Sum().ToString("0.00");

            for (int i = 0; i < MainForm.longTermLiabilityNames.Count(); i++)
            {
                longTermLiabilityNamesLabel.Text += MainForm.longTermLiabilityNames[i] + "\n";
            }

            longTermLiabilityNamesLabel.Text += "Total Long Term Liabilities";

            for (int i = 0; i < MainForm.longTermLiabilityAmounts.Count(); i++)
            {
                longTermLiabilityAmountsLabel.Text += MainForm.longTermLiabilityAmounts[i].ToString("0.00") + "\n";
            }

            longTermLiabilityAmountsLabel.Text += MainForm.longTermLiabilityAmounts.Sum().ToString("0.00");
            totalLiabilitiesAmountLabel.Text += (MainForm.longTermLiabilityAmounts.Sum() + MainForm.currentLiabilityAmounts.Sum()).ToString("0.00");
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must download the PRO version in order to print this balance sheet");
        }
    }
}
