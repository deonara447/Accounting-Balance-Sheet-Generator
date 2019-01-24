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

namespace DeoNarayanICS3UFinalProject
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //program starts 'loading'
            LoginButton.Visible = false;
            progressInformationLabel.Visible = true;
            progressBox.Visible = true;
            loadingbarLabel.Visible = true;

            //mimicking an actual 'loading' screen
            for (int i = 490; i <= 490; i++)
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

            //screen changes to 'main screen' once done loading
            MainForm.ChangeScreen(this, "MainScreen");
        }
    }
}
