namespace NutritionTracker
{
    partial class warningMessage
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
            this.warningBtn = new Guna.UI2.WinForms.Guna2Button();
            this.warningLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.warningBtn);
            this.panel1.Controls.Add(this.warningLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 148);
            this.panel1.TabIndex = 0;
            // 
            // warningBtn
            // 
            this.warningBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.warningBtn.BorderColor = System.Drawing.Color.Transparent;
            this.warningBtn.CheckedState.Parent = this.warningBtn;
            this.warningBtn.CustomImages.Parent = this.warningBtn;
            this.warningBtn.FillColor = System.Drawing.Color.Empty;
            this.warningBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningBtn.ForeColor = System.Drawing.Color.White;
            this.warningBtn.HoverState.Parent = this.warningBtn;
            this.warningBtn.Location = new System.Drawing.Point(35, 96);
            this.warningBtn.Name = "warningBtn";
            this.warningBtn.ShadowDecoration.Parent = this.warningBtn;
            this.warningBtn.Size = new System.Drawing.Size(71, 27);
            this.warningBtn.TabIndex = 9;
            this.warningBtn.Text = "OK";
            this.warningBtn.Click += new System.EventHandler(this.warningBtn_Click);
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLbl.ForeColor = System.Drawing.Color.Goldenrod;
            this.warningLbl.Location = new System.Drawing.Point(81, 57);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(45, 19);
            this.warningLbl.TabIndex = 8;
            this.warningLbl.Text = "Invalid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Warning";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::NutritionTracker.Properties.Resources.warning;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(35, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 40);
            this.panel2.TabIndex = 6;
            // 
            // warningMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 148);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "warningMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "warningMessage";
            this.Load += new System.EventHandler(this.warningMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2Button warningBtn;
        public System.Windows.Forms.Label warningLbl;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
    }
}