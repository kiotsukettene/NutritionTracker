﻿namespace NutritionTracker
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
            this.label1 = new System.Windows.Forms.Label();
            this.successLbl = new System.Windows.Forms.Label();
            this.successBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.successBtn);
            this.panel1.Controls.Add(this.successLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 148);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Success";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // successLbl
            // 
            this.successLbl.AutoSize = true;
            this.successLbl.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLbl.ForeColor = System.Drawing.Color.White;
            this.successLbl.Location = new System.Drawing.Point(81, 57);
            this.successLbl.Name = "successLbl";
            this.successLbl.Size = new System.Drawing.Size(200, 19);
            this.successLbl.TabIndex = 2;
            this.successLbl.Text = "Operation Completed successfully";
            this.successLbl.Click += new System.EventHandler(this.successLbl_Click);
            // 
            // successBtn
            // 
            this.successBtn.BackColor = System.Drawing.Color.Ivory;
            this.successBtn.BorderColor = System.Drawing.Color.Transparent;
            this.successBtn.BorderRadius = 5;
            this.successBtn.BorderThickness = 1;
            this.successBtn.CheckedState.Parent = this.successBtn;
            this.successBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successBtn.CustomImages.Parent = this.successBtn;
            this.successBtn.FillColor = System.Drawing.Color.Empty;
            this.successBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successBtn.ForeColor = System.Drawing.Color.Black;
            this.successBtn.HoverState.Parent = this.successBtn;
            this.successBtn.Location = new System.Drawing.Point(35, 96);
            this.successBtn.Name = "successBtn";
            this.successBtn.ShadowDecoration.Parent = this.successBtn;
            this.successBtn.Size = new System.Drawing.Size(71, 27);
            this.successBtn.TabIndex = 3;
            this.successBtn.Text = "OK";
            this.successBtn.Click += new System.EventHandler(this.successBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::NutritionTracker.Properties.Resources.check2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(35, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 40);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SuccessMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(369, 148);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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