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
            this.components = new System.ComponentModel.Container();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.registeredLabel = new System.Windows.Forms.Label();
            this.sidebarLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.feedbackButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.line1Label = new System.Windows.Forms.Label();
            this.line2Label = new System.Windows.Forms.Label();
            this.balanceSheetInformationButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.templateNameLabel = new System.Windows.Forms.Label();
            this.dateModifiedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.SeaGreen;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(0, 350);
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
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click_1);
            // 
            // feedbackButton
            // 
            this.feedbackButton.BackColor = System.Drawing.Color.SeaGreen;
            this.feedbackButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.feedbackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.feedbackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.feedbackButton.Click += new System.EventHandler(this.feedbackButton_Click_1);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.DarkGreen;
            this.homeButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 156);
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
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(0, 221);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(240, 63);
            this.newButton.TabIndex = 21;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click_1);
            // 
            // line1Label
            // 
            this.line1Label.Location = new System.Drawing.Point(25, 316);
            this.line1Label.Name = "line1Label";
            this.line1Label.Size = new System.Drawing.Size(192, 2);
            this.line1Label.TabIndex = 22;
            // 
            // line2Label
            // 
            this.line2Label.Location = new System.Drawing.Point(25, 760);
            this.line2Label.Name = "line2Label";
            this.line2Label.Size = new System.Drawing.Size(192, 2);
            this.line2Label.TabIndex = 23;
            // 
            // balanceSheetInformationButton
            // 
            this.balanceSheetInformationButton.Location = new System.Drawing.Point(239, 215);
            this.balanceSheetInformationButton.Name = "balanceSheetInformationButton";
            this.balanceSheetInformationButton.Size = new System.Drawing.Size(590, 57);
            this.balanceSheetInformationButton.TabIndex = 24;
            this.balanceSheetInformationButton.Text = "Untitled Document";
            this.balanceSheetInformationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balanceSheetInformationButton.UseVisualStyleBackColor = true;
            this.balanceSheetInformationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(1095, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(305, 51);
            this.timeLabel.TabIndex = 25;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // templateNameLabel
            // 
            this.templateNameLabel.AutoSize = true;
            this.templateNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.templateNameLabel.Location = new System.Drawing.Point(316, 178);
            this.templateNameLabel.Name = "templateNameLabel";
            this.templateNameLabel.Size = new System.Drawing.Size(86, 31);
            this.templateNameLabel.TabIndex = 26;
            this.templateNameLabel.Text = "Name";
            // 
            // dateModifiedLabel
            // 
            this.dateModifiedLabel.AutoSize = true;
            this.dateModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F);
            this.dateModifiedLabel.Location = new System.Drawing.Point(634, 173);
            this.dateModifiedLabel.Name = "dateModifiedLabel";
            this.dateModifiedLabel.Size = new System.Drawing.Size(181, 31);
            this.dateModifiedLabel.TabIndex = 27;
            this.dateModifiedLabel.Text = "Date Modified";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateModifiedLabel);
            this.Controls.Add(this.templateNameLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.balanceSheetInformationButton);
            this.Controls.Add(this.line2Label);
            this.Controls.Add(this.line1Label);
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
            this.Load += new System.EventHandler(this.MainScreen_Load);
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
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label line2Label;
        private System.Windows.Forms.Button balanceSheetInformationButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label templateNameLabel;
        private System.Windows.Forms.Label dateModifiedLabel;
    }
}
