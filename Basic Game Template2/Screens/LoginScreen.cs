using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Basic_Game_Template2
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginButton.Visible = false;
            progressInformationLabel.Visible = true;
            progressBox.Visible = true;
            loadingbarLabel.Visible = true;

            //
            for (int i = 489; i <= 490; i++)

            {

                loadingbarLabel.Width++;
                Thread.Sleep(10);
                Refresh();
                if (i==151)
                {
                    progressInformationLabel.Text = "Initializing Components...";
                }

                if (i==325)
                {
                    progressInformationLabel.Text = "Retrieving Data...";
                }

                if (i == 461)
                {
                    Thread.Sleep(5000);
                    Refresh();
                }



            }
            MainForm.ChangeScreen(this, "MainScreen");
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            MainForm.businessName = "Untitled Template";
            MainForm.modifiedDate = "1/19/19";

        }
    }
}
