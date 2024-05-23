namespace NutritionTracker
{
    partial class SuccessMessage
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
            this.successBtn = new Guna.UI2.WinForms.Guna2Button();
            this.successLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.successBtn);
            this.panel1.Controls.Add(this.successLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 182);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // successBtn
            // 
            this.successBtn.BackColor = System.Drawing.Color.Ivory;
            this.successBtn.BorderColor = System.Drawing.Color.Ivory;
            this.successBtn.BorderRadius = 5;
            this.successBtn.BorderThickness = 1;
            this.successBtn.CheckedState.Parent = this.successBtn;
            this.successBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successBtn.CustomImages.Parent = this.successBtn;
            this.successBtn.FillColor = System.Drawing.Color.Empty;
            this.successBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successBtn.ForeColor = System.Drawing.Color.Black;
            this.successBtn.HoverState.Parent = this.successBtn;
            this.successBtn.Location = new System.Drawing.Point(47, 118);
            this.successBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.successBtn.Name = "successBtn";
            this.successBtn.ShadowDecoration.Parent = this.successBtn;
            this.successBtn.Size = new System.Drawing.Size(95, 33);
            this.successBtn.TabIndex = 3;
            this.successBtn.Text = "OK";
            this.successBtn.Click += new System.EventHandler(this.successBtn_Click);
            // 
            // successLbl
            // 
            this.successLbl.AutoSize = true;
            this.successLbl.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLbl.ForeColor = System.Drawing.Color.White;
            this.successLbl.Location = new System.Drawing.Point(108, 70);
            this.successLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLbl.Name = "successLbl";
            this.successLbl.Size = new System.Drawing.Size(252, 25);
            this.successLbl.TabIndex = 2;
            this.successLbl.Text = "Operation Completed successfully";
            this.successLbl.Click += new System.EventHandler(this.successLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Success";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::NutritionTracker.Properties.Resources.check2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(47, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 49);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SuccessMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(492, 182);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SuccessMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessMessage";
            this.Load += new System.EventHandler(this.SuccessMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button successBtn;
        public System.Windows.Forms.Label successLbl;
    }
}