namespace Basic_Game_Template2
{
    partial class LoginScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressInformationLabel = new System.Windows.Forms.Label();
            this.loadingbarLabel = new System.Windows.Forms.Label();
            this.progressBox = new System.Windows.Forms.Label();
            this.registeredLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressInformationLabel
            // 
            this.progressInformationLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.progressInformationLabel.Location = new System.Drawing.Point(496, 613);
            this.progressInformationLabel.Name = "progressInformationLabel";
            this.progressInformationLabel.Size = new System.Drawing.Size(369, 33);
            this.progressInformationLabel.TabIndex = 16;
            this.progressInformationLabel.Text = "Logging In...";
            this.progressInformationLabel.Visible = false;
            // 
            // loadingbarLabel
            // 
            this.loadingbarLabel.BackColor = System.Drawing.Color.Black;
            this.loadingbarLabel.Location = new System.Drawing.Point(436, 480);
            this.loadingbarLabel.Name = "loadingbarLabel";
            this.loadingbarLabel.Size = new System.Drawing.Size(10, 49);
            this.loadingbarLabel.TabIndex = 14;
            this.loadingbarLabel.Visible = false;
            // 
            // progressBox
            // 
            this.progressBox.BackColor = System.Drawing.Color.White;
            this.progressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBox.Location = new System.Drawing.Point(435, 480);
            this.progressBox.Name = "progressBox";
            this.progressBox.Size = new System.Drawing.Size(500, 49);
            this.progressBox.TabIndex = 15;
            this.progressBox.Visible = false;
            // 
            // registeredLabel
            // 
            this.registeredLabel.AutoSize = true;
            this.registeredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.875F);
            this.registeredLabel.Location = new System.Drawing.Point(1144, 300);
            this.registeredLabel.Name = "registeredLabel";
            this.registeredLabel.Size = new System.Drawing.Size(54, 51);
            this.registeredLabel.TabIndex = 13;
            this.registeredLabel.Text = "®️";
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 30.875F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(175, 315);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1007, 191);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Balance Sheet Generator";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.875F);
            this.LoginButton.Location = new System.Drawing.Point(529, 505);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(268, 105);
            this.LoginButton.TabIndex = 17;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loadingbarLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.progressInformationLabel);
            this.Controls.Add(this.progressBox);
            this.Controls.Add(this.registeredLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(1400, 1000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progressInformationLabel;
        private System.Windows.Forms.Label loadingbarLabel;
        private System.Windows.Forms.Label progressBox;
        private System.Windows.Forms.Label registeredLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}
