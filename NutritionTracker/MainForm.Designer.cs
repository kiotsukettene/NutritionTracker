namespace NutritionTracker
{
    partial class MainForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.miniBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personalizationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.fdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.calculatorBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.exitBtn);
            this.guna2Panel1.Controls.Add(this.miniBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(74, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1110, 39);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = global::NutritionTracker.Properties.Resources.close;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(1072, 6);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(33, 28);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Click += new System.EventHandler(this.closeBtn);
            // 
            // miniBtn
            // 
            this.miniBtn.BackgroundImage = global::NutritionTracker.Properties.Resources.minus;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.miniBtn.CheckedState.Parent = this.miniBtn;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.miniBtn.CustomImages.Parent = this.miniBtn;
            this.miniBtn.FillColor = System.Drawing.Color.Transparent;
            this.miniBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.miniBtn.ForeColor = System.Drawing.Color.White;
            this.miniBtn.HoverState.Parent = this.miniBtn;
            this.miniBtn.Location = new System.Drawing.Point(1033, 6);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.ShadowDecoration.Parent = this.miniBtn;
            this.miniBtn.Size = new System.Drawing.Size(33, 28);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.Click += new System.EventHandler(this.minBtn);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.personalizationBtn);
            this.panel1.Controls.Add(this.fdBtn);
            this.panel1.Controls.Add(this.calculatorBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 700);
            this.panel1.TabIndex = 1;
            // 
            // personalizationBtn
            // 
            this.personalizationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.personalizationBtn.CheckedState.Parent = this.personalizationBtn;
            this.personalizationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personalizationBtn.CustomImages.Parent = this.personalizationBtn;
            this.personalizationBtn.FillColor = System.Drawing.Color.Transparent;
            this.personalizationBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personalizationBtn.ForeColor = System.Drawing.Color.White;
            this.personalizationBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.personalizationBtn.HoverState.Image = global::NutritionTracker.Properties.Resources.settings;
            this.personalizationBtn.HoverState.Parent = this.personalizationBtn;
            this.personalizationBtn.Image = global::NutritionTracker.Properties.Resources.settings_gray;
            this.personalizationBtn.Location = new System.Drawing.Point(0, 322);
            this.personalizationBtn.Name = "personalizationBtn";
            this.personalizationBtn.ShadowDecoration.Parent = this.personalizationBtn;
            this.personalizationBtn.Size = new System.Drawing.Size(74, 55);
            this.personalizationBtn.TabIndex = 3;
            this.personalizationBtn.Click += new System.EventHandler(this.personalizationBtn_Click);
            // 
            // fdBtn
            // 
            this.fdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fdBtn.CheckedState.Parent = this.fdBtn;
            this.fdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fdBtn.CustomImages.Parent = this.fdBtn;
            this.fdBtn.FillColor = System.Drawing.Color.Transparent;
            this.fdBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fdBtn.ForeColor = System.Drawing.Color.White;
            this.fdBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.fdBtn.HoverState.Image = global::NutritionTracker.Properties.Resources.add;
            this.fdBtn.HoverState.Parent = this.fdBtn;
            this.fdBtn.Image = global::NutritionTracker.Properties.Resources.add_gray;
            this.fdBtn.Location = new System.Drawing.Point(0, 270);
            this.fdBtn.Name = "fdBtn";
            this.fdBtn.ShadowDecoration.Parent = this.fdBtn;
            this.fdBtn.Size = new System.Drawing.Size(74, 55);
            this.fdBtn.TabIndex = 3;
            this.fdBtn.Click += new System.EventHandler(this.fdBtn_Click);
            // 
            // calculatorBtn
            // 
            this.calculatorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.calculatorBtn.CheckedState.Parent = this.calculatorBtn;
            this.calculatorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculatorBtn.CustomImages.Parent = this.calculatorBtn;
            this.calculatorBtn.FillColor = System.Drawing.Color.Transparent;
            this.calculatorBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calculatorBtn.ForeColor = System.Drawing.Color.White;
            this.calculatorBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.calculatorBtn.HoverState.Image = global::NutritionTracker.Properties.Resources.calc;
            this.calculatorBtn.HoverState.Parent = this.calculatorBtn;
            this.calculatorBtn.Image = global::NutritionTracker.Properties.Resources.calc_gray;
            this.calculatorBtn.Location = new System.Drawing.Point(0, 218);
            this.calculatorBtn.Name = "calculatorBtn";
            this.calculatorBtn.ShadowDecoration.Parent = this.calculatorBtn;
            this.calculatorBtn.Size = new System.Drawing.Size(74, 55);
            this.calculatorBtn.TabIndex = 3;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dashboardBtn.CheckedState.Parent = this.dashboardBtn;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.CustomImages.Parent = this.dashboardBtn;
            this.dashboardBtn.FillColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashboardBtn.ForeColor = System.Drawing.Color.White;
            this.dashboardBtn.HoverState.FillColor = System.Drawing.Color.Black;
            this.dashboardBtn.HoverState.Image = global::NutritionTracker.Properties.Resources.home__1_1;
            this.dashboardBtn.HoverState.Parent = this.dashboardBtn;
            this.dashboardBtn.Image = global::NutritionTracker.Properties.Resources.home__1_;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 166);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.ShadowDecoration.Parent = this.dashboardBtn;
            this.dashboardBtn.Size = new System.Drawing.Size(74, 55);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::NutritionTracker.Properties.Resources.logo_green;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(7, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 52);
            this.panel3.TabIndex = 4;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(74, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(1110, 669);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1184, 700);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button miniBtn;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private Guna.UI2.WinForms.Guna2Button personalizationBtn;
        private Guna.UI2.WinForms.Guna2Button fdBtn;
        private Guna.UI2.WinForms.Guna2Button calculatorBtn;
  
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
    }
}

