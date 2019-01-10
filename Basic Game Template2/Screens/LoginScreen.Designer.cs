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
            this.label3 = new System.Windows.Forms.Label();
            this.loadingbarLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(460, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Logging In...";
            this.label3.Visible = false;
            // 
            // loadingbarLabel
            // 
            this.loadingbarLabel.BackColor = System.Drawing.Color.Black;
            this.loadingbarLabel.Location = new System.Drawing.Point(400, 494);
            this.loadingbarLabel.Name = "loadingbarLabel";
            this.loadingbarLabel.Size = new System.Drawing.Size(10, 49);
            this.loadingbarLabel.TabIndex = 14;
            this.loadingbarLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(399, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 49);
            this.label4.TabIndex = 15;
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.875F);
            this.label2.Location = new System.Drawing.Point(1108, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 51);
            this.label2.TabIndex = 13;
            this.label2.Text = "®️";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Constantia", 30.875F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(139, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 191);
            this.label1.TabIndex = 12;
            this.label1.Text = "Balance Sheet Generator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 88);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loadingbarLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(1300, 1000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loadingbarLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
