namespace Basic_Game_Template2
{
    partial class MainScreen
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
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.registeredLabel = new System.Windows.Forms.Label();
            this.sidebarLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(0, 334);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(240, 63);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 20.875F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1400, 153);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Balance Sheet Generator";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // registeredLabel
            // 
            this.registeredLabel.AutoSize = true;
            this.registeredLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.registeredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.registeredLabel.Location = new System.Drawing.Point(1019, 30);
            this.registeredLabel.Name = "registeredLabel";
            this.registeredLabel.Size = new System.Drawing.Size(43, 39);
            this.registeredLabel.TabIndex = 16;
            this.registeredLabel.Text = "®️";
            // 
            // sidebarLabel
            // 
            this.sidebarLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.sidebarLabel.Location = new System.Drawing.Point(0, 150);
            this.sidebarLabel.Name = "sidebarLabel";
            this.sidebarLabel.Size = new System.Drawing.Size(240, 850);
            this.sidebarLabel.TabIndex = 17;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.SeaGreen;
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(0, 883);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(240, 117);
            this.helpButton.TabIndex = 18;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.SeaGreen;
            this.feedbackButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.feedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackButton.ForeColor = System.Drawing.Color.White;
            this.feedbackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedbackButton.Location = new System.Drawing.Point(0, 760);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(240, 117);
            this.feedbackButton.TabIndex = 19;
            this.feedbackButton.Text = "Feedback";
            this.feedbackButton.UseVisualStyleBackColor = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 150);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(240, 63);
            this.homeButton.TabIndex = 20;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.SeaGreen;
            this.newButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(0, 226);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(240, 63);
            this.newButton.TabIndex = 21;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.feedbackButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.registeredLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.sidebarLabel);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1400, 1000);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label registeredLabel;
        private System.Windows.Forms.Label sidebarLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button newButton;
    }
}
