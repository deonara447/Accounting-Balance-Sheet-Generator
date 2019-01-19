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
    public partial class BalanceSheetInformationScreen : UserControl
    {
        int Min;
        int Hour;
        int Day;
        int Month;
        int Year;

        public BalanceSheetInformationScreen()
        {

            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "MainScreen");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "NewScreen");
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

        private void balanceSheetButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "BalanceSheetTemplateScreen");
        }

        private void addCurrentAssetButton_Click(object sender, EventArgs e)
        {
            
            MainForm.currentAssetAmounts.Add(Convert.ToDouble(addCurrentAssetsAccountAmountTextBox.Text));

            MainForm.currentAssetNames.Add(addCurrentAssetsAccountNameTextBox.Text);

            currentAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.currentAssetAmounts.Count(); i++)
            {
                
                currentAssetsAccountInformationLabel.Text += MainForm.currentAssetNames[i] + " $" + MainForm.currentAssetAmounts[i] + "\n";
            }

        }

        private void removeCurrentAssetButton_Click(object sender, EventArgs e)
        {
            MainForm.currentAssetAmounts.Remove(Convert.ToDouble(removeCurrentAssetsAccountAmountTextBox.Text));
            MainForm.currentAssetNames.Remove(Convert.ToString(removeCurrentAssetsAccountNameTextBox.Text));
            currentAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.currentAssetAmounts.Count(); i++)
            {
                currentAssetsAccountInformationLabel.Text += MainForm.currentAssetNames[i] + " $" + MainForm.currentAssetAmounts[i] + "\n";
            }
        }

        private void addFixedAssetButton_Click(object sender, EventArgs e)
        {
            MainForm.fixedAssetAmounts.Add(Convert.ToDouble(addFixedAssetsAccountAmountTextBox.Text));

            MainForm.fixedAssetNames.Add(addFixedAssetsAccountNameTextBox.Text);

            fixedAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.fixedAssetAmounts.Count(); i++)
            {

                fixedAssetsAccountInformationLabel.Text += MainForm.fixedAssetNames[i] + " $" + MainForm.fixedAssetAmounts[i] + "\n";
            }
        }

        private void removeFixedAssetButton_Click(object sender, EventArgs e)
        {
            MainForm.fixedAssetAmounts.Remove(Convert.ToDouble(removeFixedAssetsAccountAmountTextBox.Text));
            MainForm.fixedAssetNames.Remove(Convert.ToString(removeFixedAssetsAccountNameTextBox.Text));
            fixedAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.fixedAssetAmounts.Count(); i++)
            {
                fixedAssetsAccountInformationLabel.Text += MainForm.fixedAssetNames[i] + " $" + MainForm.fixedAssetAmounts[i] + "\n";
            }
        }

        private void addCurrentLiabilityButton_Click(object sender, EventArgs e)
        {
            MainForm.currentLiabilityAmounts.Add(Convert.ToDouble(addCurrentLiabilitiesAccountAmountTextBox.Text));

            MainForm.currentLiabilityNames.Add(addCurrentLiabilitiesAccountNameTextBox.Text);

            currentLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.currentLiabilityAmounts.Count(); i++)
            {

                currentLiabilitiesAccountInformationLabel.Text += MainForm.currentLiabilityNames[i] + " $" + MainForm.currentLiabilityAmounts[i] + "\n";
            }
        }

        private void removeCurrentLiabilityButton_Click(object sender, EventArgs e)
        {
            MainForm.currentLiabilityAmounts.Remove(Convert.ToDouble(removeCurrentLiabilitiesAccountAmountTextBox.Text));
            MainForm.currentLiabilityNames.Remove(Convert.ToString(removeCurrentLiabilitiesAccountNameTextBox.Text));
            currentLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.currentLiabilityAmounts.Count(); i++)
            {
                currentLiabilitiesAccountInformationLabel.Text += MainForm.currentLiabilityNames[i] + " $" + MainForm.currentLiabilityAmounts[i] + "\n";
            }
        }

        private void addLongTermLiabilitiyButton_Click(object sender, EventArgs e)
        {
            MainForm.longTermLiabilityAmounts.Add(Convert.ToDouble(addLongTermLiabilitiesAccountAmountTextBox.Text));

            MainForm.longTermLiabilityNames.Add(addLongTermLiabilitiesAccountNameTextBox.Text);

            longTermLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.longTermLiabilityAmounts.Count(); i++)
            {

                longTermLiabilitiesAccountInformationLabel.Text += MainForm.longTermLiabilityNames[i] + " $" + MainForm.longTermLiabilityAmounts[i] + "\n";
            }
        }

        private void removeLongTermLiabilityButton_Click(object sender, EventArgs e)
        {
            MainForm.longTermLiabilityAmounts.Remove(Convert.ToDouble(removeLongTermLiabilitiesAccountAmountTextBox.Text));
            MainForm.longTermLiabilityNames.Remove(Convert.ToString(removeLongTermLiabilitiesAccountNameTextBox.Text));
            longTermLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.longTermLiabilityAmounts.Count(); i++)
            {
                longTermLiabilitiesAccountInformationLabel.Text += MainForm.longTermLiabilityNames[i] + " $" + MainForm.longTermLiabilityAmounts[i] + "\n";
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            int Min = DateTime.Now.Minute;
            int Hour = DateTime.Now.Hour;
            int Day = DateTime.Now.Day;
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;
            timeLabel.Text = Month + "/" + Day + "/" + Year + "  " + Hour + ":" + Min;
            Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MainForm.businessName = businessNameTextBox.Text;
            MainForm.fiscalMonthEnd = fiscalMonthEndTextBox.Text;
            MainForm.beginningOfPeriod = Convert.ToDouble(beginningOfThePeriodTextBox.Text);
            MainForm.netIncome = Convert.ToDouble(netIncomeTextBox.Text);
            MainForm.drawings = Convert.ToDouble(drawingsTextBox.Text);
            timeLabel.Text = Month + "/" + Day + "/" + Year;
            MainForm.modifiedDate = timeLabel.Text;
            
        }
    }
}
