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

        public BalanceSheetInformationScreen()
        {

            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //changes screen to the 'main screen'
            MainForm.ChangeScreen(this, "MainScreen");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //Resets all variables and lists to their original states
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

            //Resets all textboxes and output labels to their original states
            businessNameTextBox.Text = "";
            fiscalMonthEndTextBox.Text = "(Month Day, Year)";
            currentAssetsAccountAmountTextBox.Text = "";
            currentAssetsAccountNameTextBox.Text = "";
            fixedAssetsAccountAmountTextBox.Text = "";
            fixedAssetsAccountNameTextBox.Text = "";
            currentLiabilitiesAccountAmountTextBox.Text = "";
            currentLiabilitiesAccountNameTextBox.Text = "";
            longTermLiabilitiesAccountAmountTextBox.Text = "";
            longTermLiabilitiesAccountNameTextBox.Text = "";
            beginningOfThePeriodTextBox.Text = "";
            netIncomeTextBox.Text = "";
            drawingsTextBox.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Closes the program
            Application.Exit();
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            //Change screen to 'feedback screen'
            MainForm.ChangeScreen(this, "FeedbackScreen");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            //Change screen to 'help screen'
            MainForm.ChangeScreen(this, "HelpScreen");
        }

        private void balanceSheetButton_Click(object sender, EventArgs e)
        {
            //changes screen to 'balance sheet template screen'
            MainForm.ChangeScreen(this, "BalanceSheetTemplateScreen");
        }

        private void addCurrentAssetButton_Click(object sender, EventArgs e)
        {
            //so program will not crash if textbox inputs are not numerical values
            try
            {
                //ensuring that both the account name and amount textboxes are filled in
                if (currentAssetsAccountNameTextBox.Text == "" || currentAssetsAccountAmountTextBox.Text == "")
                {
                    //Shows error screen informing user that not all textboxes are filled in
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    //Ensuring that only two accounts are allowed in this section
                    if (MainForm.currentAssetAmounts.Count() == 2)
                    {
                        //Shows error screen informing user that they cannot create more than two accounts in this section
                        MessageBox.Show("You must download the PRO version in order to create more than two accounts in this section");
                    }
                    else
                    {
                        //Adds textbox inputs to their lists
                        MainForm.currentAssetAmounts.Add(Convert.ToDouble(currentAssetsAccountAmountTextBox.Text));
                        MainForm.currentAssetNames.Add(currentAssetsAccountNameTextBox.Text);

                        //Makes label blank
                        currentAssetsAccountInformationLabel.Text = "";

                        //Displays all the current asset names and account amounts
                        for (int i = 0; i < MainForm.currentAssetAmounts.Count(); i++)
                        {
                            currentAssetsAccountInformationLabel.Text += MainForm.currentAssetNames[i] + " " + MainForm.currentAssetAmounts[i].ToString("C") + "\n";
                        }
                    }
                }
            }
            catch
            {
                //Shows error screen informing the user that the textbox input must be a number
                MessageBox.Show("Account amount input must be a numerical value");
            }

        }

        private void removeCurrentAssetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove this account?","gh",MessageBoxButtons.YesNo);
           // if (DialogResult== result)
           if (result == DialogResult.Yes)
            {
                
            }
            else
            {

            }
           // if he 
            try
            {
                if (currentAssetsAccountNameTextBox.Text == "" || currentAssetsAccountAmountTextBox.Text == "")
                {
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    //Removes textbox accounts from their lists
                    MainForm.currentAssetAmounts.Remove(Convert.ToDouble(currentAssetsAccountAmountTextBox.Text));
                    MainForm.currentAssetNames.Remove(Convert.ToString(currentAssetsAccountNameTextBox.Text));

                    //Shows updated account names and amounts
                    currentAssetsAccountInformationLabel.Text = "";
                    for (int i = 0; i < MainForm.currentAssetAmounts.Count(); i++)
                    {
                        currentAssetsAccountInformationLabel.Text += MainForm.currentAssetNames[i] + " " + MainForm.currentAssetAmounts[i].ToString("C") + "\n";
                    }
                }

            }
            catch
            {
                MessageBox.Show("Account amount input must be a numerical value");
            }
        }

        private void addFixedAssetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fixedAssetsAccountNameTextBox.Text == "" || fixedAssetsAccountAmountTextBox.Text == "")
                {
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    if (MainForm.fixedAssetAmounts.Count() == 2)
                    {
                        MessageBox.Show("You must download the PRO version in order to create more than two accounts in this section");
                    }
                    else
                    {
                        MainForm.fixedAssetAmounts.Add(Convert.ToDouble(fixedAssetsAccountAmountTextBox.Text));

            MainForm.fixedAssetNames.Add(fixedAssetsAccountNameTextBox.Text);

            fixedAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.fixedAssetAmounts.Count(); i++)
            {

                fixedAssetsAccountInformationLabel.Text += MainForm.fixedAssetNames[i] + " " + MainForm.fixedAssetAmounts[i].ToString("C") + "\n";
            }
                }
                }
            }
            catch
            {
                MessageBox.Show("Account amount input must be a numerical value");
            }


        }


        private void removeFixedAssetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fixedAssetsAccountNameTextBox.Text == "" || fixedAssetsAccountAmountTextBox.Text == "")
                {
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    MainForm.fixedAssetAmounts.Remove(Convert.ToDouble(fixedAssetsAccountAmountTextBox.Text));
            MainForm.fixedAssetNames.Remove(Convert.ToString(fixedAssetsAccountNameTextBox.Text));
            fixedAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.fixedAssetAmounts.Count(); i++)
            {
                fixedAssetsAccountInformationLabel.Text += MainForm.fixedAssetNames[i] + " " + MainForm.fixedAssetAmounts[i].ToString("C") + "\n";
            }
                }

            }
            catch
            {
                MessageBox.Show("Account amount input must be a numerical value");
            }
        }

        private void addCurrentLiabilityButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentLiabilitiesAccountNameTextBox.Text == "" || currentLiabilitiesAccountAmountTextBox.Text == "")
                {
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    if (MainForm.currentLiabilityAmounts.Count() == 2)
                    {
                        MessageBox.Show("You must download the PRO version in order to create more than two accounts in this section");
                    }
                    else
                    {
                        MainForm.currentLiabilityAmounts.Add(Convert.ToDouble(currentLiabilitiesAccountAmountTextBox.Text));

            MainForm.currentLiabilityNames.Add(currentLiabilitiesAccountNameTextBox.Text);

            currentLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.currentLiabilityAmounts.Count(); i++)
            {

                currentLiabilitiesAccountInformationLabel.Text += MainForm.currentLiabilityNames[i] + " " + MainForm.currentLiabilityAmounts[i].ToString("C") + "\n";
            }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Account amount input must be a numerical value");
            }
        }

        private void removeCurrentLiabilityButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentLiabilitiesAccountNameTextBox.Text == "" || currentLiabilitiesAccountAmountTextBox.Text == "")
                {
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    MainForm.currentLiabilityAmounts.Remove(Convert.ToDouble(currentLiabilitiesAccountAmountTextBox.Text));
            MainForm.currentLiabilityNames.Remove(Convert.ToString(currentLiabilitiesAccountNameTextBox.Text));
            currentLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.currentLiabilityAmounts.Count(); i++)
            {
                currentLiabilitiesAccountInformationLabel.Text += MainForm.currentLiabilityNames[i] + " " + MainForm.currentLiabilityAmounts[i].ToString("C") + "\n";
            }
                }

            }
            catch
            {
                MessageBox.Show("Account amount input must be a numerical value");
            }
        }

        private void addLongTermLiabilitiyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (longTermLiabilitiesAccountNameTextBox.Text == "" || longTermLiabilitiesAccountAmountTextBox.Text == "")
                {
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    if (MainForm.longTermLiabilityAmounts.Count() == 2)
                    {
                        MessageBox.Show("You must download the PRO version in order to create more than two accounts in this section");
                    }
                    else
                    {
                        MainForm.longTermLiabilityAmounts.Add(Convert.ToDouble(longTermLiabilitiesAccountNameTextBox.Text));

                        MainForm.longTermLiabilityAmounts.Add(Convert.ToDouble(longTermLiabilitiesAccountAmountTextBox.Text));

            MainForm.longTermLiabilityNames.Add(longTermLiabilitiesAccountNameTextBox.Text);

                    
            longTermLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.longTermLiabilityAmounts.Count(); i++)
            {

                longTermLiabilitiesAccountInformationLabel.Text += MainForm.longTermLiabilityNames[i] + " " + MainForm.longTermLiabilityAmounts[i].ToString("C") + "\n";
            }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Account amount input must be a numerical value");
            }
        }

        private void removeLongTermLiabilityButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (longTermLiabilitiesAccountNameTextBox.Text == "" || longTermLiabilitiesAccountAmountTextBox.Text == "")
                {
                    MessageBox.Show("All required textboxes must be filled in");
                }
                else
                {
                    MainForm.longTermLiabilityAmounts.Remove(Convert.ToDouble(longTermLiabilitiesAccountAmountTextBox.Text));
            MainForm.longTermLiabilityNames.Remove(Convert.ToString(longTermLiabilitiesAccountNameTextBox.Text));
            longTermLiabilitiesAccountInformationLabel.Text = "";
            for (int i = 0; i < MainForm.longTermLiabilityAmounts.Count(); i++)
            {
                longTermLiabilitiesAccountInformationLabel.Text += MainForm.longTermLiabilityNames[i] + " " + MainForm.longTermLiabilityAmounts[i].ToString("C") + "\n";
            }
                }

            }
            catch
            {
                MessageBox.Show("Account amount input must be a numerical value");
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            //Creates integers holding time values
            int Min = DateTime.Now.Minute;
            int Hour = DateTime.Now.Hour;
            int Day = DateTime.Now.Day;
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;

            //Updates time and date
            timeLabel.Text = Month.ToString("00") + "/" + Day.ToString("00") + "/" + Year.ToString("00") + "  " + Hour.ToString("00") + ":" + Min.ToString("00");
            dateLabel.Text = Month + "/" + Day + "/" + Year;
            Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //saving business information (so that it can be transfered between screen)
                MainForm.businessName = businessNameTextBox.Text;
                MainForm.fiscalMonthEnd = fiscalMonthEndTextBox.Text;
                MainForm.beginningOfPeriod = Convert.ToDouble(beginningOfThePeriodTextBox.Text);
                MainForm.netIncome = Convert.ToDouble(netIncomeTextBox.Text);
                MainForm.drawings = Convert.ToDouble(drawingsTextBox.Text);
                MainForm.modifiedDate = dateLabel.Text;
            }
            catch
            {
                //Shows error screen informing user that the textboxes must be filled in and a numerical value in some instances
                MessageBox.Show("Textboxes must be filled in and a numerical value wherever necessary");
            }
            
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //resets all variable and list values
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

            //resets all textbox and list values
            businessNameTextBox.Text = "";
            fiscalMonthEndTextBox.Text = "(Month Day, Year)";
            currentAssetsAccountAmountTextBox.Text = "";
            fixedAssetsAccountAmountTextBox.Text = "";
            fixedAssetsAccountNameTextBox.Text = "";
            currentLiabilitiesAccountAmountTextBox.Text = "";
            longTermLiabilitiesAccountAmountTextBox.Text = "";
            longTermLiabilitiesAccountNameTextBox.Text = "";
            beginningOfThePeriodTextBox.Text = "";
            netIncomeTextBox.Text = "";
            drawingsTextBox.Text = "";

            //changes screen to 'main screen'
            MainForm.ChangeScreen(this, "MainScreen");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //same as delete except you do not change screens
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

            businessNameTextBox.Text = "";
            fiscalMonthEndTextBox.Text = "(Month Day, Year)";
            currentAssetsAccountAmountTextBox.Text = "";
            fixedAssetsAccountAmountTextBox.Text = "";
            fixedAssetsAccountNameTextBox.Text = "";
            currentLiabilitiesAccountAmountTextBox.Text = "";
            currentLiabilitiesAccountNameTextBox.Text = "";
            longTermLiabilitiesAccountAmountTextBox.Text = "";
            longTermLiabilitiesAccountNameTextBox.Text = "";
            beginningOfThePeriodTextBox.Text = "";
            netIncomeTextBox.Text = "";
            drawingsTextBox.Text = "";
        }

        private void BalanceSheetInformationScreen_Load(object sender, EventArgs e)
        {
            if (MainForm.reset == false)
            {
                //Loads saved information onto the screen
                businessNameTextBox.Text = MainForm.businessName;
                fiscalMonthEndTextBox.Text = MainForm.fiscalMonthEnd;
                beginningOfThePeriodTextBox.Text = MainForm.beginningOfPeriod + "";
                netIncomeTextBox.Text = MainForm.netIncome + "";
                drawingsTextBox.Text = MainForm.drawings + "";

                for (int i = 0; i < MainForm.currentAssetAmounts.Count(); i++)
                {

                    currentAssetsAccountInformationLabel.Text += MainForm.currentAssetNames[i] + " " + MainForm.currentAssetAmounts[i].ToString("C") + "\n";
                }

                for (int i = 0; i < MainForm.fixedAssetAmounts.Count(); i++)
                {

                    fixedAssetsAccountInformationLabel.Text += MainForm.fixedAssetNames[i] + " " + MainForm.fixedAssetAmounts[i].ToString("C") + "\n";
                }

                for (int i = 0; i < MainForm.currentLiabilityAmounts.Count(); i++)
                {

                    currentLiabilitiesAccountInformationLabel.Text += MainForm.currentLiabilityNames[i] + " " + MainForm.currentLiabilityAmounts[i].ToString("C") + "\n";
                }

                for (int i = 0; i < MainForm.longTermLiabilityAmounts.Count(); i++)
                {

                    longTermLiabilitiesAccountInformationLabel.Text += MainForm.longTermLiabilityNames[i] + " " + MainForm.longTermLiabilityAmounts[i].ToString("C") + "\n";
                }

            }
            else
            {
                //nothing is loaded onto the screen and thus resets
                
                //so  next time it will not reset unless later told otherwise
                MainForm.reset = false;
            }
        }
    }
}
