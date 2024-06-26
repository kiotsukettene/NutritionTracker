﻿namespace NutritionTracker
{
    partial class FormAddFood
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.addFoodSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchFoodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.addToDiaryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chartCal = new System.Windows.Forms.Label();
            this.mealBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.foodNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proteinPercentLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carbPercentLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fatPercentLbl = new System.Windows.Forms.Label();
            this.servingsBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.calLabel = new System.Windows.Forms.Label();
            this.unitBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalProteinLabel = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Poppins SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.Black;
            this.DashboardLabel.Location = new System.Drawing.Point(16, 11);
            this.DashboardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(529, 74);
            this.DashboardLabel.TabIndex = 8;
            this.DashboardLabel.Text = "Add Food To Food Diary\r\n";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(83)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(544, 123);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(139, 46);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.searchBtn);
            // 
            // addFoodSearchBox
            // 
            this.addFoodSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.BorderColor = System.Drawing.Color.Gray;
            this.addFoodSearchBox.BorderRadius = 5;
            this.addFoodSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addFoodSearchBox.DefaultText = "";
            this.addFoodSearchBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.DisabledState.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addFoodSearchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.addFoodSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addFoodSearchBox.FocusedState.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodSearchBox.ForeColor = System.Drawing.Color.Black;
            this.addFoodSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addFoodSearchBox.HoverState.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.Location = new System.Drawing.Point(27, 121);
            this.addFoodSearchBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.addFoodSearchBox.Name = "addFoodSearchBox";
            this.addFoodSearchBox.PasswordChar = '\0';
            this.addFoodSearchBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.addFoodSearchBox.PlaceholderText = "";
            this.addFoodSearchBox.SelectedText = "";
            this.addFoodSearchBox.ShadowDecoration.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.Size = new System.Drawing.Size(499, 47);
            this.addFoodSearchBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search our food database by name ";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.mainPanel.Controls.Add(this.idLabel);
            this.mainPanel.Controls.Add(this.usernameLbl);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.searchFoodPanel);
            this.mainPanel.Controls.Add(this.DashboardLabel);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.addFoodSearchBox);
            this.mainPanel.Controls.Add(this.guna2Button1);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1480, 823);
            this.mainPanel.TabIndex = 24;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(1163, 25);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(101, 30);
            this.idLabel.TabIndex = 198;
            this.idLabel.Text = "Username";
            this.idLabel.Visible = false;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.Black;
            this.usernameLbl.Location = new System.Drawing.Point(1273, 27);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(101, 30);
            this.usernameLbl.TabIndex = 195;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 48);
            this.label4.TabIndex = 164;
            this.label4.Text = "Matching Foods:";
            // 
            // searchFoodPanel
            // 
            this.searchFoodPanel.AutoScroll = true;
            this.searchFoodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.searchFoodPanel.Location = new System.Drawing.Point(33, 231);
            this.searchFoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchFoodPanel.Name = "searchFoodPanel";
            this.searchFoodPanel.Size = new System.Drawing.Size(649, 558);
            this.searchFoodPanel.TabIndex = 90;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::NutritionTracker.Properties.Resources.previous;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackBtn.BorderColor = System.Drawing.Color.White;
            this.BackBtn.BorderRadius = 5;
            this.BackBtn.CheckedState.Parent = this.BackBtn;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.CustomBorderColor = System.Drawing.Color.White;
            this.BackBtn.CustomImages.Parent = this.BackBtn;
            this.BackBtn.FillColor = System.Drawing.Color.Transparent;
            this.BackBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.HoverState.Parent = this.BackBtn;
            this.BackBtn.Location = new System.Drawing.Point(1389, 11);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(59, 42);
            this.BackBtn.TabIndex = 89;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.dbDateTime);
            this.panel1.Controls.Add(this.addToDiaryBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chartCal);
            this.panel1.Controls.Add(this.mealBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.foodNameLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.proteinPercentLbl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.carbPercentLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fatPercentLbl);
            this.panel1.Controls.Add(this.servingsBox);
            this.panel1.Controls.Add(this.guna2CircleButton3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.guna2CircleButton2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Controls.Add(this.calLabel);
            this.panel1.Controls.Add(this.unitBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.totalProteinLabel);
            this.panel1.Controls.Add(this.carbLabel);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.fatLabel);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Location = new System.Drawing.Point(704, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 764);
            this.panel1.TabIndex = 195;
            // 
            // dbDateTime
            // 
            this.dbDateTime.Animated = true;
            this.dbDateTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.dbDateTime.BorderRadius = 5;
            this.dbDateTime.BorderThickness = 1;
            this.dbDateTime.CheckedState.Parent = this.dbDateTime;
            this.dbDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dbDateTime.CustomFormat = "yyyy-MM-dd";
            this.dbDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(181)))));
            this.dbDateTime.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbDateTime.ForeColor = System.Drawing.Color.Black;
            this.dbDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dbDateTime.HoverState.Parent = this.dbDateTime;
            this.dbDateTime.Location = new System.Drawing.Point(563, 398);
            this.dbDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dbDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dbDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dbDateTime.Name = "dbDateTime";
            this.dbDateTime.ShadowDecoration.Parent = this.dbDateTime;
            this.dbDateTime.Size = new System.Drawing.Size(177, 34);
            this.dbDateTime.TabIndex = 196;
            this.dbDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbDateTime.Value = new System.DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // addToDiaryBtn
            // 
            this.addToDiaryBtn.BorderColor = System.Drawing.Color.White;
            this.addToDiaryBtn.BorderRadius = 5;
            this.addToDiaryBtn.CheckedState.Parent = this.addToDiaryBtn;
            this.addToDiaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToDiaryBtn.CustomBorderColor = System.Drawing.Color.White;
            this.addToDiaryBtn.CustomImages.Parent = this.addToDiaryBtn;
            this.addToDiaryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.addToDiaryBtn.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToDiaryBtn.ForeColor = System.Drawing.Color.Black;
            this.addToDiaryBtn.HoverState.Parent = this.addToDiaryBtn;
            this.addToDiaryBtn.Location = new System.Drawing.Point(575, 670);
            this.addToDiaryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToDiaryBtn.Name = "addToDiaryBtn";
            this.addToDiaryBtn.ShadowDecoration.Parent = this.addToDiaryBtn;
            this.addToDiaryBtn.Size = new System.Drawing.Size(169, 46);
            this.addToDiaryBtn.TabIndex = 195;
            this.addToDiaryBtn.Text = "Add to Diary";
            this.addToDiaryBtn.Click += new System.EventHandler(this.AddToFoodDiaryBtn);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(429, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 30);
            this.label7.TabIndex = 194;
            this.label7.Text = "for";
            // 
            // chartCal
            // 
            this.chartCal.AutoSize = true;
            this.chartCal.BackColor = System.Drawing.Color.Transparent;
            this.chartCal.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCal.ForeColor = System.Drawing.Color.Black;
            this.chartCal.Location = new System.Drawing.Point(343, 185);
            this.chartCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chartCal.Name = "chartCal";
            this.chartCal.Size = new System.Drawing.Size(69, 60);
            this.chartCal.TabIndex = 191;
            this.chartCal.Text = "113";
            // 
            // mealBox
            // 
            this.mealBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.mealBox.BorderColor = System.Drawing.Color.Gray;
            this.mealBox.BorderRadius = 5;
            this.mealBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mealBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.mealBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mealBox.FocusedColor = System.Drawing.Color.Empty;
            this.mealBox.FocusedState.Parent = this.mealBox;
            this.mealBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealBox.ForeColor = System.Drawing.Color.Black;
            this.mealBox.FormattingEnabled = true;
            this.mealBox.HoverState.Parent = this.mealBox;
            this.mealBox.ItemHeight = 28;
            this.mealBox.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snacks"});
            this.mealBox.ItemsAppearance.Parent = this.mealBox;
            this.mealBox.Location = new System.Drawing.Point(501, 468);
            this.mealBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealBox.Name = "mealBox";
            this.mealBox.ShadowDecoration.Parent = this.mealBox;
            this.mealBox.Size = new System.Drawing.Size(179, 34);
            this.mealBox.StartIndex = 0;
            this.mealBox.TabIndex = 176;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(305, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 53);
            this.label3.TabIndex = 192;
            this.label3.Text = "Calories";
            // 
            // foodNameLbl
            // 
            this.foodNameLbl.AutoSize = true;
            this.foodNameLbl.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLbl.ForeColor = System.Drawing.Color.Black;
            this.foodNameLbl.Location = new System.Drawing.Point(24, 34);
            this.foodNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodNameLbl.Name = "foodNameLbl";
            this.foodNameLbl.Size = new System.Drawing.Size(196, 53);
            this.foodNameLbl.TabIndex = 170;
            this.foodNameLbl.Text = "Food Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 48);
            this.label2.TabIndex = 171;
            this.label2.Text = "Nutrition Facts";
            // 
            // proteinPercentLbl
            // 
            this.proteinPercentLbl.AutoSize = true;
            this.proteinPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.proteinPercentLbl.Location = new System.Drawing.Point(569, 334);
            this.proteinPercentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proteinPercentLbl.Name = "proteinPercentLbl";
            this.proteinPercentLbl.Size = new System.Drawing.Size(82, 30);
            this.proteinPercentLbl.TabIndex = 190;
            this.proteinPercentLbl.Text = "Calories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(33, 446);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 2);
            this.panel2.TabIndex = 172;
            // 
            // carbPercentLbl
            // 
            this.carbPercentLbl.AutoSize = true;
            this.carbPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.carbPercentLbl.Location = new System.Drawing.Point(569, 305);
            this.carbPercentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbPercentLbl.Name = "carbPercentLbl";
            this.carbPercentLbl.Size = new System.Drawing.Size(82, 30);
            this.carbPercentLbl.TabIndex = 189;
            this.carbPercentLbl.Text = "Calories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 475);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 173;
            this.label5.Text = "Servings:";
            // 
            // fatPercentLbl
            // 
            this.fatPercentLbl.AutoSize = true;
            this.fatPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.fatPercentLbl.Location = new System.Drawing.Point(569, 277);
            this.fatPercentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatPercentLbl.Name = "fatPercentLbl";
            this.fatPercentLbl.Size = new System.Drawing.Size(82, 30);
            this.fatPercentLbl.TabIndex = 188;
            this.fatPercentLbl.Text = "Calories";
            // 
            // servingsBox
            // 
            this.servingsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.servingsBox.BorderColor = System.Drawing.Color.Gray;
            this.servingsBox.BorderRadius = 5;
            this.servingsBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.servingsBox.DefaultText = "";
            this.servingsBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.servingsBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.servingsBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.servingsBox.DisabledState.Parent = this.servingsBox;
            this.servingsBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.servingsBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.servingsBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingsBox.FocusedState.Parent = this.servingsBox;
            this.servingsBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsBox.ForeColor = System.Drawing.Color.Black;
            this.servingsBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingsBox.HoverState.Parent = this.servingsBox;
            this.servingsBox.Location = new System.Drawing.Point(140, 468);
            this.servingsBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.servingsBox.Name = "servingsBox";
            this.servingsBox.PasswordChar = '\0';
            this.servingsBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.servingsBox.PlaceholderText = "";
            this.servingsBox.SelectedText = "";
            this.servingsBox.ShadowDecoration.Parent = this.servingsBox;
            this.servingsBox.Size = new System.Drawing.Size(109, 43);
            this.servingsBox.TabIndex = 174;
            this.servingsBox.TextChanged += new System.EventHandler(this.servingsBox_TextChanged);
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(548, 342);
            this.guna2CircleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton3.TabIndex = 187;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(33, 522);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 2);
            this.panel3.TabIndex = 175;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(548, 313);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton2.TabIndex = 186;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 30);
            this.label6.TabIndex = 176;
            this.label6.Text = "Calories";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(548, 283);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton1.TabIndex = 185;
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calLabel.ForeColor = System.Drawing.Color.Black;
            this.calLabel.Location = new System.Drawing.Point(219, 545);
            this.calLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(33, 30);
            this.calLabel.TabIndex = 177;
            this.calLabel.Text = "113";
            // 
            // unitBox
            // 
            this.unitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.unitBox.BorderColor = System.Drawing.Color.Gray;
            this.unitBox.BorderRadius = 5;
            this.unitBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitBox.DefaultText = "";
            this.unitBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.unitBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.unitBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.unitBox.DisabledState.Parent = this.unitBox;
            this.unitBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.unitBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitBox.FocusedState.Parent = this.unitBox;
            this.unitBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBox.ForeColor = System.Drawing.Color.Black;
            this.unitBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitBox.HoverState.Parent = this.unitBox;
            this.unitBox.Location = new System.Drawing.Point(260, 468);
            this.unitBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.unitBox.Name = "unitBox";
            this.unitBox.PasswordChar = '\0';
            this.unitBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.unitBox.PlaceholderText = "";
            this.unitBox.SelectedText = "";
            this.unitBox.ShadowDecoration.Parent = this.unitBox;
            this.unitBox.Size = new System.Drawing.Size(133, 43);
            this.unitBox.TabIndex = 175;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 594);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 178;
            this.label8.Text = "Total Carbs";
            // 
            // totalProteinLabel
            // 
            this.totalProteinLabel.AutoSize = true;
            this.totalProteinLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProteinLabel.ForeColor = System.Drawing.Color.Black;
            this.totalProteinLabel.Location = new System.Drawing.Point(219, 687);
            this.totalProteinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalProteinLabel.Name = "totalProteinLabel";
            this.totalProteinLabel.Size = new System.Drawing.Size(31, 30);
            this.totalProteinLabel.TabIndex = 183;
            this.totalProteinLabel.Text = "--";
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbLabel.ForeColor = System.Drawing.Color.Black;
            this.carbLabel.Location = new System.Drawing.Point(219, 594);
            this.carbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(40, 30);
            this.carbLabel.TabIndex = 179;
            this.carbLabel.Text = "5 g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(40, 687);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 30);
            this.label12.TabIndex = 182;
            this.label12.Text = "Total Protein";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(40, 638);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 30);
            this.label10.TabIndex = 180;
            this.label10.Text = "Total Fat";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.ForeColor = System.Drawing.Color.Black;
            this.fatLabel.Location = new System.Drawing.Point(219, 638);
            this.fatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(39, 30);
            this.fatLabel.TabIndex = 181;
            this.fatLabel.Text = "2 g";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Poppins", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(140, 95);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            series2.CustomProperties = "DoughnutRadius=30, PieLabelStyle=Disabled";
            series2.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(476, 283);
            this.chart1.TabIndex = 169;
            this.chart1.Text = "chart1";
            // 
            // updateBtn
            // 
            this.updateBtn.BorderColor = System.Drawing.Color.White;
            this.updateBtn.BorderRadius = 5;
            this.updateBtn.CheckedState.Parent = this.updateBtn;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.CustomBorderColor = System.Drawing.Color.White;
            this.updateBtn.CustomImages.Parent = this.updateBtn;
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.updateBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.updateBtn.HoverState.Parent = this.updateBtn;
            this.updateBtn.Location = new System.Drawing.Point(575, 670);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(169, 46);
            this.updateBtn.TabIndex = 197;
            this.updateBtn.Text = "Uodate to Diary";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // FormAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1480, 823);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddFood";
            this.Text = "FormAddFood";
            this.Load += new System.EventHandler(this.FormAddFood_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DashboardLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox addFoodSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private System.Windows.Forms.FlowLayoutPanel searchFoodPanel;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label proteinPercentLbl;
        public System.Windows.Forms.Label carbPercentLbl;
        public System.Windows.Forms.Label fatPercentLbl;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        public Guna.UI2.WinForms.Guna2TextBox unitBox;
        public System.Windows.Forms.Label totalProteinLabel;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label fatLabel;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label carbLabel;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label calLabel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panel3;
        public Guna.UI2.WinForms.Guna2TextBox servingsBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label foodNameLbl;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label chartCal;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label usernameLbl;
        public Guna.UI2.WinForms.Guna2ComboBox mealBox;
        public Guna.UI2.WinForms.Guna2DateTimePicker dbDateTime;
        public Guna.UI2.WinForms.Guna2Button addToDiaryBtn;
        public Guna.UI2.WinForms.Guna2Button updateBtn;
        public System.Windows.Forms.Label idLabel;
    }
}