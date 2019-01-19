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
        List<double> friendName = new List<double>();
        List<string> freindName = new List<string>();
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
            
            friendName.Add(Convert.ToDouble(addCurrentAssetsAccountAmountTextBox.Text));
            
            freindName.Add(addCurrentAssetsAccountNameTextBox.Text);

            currentAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < friendName.Count(); i++)
            {
                
                currentAssetsAccountInformationLabel.Text += freindName[i] + " $" + friendName[i] + "\n";
            }

        }

        private void removeCurrentAssetButton_Click(object sender, EventArgs e)
        {
            friendName.Remove(Convert.ToDouble(removeCurrentAssetsAccountAmountTextBox.Text));
            freindName.Remove(Convert.ToString(removeCurrentAssetsAccountNameTextBox.Text));
            currentAssetsAccountInformationLabel.Text = "";
            for (int i = 0; i < friendName.Count(); i++)
            {
                
                currentAssetsAccountInformationLabel.Text += freindName[i] + " $" + friendName[i] + "\n";
            }
        }
    }
}
