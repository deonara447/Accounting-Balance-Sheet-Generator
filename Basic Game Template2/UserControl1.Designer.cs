namespace Basic_Game_Template2
{
    partial class LoadingScreen
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(455, 661);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Logging In...";
            // 
            // loadingbarLabel
            // 
            this.loadingbarLabel.BackColor = System.Drawing.Color.Black;
            this.loadingbarLabel.Location = new System.Drawing.Point(400, 501);
            this.loadingbarLabel.Name = "loadingbarLabel";
            this.loadingbarLabel.Size = new System.Drawing.Size(10, 49);
            this.loadingbarLabel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(399, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 49);
            this.label4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.875F);
            this.label2.Location = new System.Drawing.Point(1108, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "®️";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Constantia", 30.875F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(139, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 191);
            this.label1.TabIndex = 6;
            this.label1.Text = "Balance Sheet Generator";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadingbarLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoadingScreen";
            this.Size = new System.Drawing.Size(1300, 1000);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loadingbarLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
