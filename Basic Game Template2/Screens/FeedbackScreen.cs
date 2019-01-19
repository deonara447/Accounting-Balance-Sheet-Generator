﻿using System;
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
    public partial class FeedbackScreen: UserControl
    {
        public FeedbackScreen()
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
            MainForm.ChangeScreen(this, "BusinessInformationScreen");

            MainForm.reset = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MainForm.ChangeScreen(this, "HelpScreen");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            appreciateLabel.Visible = true;
            feedbackTextBox.Text = "";
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
