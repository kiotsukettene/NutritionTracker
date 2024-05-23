namespace NutritionTracker
{
    partial class FailedMessage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.failedBtn = new Guna.UI2.WinForms.Guna2Button();
            this.failedLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.failedBtn);
            this.panel1.Controls.Add(this.failedLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 182);
            this.panel1.TabIndex = 0;
            // 
            // failedBtn
            // 
            this.failedBtn.BackColor = System.Drawing.Color.Ivory;
            this.failedBtn.BorderColor = System.Drawing.Color.Ivory;
            this.failedBtn.CheckedState.Parent = this.failedBtn;
            this.failedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.failedBtn.CustomImages.Parent = this.failedBtn;
            this.failedBtn.FillColor = System.Drawing.Color.Empty;
            this.failedBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedBtn.ForeColor = System.Drawing.Color.Black;
            this.failedBtn.HoverState.Parent = this.failedBtn;
            this.failedBtn.Location = new System.Drawing.Point(47, 118);
            this.failedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.failedBtn.Name = "failedBtn";
            this.failedBtn.ShadowDecoration.Parent = this.failedBtn;
            this.failedBtn.Size = new System.Drawing.Size(95, 33);
            this.failedBtn.TabIndex = 5;
            this.failedBtn.Text = "OK";
            this.failedBtn.Click += new System.EventHandler(this.failedBtn_Click);
            // 
            // failedLbl
            // 
            this.failedLbl.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedLbl.ForeColor = System.Drawing.Color.White;
            this.failedLbl.Location = new System.Drawing.Point(108, 70);
            this.failedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.failedLbl.Name = "failedLbl";
            this.failedLbl.Size = new System.Drawing.Size(368, 44);
            this.failedLbl.TabIndex = 4;
            this.failedLbl.Text = "Operation unsuccessful";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Failed";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::NutritionTracker.Properties.Resources.close3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(47, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 49);
            this.panel2.TabIndex = 1;
            // 
            // FailedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(492, 182);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FailedMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FailedMessage";
            this.Load += new System.EventHandler(this.FailedMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label failedLbl;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button failedBtn;
    }
}