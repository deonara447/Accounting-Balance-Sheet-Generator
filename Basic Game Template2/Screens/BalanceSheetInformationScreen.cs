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
        List<double> currentAssetAmounts = new List<double>();
        List<string> currentAssetNames = new List<string>();
        List<double> fixedAssetAmounts = new List<double>();
        List<string> fixedAssetNames = new List<string>();
        List<double> currentLiabilityAmounts = new List<double>();
        List<string> currentLiabilityNames = new List<string>();
        List<double> longTermLiabilityAmounts = new List<double>();
        List<string> longTermLiabilityNames = new List<string>();

        public BalanceSheetInformationScreen()
        {

            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //clear all data
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
            
            currentAssetAmounts.Add(Convert.ToDouble(addCurrentAssetsAccountAmountTextBox.Text));
            
            currentAssetNames.Add(addCurrentAssetsAccountNameTextBox.Text);

            currentAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < currentAssetAmounts.Count(); i++)
            {
                
                currentAssetsAccountInformationLabel.Text += currentAssetNames[i] + " $" + currentAssetAmounts[i] + "\n";
            }

        }

        private void removeCurrentAssetButton_Click(object sender, EventArgs e)
        {
            currentAssetAmounts.Remove(Convert.ToDouble(removeCurrentAssetsAccountAmountTextBox.Text));
            currentAssetNames.Remove(Convert.ToString(removeCurrentAssetsAccountNameTextBox.Text));
            currentAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < currentAssetAmounts.Count(); i++)
            {
                currentAssetsAccountInformationLabel.Text += currentAssetNames[i] + " $" + currentAssetAmounts[i] + "\n";
            }
        }

        private void addFixedAssetButton_Click(object sender, EventArgs e)
        {
            fixedAssetAmounts.Add(Convert.ToDouble(addFixedAssetsAccountAmountTextBox.Text));

            fixedAssetNames.Add(addFixedAssetsAccountNameTextBox.Text);

            fixedAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < fixedAssetAmounts.Count(); i++)
            {

                fixedAssetsAccountInformationLabel.Text += fixedAssetNames[i] + " $" + fixedAssetAmounts[i] + "\n";
            }
        }

        private void removeFixedAssetButton_Click(object sender, EventArgs e)
        {
            fixedAssetAmounts.Remove(Convert.ToDouble(removeFixedAssetsAccountAmountTextBox.Text));
            fixedAssetNames.Remove(Convert.ToString(removeFixedAssetsAccountNameTextBox.Text));
            fixedAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < fixedAssetAmounts.Count(); i++)
            {
                fixedAssetsAccountInformationLabel.Text += fixedAssetNames[i] + " $" + fixedAssetAmounts[i] + "\n";
            }
        }

        private void addCurrentLiabilityButton_Click(object sender, EventArgs e)
        {
            currentLiabilityAmounts.Add(Convert.ToDouble(addCurrentLiabilitiesAccountAmountTextBox.Text));

            currentLiabilityNames.Add(addCurrentLiabilitiesAccountNameTextBox.Text);

            currentLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < currentLiabilityAmounts.Count(); i++)
            {

                currentLiabilitiesAccountInformationLabel.Text += currentLiabilityNames[i] + " $" + currentLiabilityAmounts[i] + "\n";
            }
        }

        private void removeCurrentLiabilityButton_Click(object sender, EventArgs e)
        {
            currentLiabilityAmounts.Remove(Convert.ToDouble(removeCurrentLiabilitiesAccountAmountTextBox.Text));
            currentLiabilityNames.Remove(Convert.ToString(removeCurrentLiabilitiesAccountNameTextBox.Text));
            currentLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < currentLiabilityAmounts.Count(); i++)
            {
                currentLiabilitiesAccountInformationLabel.Text += currentLiabilityNames[i] + " $" + currentLiabilityAmounts[i] + "\n";
            }
        }

        private void addLongTermLiabilitiyButton_Click(object sender, EventArgs e)
        {
            longTermLiabilityAmounts.Add(Convert.ToDouble(addLongTermLiabilitiesAccountAmountTextBox.Text));

            longTermLiabilityNames.Add(addLongTermLiabilitiesAccountNameTextBox.Text);

            longTermLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < longTermLiabilityAmounts.Count(); i++)
            {

                longTermLiabilitiesAccountInformationLabel.Text += longTermLiabilityNames[i] + " $" + longTermLiabilityAmounts[i] + "\n";
            }
        }

        private void removeLongTermLiabilityButton_Click(object sender, EventArgs e)
        {
            longTermLiabilityAmounts.Remove(Convert.ToDouble(removeLongTermLiabilitiesAccountAmountTextBox.Text));
            longTermLiabilityNames.Remove(Convert.ToString(removeLongTermLiabilitiesAccountNameTextBox.Text));
            longTermLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < longTermLiabilityAmounts.Count(); i++)
            {
                longTermLiabilitiesAccountInformationLabel.Text += longTermLiabilityNames[i] + " $" + longTermLiabilityAmounts[i] + "\n";
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
    }
}
