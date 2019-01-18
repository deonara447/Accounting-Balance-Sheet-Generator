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
            this.line1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.sidebarLabel.Click += new System.EventHandler(this.sidebarLabel_Click);
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
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 760);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 2);
            this.label1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label line1Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
