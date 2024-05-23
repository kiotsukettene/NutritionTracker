namespace NutritionTracker
{
    partial class FoodDiary
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
            this.FDLabel = new System.Windows.Forms.Label();
            this.dbDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.addFoodBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.proteinLbl = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fatLbl = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.carbLbl = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.calLbl = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.unitLbl = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.fdLbl = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.mealLbl = new System.Windows.Forms.Label();
            this.fdUsername = new System.Windows.Forms.Label();
            this.foodDiaryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fdTotalPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.fdProtein = new System.Windows.Forms.Label();
            this.RemainProtein = new System.Windows.Forms.Label();
            this.TotalProtein = new System.Windows.Forms.Label();
            this.fdFat = new System.Windows.Forms.Label();
            this.RemainFat = new System.Windows.Forms.Label();
            this.TotalFat = new System.Windows.Forms.Label();
            this.fdCarbs = new System.Windows.Forms.Label();
            this.RemainCarb = new System.Windows.Forms.Label();
            this.TotalCarb = new System.Windows.Forms.Label();
            this.fdCal = new System.Windows.Forms.Label();
            this.RemainCal = new System.Windows.Forms.Label();
            this.TotalCal = new System.Windows.Forms.Label();
            this.totalTxtPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.fdTotalPanel.SuspendLayout();
            this.totalTxtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FDLabel
            // 
            this.FDLabel.AutoSize = true;
            this.FDLabel.Font = new System.Drawing.Font("Poppins SemiBold", 24.75F, System.Drawing.FontStyle.Bold);
            this.FDLabel.ForeColor = System.Drawing.Color.Black;
            this.FDLabel.Location = new System.Drawing.Point(27, -2);
            this.FDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FDLabel.Name = "FDLabel";
            this.FDLabel.Size = new System.Drawing.Size(258, 74);
            this.FDLabel.TabIndex = 7;
            this.FDLabel.Text = "Food Diary";
            // 
            // dbDateTime
            // 
            this.dbDateTime.Animated = true;
            this.dbDateTime.BackColor = System.Drawing.Color.White;
            this.dbDateTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.dbDateTime.BorderRadius = 5;
            this.dbDateTime.BorderThickness = 1;
            this.dbDateTime.CheckedState.Parent = this.dbDateTime;
            this.dbDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbDateTime.CustomFormat = "yyyy-MM-dd";
            this.dbDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(181)))));
            this.dbDateTime.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbDateTime.ForeColor = System.Drawing.Color.Black;
            this.dbDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dbDateTime.HoverState.Parent = this.dbDateTime;
            this.dbDateTime.Location = new System.Drawing.Point(1264, 11);
            this.dbDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dbDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dbDateTime.Name = "dbDateTime";
            this.dbDateTime.ShadowDecoration.Parent = this.dbDateTime;
            this.dbDateTime.Size = new System.Drawing.Size(177, 44);
            this.dbDateTime.TabIndex = 9;
            this.dbDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbDateTime.Value = new System.DateTime(2024, 5, 17, 0, 0, 0, 0);
            this.dbDateTime.ValueChanged += new System.EventHandler(this.dbDateTime_ValueChanged);
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.BorderColor = System.Drawing.Color.White;
            this.addFoodBtn.BorderRadius = 5;
            this.addFoodBtn.BorderThickness = 1;
            this.addFoodBtn.CheckedState.Parent = this.addFoodBtn;
            this.addFoodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoodBtn.CustomBorderColor = System.Drawing.Color.White;
            this.addFoodBtn.CustomImages.Parent = this.addFoodBtn;
            this.addFoodBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.addFoodBtn.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodBtn.ForeColor = System.Drawing.Color.Black;
            this.addFoodBtn.HoverState.Parent = this.addFoodBtn;
            this.addFoodBtn.Location = new System.Drawing.Point(29, 676);
            this.addFoodBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.ShadowDecoration.Parent = this.addFoodBtn;
            this.addFoodBtn.Size = new System.Drawing.Size(177, 44);
            this.addFoodBtn.TabIndex = 44;
            this.addFoodBtn.Text = "Add Food";
            this.addFoodBtn.Click += new System.EventHandler(this.addFoodBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.mainPanel.Controls.Add(this.guna2Panel8);
            this.mainPanel.Controls.Add(this.guna2Panel7);
            this.mainPanel.Controls.Add(this.guna2Panel6);
            this.mainPanel.Controls.Add(this.guna2Panel5);
            this.mainPanel.Controls.Add(this.guna2Panel4);
            this.mainPanel.Controls.Add(this.guna2Panel3);
            this.mainPanel.Controls.Add(this.guna2Panel2);
            this.mainPanel.Controls.Add(this.guna2Panel1);
            this.mainPanel.Controls.Add(this.fdUsername);
            this.mainPanel.Controls.Add(this.FDLabel);
            this.mainPanel.Controls.Add(this.addFoodBtn);
            this.mainPanel.Controls.Add(this.foodDiaryPanel);
            this.mainPanel.Controls.Add(this.dbDateTime);
            this.mainPanel.Controls.Add(this.fdTotalPanel);
            this.mainPanel.Controls.Add(this.totalTxtPanel);
            this.mainPanel.Location = new System.Drawing.Point(3, 1);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1479, 822);
            this.mainPanel.TabIndex = 43;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.BorderThickness = 1;
            this.guna2Panel8.Controls.Add(this.label4);
            this.guna2Panel8.Controls.Add(this.proteinLbl);
            this.guna2Panel8.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel8.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel8.Location = new System.Drawing.Point(1095, 62);
            this.guna2Panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.ShadowDecoration.Parent = this.guna2Panel8;
            this.guna2Panel8.Size = new System.Drawing.Size(107, 71);
            this.guna2Panel8.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(1, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 70;
            this.label4.Text = "gram";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // proteinLbl
            // 
            this.proteinLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinLbl.ForeColor = System.Drawing.Color.Black;
            this.proteinLbl.Location = new System.Drawing.Point(3, 14);
            this.proteinLbl.Name = "proteinLbl";
            this.proteinLbl.Size = new System.Drawing.Size(99, 27);
            this.proteinLbl.TabIndex = 69;
            this.proteinLbl.Text = "Protein";
            this.proteinLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.label3);
            this.guna2Panel7.Controls.Add(this.fatLbl);
            this.guna2Panel7.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel7.Location = new System.Drawing.Point(989, 62);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(105, 71);
            this.guna2Panel7.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(4, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 70;
            this.label3.Text = "gram";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fatLbl
            // 
            this.fatLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLbl.ForeColor = System.Drawing.Color.Black;
            this.fatLbl.Location = new System.Drawing.Point(3, 14);
            this.fatLbl.Name = "fatLbl";
            this.fatLbl.Size = new System.Drawing.Size(99, 27);
            this.fatLbl.TabIndex = 69;
            this.fatLbl.Text = "Fat";
            this.fatLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderThickness = 1;
            this.guna2Panel6.Controls.Add(this.label2);
            this.guna2Panel6.Controls.Add(this.carbLbl);
            this.guna2Panel6.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel6.Location = new System.Drawing.Point(884, 62);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(105, 71);
            this.guna2Panel6.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 70;
            this.label2.Text = "gram";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // carbLbl
            // 
            this.carbLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbLbl.ForeColor = System.Drawing.Color.Black;
            this.carbLbl.Location = new System.Drawing.Point(3, 14);
            this.carbLbl.Name = "carbLbl";
            this.carbLbl.Size = new System.Drawing.Size(99, 27);
            this.carbLbl.TabIndex = 69;
            this.carbLbl.Text = "Carbs";
            this.carbLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.label1);
            this.guna2Panel5.Controls.Add(this.calLbl);
            this.guna2Panel5.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel5.Location = new System.Drawing.Point(779, 62);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(105, 71);
            this.guna2Panel5.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 70;
            this.label1.Text = "kcal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calLbl
            // 
            this.calLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calLbl.ForeColor = System.Drawing.Color.Black;
            this.calLbl.Location = new System.Drawing.Point(3, 14);
            this.calLbl.Name = "calLbl";
            this.calLbl.Size = new System.Drawing.Size(99, 27);
            this.calLbl.TabIndex = 69;
            this.calLbl.Text = "Calories";
            this.calLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.unitLbl);
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel4.Location = new System.Drawing.Point(673, 62);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(105, 71);
            this.guna2Panel4.TabIndex = 108;
            // 
            // unitLbl
            // 
            this.unitLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLbl.ForeColor = System.Drawing.Color.Black;
            this.unitLbl.Location = new System.Drawing.Point(3, 14);
            this.unitLbl.Name = "unitLbl";
            this.unitLbl.Size = new System.Drawing.Size(99, 27);
            this.unitLbl.TabIndex = 69;
            this.unitLbl.Text = "Unit";
            this.unitLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.sizeLbl);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel3.Location = new System.Drawing.Point(568, 62);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(107, 71);
            this.guna2Panel3.TabIndex = 107;
            // 
            // sizeLbl
            // 
            this.sizeLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLbl.ForeColor = System.Drawing.Color.Black;
            this.sizeLbl.Location = new System.Drawing.Point(3, 14);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(99, 27);
            this.sizeLbl.TabIndex = 69;
            this.sizeLbl.Text = "Servings";
            this.sizeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.fdLbl);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel2.Location = new System.Drawing.Point(223, 62);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(347, 71);
            this.guna2Panel2.TabIndex = 106;
            // 
            // fdLbl
            // 
            this.fdLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdLbl.ForeColor = System.Drawing.Color.Black;
            this.fdLbl.Location = new System.Drawing.Point(3, 14);
            this.fdLbl.Name = "fdLbl";
            this.fdLbl.Size = new System.Drawing.Size(339, 27);
            this.fdLbl.TabIndex = 69;
            this.fdLbl.Text = "Food Description";
            this.fdLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.mealLbl);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 62);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(189, 71);
            this.guna2Panel1.TabIndex = 105;
            // 
            // mealLbl
            // 
            this.mealLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealLbl.ForeColor = System.Drawing.Color.Black;
            this.mealLbl.Location = new System.Drawing.Point(3, 14);
            this.mealLbl.Name = "mealLbl";
            this.mealLbl.Size = new System.Drawing.Size(181, 27);
            this.mealLbl.TabIndex = 69;
            this.mealLbl.Text = "Meal";
            this.mealLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fdUsername
            // 
            this.fdUsername.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdUsername.ForeColor = System.Drawing.Color.Black;
            this.fdUsername.Location = new System.Drawing.Point(1116, 11);
            this.fdUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fdUsername.Name = "fdUsername";
            this.fdUsername.Size = new System.Drawing.Size(121, 31);
            this.fdUsername.TabIndex = 104;
            this.fdUsername.Text = "username";
            this.fdUsername.Visible = false;
            this.fdUsername.TextChanged += new System.EventHandler(this.fdUsername_TextChanged);
            this.fdUsername.Click += new System.EventHandler(this.fdUsername_Click);
            // 
            // foodDiaryPanel
            // 
            this.foodDiaryPanel.AutoScroll = true;
            this.foodDiaryPanel.BackColor = System.Drawing.Color.White;
            this.foodDiaryPanel.Location = new System.Drawing.Point(29, 134);
            this.foodDiaryPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foodDiaryPanel.Name = "foodDiaryPanel";
            this.foodDiaryPanel.Size = new System.Drawing.Size(1445, 518);
            this.foodDiaryPanel.TabIndex = 58;
            // 
            // fdTotalPanel
            // 
            this.fdTotalPanel.BackColor = System.Drawing.Color.Transparent;
            this.fdTotalPanel.Controls.Add(this.fdProtein);
            this.fdTotalPanel.Controls.Add(this.RemainProtein);
            this.fdTotalPanel.Controls.Add(this.TotalProtein);
            this.fdTotalPanel.Controls.Add(this.fdFat);
            this.fdTotalPanel.Controls.Add(this.RemainFat);
            this.fdTotalPanel.Controls.Add(this.TotalFat);
            this.fdTotalPanel.Controls.Add(this.fdCarbs);
            this.fdTotalPanel.Controls.Add(this.RemainCarb);
            this.fdTotalPanel.Controls.Add(this.TotalCarb);
            this.fdTotalPanel.Controls.Add(this.fdCal);
            this.fdTotalPanel.Controls.Add(this.RemainCal);
            this.fdTotalPanel.Controls.Add(this.TotalCal);
            this.fdTotalPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.fdTotalPanel.Location = new System.Drawing.Point(739, 665);
            this.fdTotalPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fdTotalPanel.Name = "fdTotalPanel";
            this.fdTotalPanel.Radius = 13;
            this.fdTotalPanel.ShadowColor = System.Drawing.Color.Transparent;
            this.fdTotalPanel.ShadowDepth = 0;
            this.fdTotalPanel.ShadowShift = 0;
            this.fdTotalPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.fdTotalPanel.Size = new System.Drawing.Size(703, 154);
            this.fdTotalPanel.TabIndex = 40;
            // 
            // fdProtein
            // 
            this.fdProtein.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdProtein.ForeColor = System.Drawing.Color.Black;
            this.fdProtein.Location = new System.Drawing.Point(348, 57);
            this.fdProtein.Name = "fdProtein";
            this.fdProtein.Size = new System.Drawing.Size(99, 27);
            this.fdProtein.TabIndex = 46;
            this.fdProtein.Text = "0";
            this.fdProtein.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RemainProtein
            // 
            this.RemainProtein.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainProtein.Location = new System.Drawing.Point(348, 105);
            this.RemainProtein.Name = "RemainProtein";
            this.RemainProtein.Size = new System.Drawing.Size(99, 27);
            this.RemainProtein.TabIndex = 45;
            this.RemainProtein.Text = "0";
            this.RemainProtein.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalProtein
            // 
            this.TotalProtein.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProtein.ForeColor = System.Drawing.Color.Black;
            this.TotalProtein.Location = new System.Drawing.Point(348, 11);
            this.TotalProtein.Name = "TotalProtein";
            this.TotalProtein.Size = new System.Drawing.Size(99, 27);
            this.TotalProtein.TabIndex = 44;
            this.TotalProtein.Text = "0";
            this.TotalProtein.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fdFat
            // 
            this.fdFat.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdFat.ForeColor = System.Drawing.Color.Black;
            this.fdFat.Location = new System.Drawing.Point(245, 57);
            this.fdFat.Name = "fdFat";
            this.fdFat.Size = new System.Drawing.Size(99, 27);
            this.fdFat.TabIndex = 43;
            this.fdFat.Text = "0";
            this.fdFat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RemainFat
            // 
            this.RemainFat.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainFat.Location = new System.Drawing.Point(245, 105);
            this.RemainFat.Name = "RemainFat";
            this.RemainFat.Size = new System.Drawing.Size(99, 27);
            this.RemainFat.TabIndex = 42;
            this.RemainFat.Text = "0";
            this.RemainFat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalFat
            // 
            this.TotalFat.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFat.ForeColor = System.Drawing.Color.Black;
            this.TotalFat.Location = new System.Drawing.Point(245, 11);
            this.TotalFat.Name = "TotalFat";
            this.TotalFat.Size = new System.Drawing.Size(99, 27);
            this.TotalFat.TabIndex = 41;
            this.TotalFat.Text = "0";
            this.TotalFat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fdCarbs
            // 
            this.fdCarbs.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdCarbs.ForeColor = System.Drawing.Color.Black;
            this.fdCarbs.Location = new System.Drawing.Point(151, 57);
            this.fdCarbs.Name = "fdCarbs";
            this.fdCarbs.Size = new System.Drawing.Size(99, 27);
            this.fdCarbs.TabIndex = 40;
            this.fdCarbs.Text = "0";
            this.fdCarbs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RemainCarb
            // 
            this.RemainCarb.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainCarb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainCarb.Location = new System.Drawing.Point(151, 105);
            this.RemainCarb.Name = "RemainCarb";
            this.RemainCarb.Size = new System.Drawing.Size(99, 27);
            this.RemainCarb.TabIndex = 39;
            this.RemainCarb.Text = "0";
            this.RemainCarb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalCarb
            // 
            this.TotalCarb.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCarb.ForeColor = System.Drawing.Color.Black;
            this.TotalCarb.Location = new System.Drawing.Point(151, 11);
            this.TotalCarb.Name = "TotalCarb";
            this.TotalCarb.Size = new System.Drawing.Size(99, 27);
            this.TotalCarb.TabIndex = 38;
            this.TotalCarb.Text = "0";
            this.TotalCarb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fdCal
            // 
            this.fdCal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdCal.ForeColor = System.Drawing.Color.Black;
            this.fdCal.Location = new System.Drawing.Point(47, 62);
            this.fdCal.Name = "fdCal";
            this.fdCal.Size = new System.Drawing.Size(99, 27);
            this.fdCal.TabIndex = 37;
            this.fdCal.Text = "0";
            this.fdCal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RemainCal
            // 
            this.RemainCal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainCal.Location = new System.Drawing.Point(47, 110);
            this.RemainCal.Name = "RemainCal";
            this.RemainCal.Size = new System.Drawing.Size(99, 27);
            this.RemainCal.TabIndex = 36;
            this.RemainCal.Text = "0";
            this.RemainCal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalCal
            // 
            this.TotalCal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCal.ForeColor = System.Drawing.Color.Black;
            this.TotalCal.Location = new System.Drawing.Point(47, 16);
            this.TotalCal.Name = "TotalCal";
            this.TotalCal.Size = new System.Drawing.Size(99, 27);
            this.TotalCal.TabIndex = 35;
            this.TotalCal.Text = "0";
            this.TotalCal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalTxtPanel
            // 
            this.totalTxtPanel.Controls.Add(this.label6);
            this.totalTxtPanel.Controls.Add(this.label7);
            this.totalTxtPanel.Controls.Add(this.label8);
            this.totalTxtPanel.Location = new System.Drawing.Point(556, 663);
            this.totalTxtPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalTxtPanel.Name = "totalTxtPanel";
            this.totalTxtPanel.Size = new System.Drawing.Size(176, 156);
            this.totalTxtPanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label6.Location = new System.Drawing.Point(104, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label7.Location = new System.Drawing.Point(36, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 26);
            this.label7.TabIndex = 42;
            this.label7.Text = "Your Daily Goal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label8.Location = new System.Drawing.Point(57, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Remaining";
            // 
            // FoodDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1480, 823);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FoodDiary";
            this.Text = "FoodDiary";
            this.Load += new System.EventHandler(this.FoodDiary_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.fdTotalPanel.ResumeLayout(false);
            this.totalTxtPanel.ResumeLayout(false);
            this.totalTxtPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FDLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dbDateTime;
        private Guna.UI2.WinForms.Guna2Button addFoodBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel totalTxtPanel;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ShadowPanel fdTotalPanel;
        private System.Windows.Forms.FlowLayoutPanel foodDiaryPanel;
        public System.Windows.Forms.Label fdUsername;
        public System.Windows.Forms.Label TotalCal;
        public System.Windows.Forms.Label RemainCal;
        public System.Windows.Forms.Label fdCal;
        public System.Windows.Forms.Label fdProtein;
        public System.Windows.Forms.Label RemainProtein;
        public System.Windows.Forms.Label TotalProtein;
        public System.Windows.Forms.Label fdFat;
        public System.Windows.Forms.Label RemainFat;
        public System.Windows.Forms.Label TotalFat;
        public System.Windows.Forms.Label fdCarbs;
        public System.Windows.Forms.Label RemainCarb;
        public System.Windows.Forms.Label TotalCarb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label proteinLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label fatLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label carbLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label calLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label unitLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label sizeLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label fdLbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label mealLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}