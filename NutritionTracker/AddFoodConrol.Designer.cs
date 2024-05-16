namespace NutritionTracker
{
    partial class AddFoodConrol
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
            this.foodDescLbl = new System.Windows.Forms.Label();
            this.brandNameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.servingSizeLbl = new System.Windows.Forms.Label();
            this.caloriesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foodDescLbl
            // 
            this.foodDescLbl.AutoSize = true;
            this.foodDescLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodDescLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.foodDescLbl.Location = new System.Drawing.Point(22, 19);
            this.foodDescLbl.Name = "foodDescLbl";
            this.foodDescLbl.Size = new System.Drawing.Size(121, 23);
            this.foodDescLbl.TabIndex = 112;
            this.foodDescLbl.Text = "Food Description";
            // 
            // brandNameLbl
            // 
            this.brandNameLbl.AutoSize = true;
            this.brandNameLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandNameLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.brandNameLbl.Location = new System.Drawing.Point(22, 42);
            this.brandNameLbl.Name = "brandNameLbl";
            this.brandNameLbl.Size = new System.Drawing.Size(167, 23);
            this.brandNameLbl.TabIndex = 113;
            this.brandNameLbl.Text = "Brand, 100 g, 100 calories\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(7, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 2);
            this.panel1.TabIndex = 179;
            // 
            // servingSizeLbl
            // 
            this.servingSizeLbl.AutoSize = true;
            this.servingSizeLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingSizeLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.servingSizeLbl.Location = new System.Drawing.Point(22, 65);
            this.servingSizeLbl.Name = "servingSizeLbl";
            this.servingSizeLbl.Size = new System.Drawing.Size(86, 23);
            this.servingSizeLbl.TabIndex = 182;
            this.servingSizeLbl.Text = "Serving Size";
            // 
            // caloriesLbl
            // 
            this.caloriesLbl.AutoSize = true;
            this.caloriesLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLbl.ForeColor = System.Drawing.Color.DarkGray;
            this.caloriesLbl.Location = new System.Drawing.Point(22, 88);
            this.caloriesLbl.Name = "caloriesLbl";
            this.caloriesLbl.Size = new System.Drawing.Size(63, 23);
            this.caloriesLbl.TabIndex = 183;
            this.caloriesLbl.Text = "Calories";
            // 
            // AddFoodConrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.caloriesLbl);
            this.Controls.Add(this.servingSizeLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.brandNameLbl);
            this.Controls.Add(this.foodDescLbl);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AddFoodConrol";
            this.Size = new System.Drawing.Size(451, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodDescLbl;
        private System.Windows.Forms.Label brandNameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label servingSizeLbl;
        private System.Windows.Forms.Label caloriesLbl;
    }
}
