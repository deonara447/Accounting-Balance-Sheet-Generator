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
            label3.Visible = true;
            label4.Visible = true;
            loadingbarLabel.Visible = true;

            //
            for (int i = 1; i <= 490; i++)

            {

                loadingbarLabel.Width++;
                Thread.Sleep(10);
                Refresh();
                if (i==151)
                {
                    label3.Text = "Initializing Components...";
                }

                if (i==325)
                {
                    label3.Text = "Retrieving Data...";
                }

                if (i == 461)
                {
                    Thread.Sleep(5000);
                    Refresh();
                }



            }
            MainForm.ChangeScreen(this, "test");
        }
    }
}
