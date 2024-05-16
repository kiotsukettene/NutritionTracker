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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.addFoodSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.searchFoodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.proteinPercentLbl = new System.Windows.Forms.Label();
            this.carbPercentLbl = new System.Windows.Forms.Label();
            this.fatPercentLbl = new System.Windows.Forms.Label();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.unitBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalProteinLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.servingsBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.foodNameLbl = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.chartCal = new System.Windows.Forms.Label();
            this.servingUnitBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Poppins SemiBold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.White;
            this.DashboardLabel.Location = new System.Drawing.Point(12, 9);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(415, 58);
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
            this.guna2Button1.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(83)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(408, 100);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(104, 37);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.searchBtn);
            // 
            // addFoodSearchBox
            // 
            this.addFoodSearchBox.BackColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.BorderColor = System.Drawing.Color.Gray;
            this.addFoodSearchBox.BorderRadius = 20;
            this.addFoodSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addFoodSearchBox.DefaultText = "";
            this.addFoodSearchBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.addFoodSearchBox.DisabledState.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addFoodSearchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addFoodSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addFoodSearchBox.FocusedState.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodSearchBox.ForeColor = System.Drawing.Color.White;
            this.addFoodSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addFoodSearchBox.HoverState.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.Location = new System.Drawing.Point(20, 98);
            this.addFoodSearchBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addFoodSearchBox.Name = "addFoodSearchBox";
            this.addFoodSearchBox.PasswordChar = '\0';
            this.addFoodSearchBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.addFoodSearchBox.PlaceholderText = "";
            this.addFoodSearchBox.SelectedText = "";
            this.addFoodSearchBox.ShadowDecoration.Parent = this.addFoodSearchBox;
            this.addFoodSearchBox.Size = new System.Drawing.Size(374, 38);
            this.addFoodSearchBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search our food database by name ";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.searchFoodPanel);
            this.mainPanel.Controls.Add(this.BackBtn);
            this.mainPanel.Controls.Add(this.DashboardLabel);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.addFoodSearchBox);
            this.mainPanel.Controls.Add(this.guna2Button1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1110, 669);
            this.mainPanel.TabIndex = 24;
            // 
            // searchFoodPanel
            // 
            this.searchFoodPanel.AutoScroll = true;
            this.searchFoodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.searchFoodPanel.Location = new System.Drawing.Point(25, 188);
            this.searchFoodPanel.Name = "searchFoodPanel";
            this.searchFoodPanel.Size = new System.Drawing.Size(487, 453);
            this.searchFoodPanel.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 37);
            this.label4.TabIndex = 164;
            this.label4.Text = "Matching Foods:";
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
            this.BackBtn.Location = new System.Drawing.Point(1027, 12);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.ShadowDecoration.Parent = this.BackBtn;
            this.BackBtn.Size = new System.Drawing.Size(44, 34);
            this.BackBtn.TabIndex = 89;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // proteinPercentLbl
            // 
            this.proteinPercentLbl.AutoSize = true;
            this.proteinPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinPercentLbl.ForeColor = System.Drawing.Color.White;
            this.proteinPercentLbl.Location = new System.Drawing.Point(427, 250);
            this.proteinPercentLbl.Name = "proteinPercentLbl";
            this.proteinPercentLbl.Size = new System.Drawing.Size(63, 23);
            this.proteinPercentLbl.TabIndex = 190;
            this.proteinPercentLbl.Text = "Calories";
            this.proteinPercentLbl.Click += new System.EventHandler(this.proteinPercentLbl_Click);
            // 
            // carbPercentLbl
            // 
            this.carbPercentLbl.AutoSize = true;
            this.carbPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbPercentLbl.ForeColor = System.Drawing.Color.White;
            this.carbPercentLbl.Location = new System.Drawing.Point(427, 227);
            this.carbPercentLbl.Name = "carbPercentLbl";
            this.carbPercentLbl.Size = new System.Drawing.Size(63, 23);
            this.carbPercentLbl.TabIndex = 189;
            this.carbPercentLbl.Text = "Calories";
            this.carbPercentLbl.Click += new System.EventHandler(this.carbPercentLbl_Click);
            // 
            // fatPercentLbl
            // 
            this.fatPercentLbl.AutoSize = true;
            this.fatPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatPercentLbl.ForeColor = System.Drawing.Color.White;
            this.fatPercentLbl.Location = new System.Drawing.Point(427, 204);
            this.fatPercentLbl.Name = "fatPercentLbl";
            this.fatPercentLbl.Size = new System.Drawing.Size(63, 23);
            this.fatPercentLbl.TabIndex = 188;
            this.fatPercentLbl.Text = "Calories";
            this.fatPercentLbl.Click += new System.EventHandler(this.fatPercentLbl_Click);
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(411, 257);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(10, 10);
            this.guna2CircleButton3.TabIndex = 187;
            this.guna2CircleButton3.Click += new System.EventHandler(this.guna2CircleButton3_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(411, 233);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(10, 10);
            this.guna2CircleButton2.TabIndex = 186;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(411, 209);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(10, 10);
            this.guna2CircleButton1.TabIndex = 185;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // unitBox
            // 
            this.unitBox.BackColor = System.Drawing.Color.Transparent;
            this.unitBox.BorderColor = System.Drawing.Color.Gray;
            this.unitBox.BorderRadius = 5;
            this.unitBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitBox.DefaultText = "";
            this.unitBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.unitBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.unitBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.unitBox.DisabledState.Parent = this.unitBox;
            this.unitBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.unitBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitBox.FocusedState.Parent = this.unitBox;
            this.unitBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitBox.ForeColor = System.Drawing.Color.White;
            this.unitBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitBox.HoverState.Parent = this.unitBox;
            this.unitBox.Location = new System.Drawing.Point(195, 362);
            this.unitBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unitBox.Name = "unitBox";
            this.unitBox.PasswordChar = '\0';
            this.unitBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.unitBox.PlaceholderText = "";
            this.unitBox.SelectedText = "";
            this.unitBox.ShadowDecoration.Parent = this.unitBox;
            this.unitBox.Size = new System.Drawing.Size(100, 35);
            this.unitBox.TabIndex = 184;
            this.unitBox.TextChanged += new System.EventHandler(this.unitBox_TextChanged);
            // 
            // totalProteinLabel
            // 
            this.totalProteinLabel.AutoSize = true;
            this.totalProteinLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProteinLabel.ForeColor = System.Drawing.Color.White;
            this.totalProteinLabel.Location = new System.Drawing.Point(164, 540);
            this.totalProteinLabel.Name = "totalProteinLabel";
            this.totalProteinLabel.Size = new System.Drawing.Size(24, 23);
            this.totalProteinLabel.TabIndex = 183;
            this.totalProteinLabel.Text = "--";
            this.totalProteinLabel.Click += new System.EventHandler(this.totalProteinLabel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(30, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 182;
            this.label12.Text = "Total Protein";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.ForeColor = System.Drawing.Color.White;
            this.fatLabel.Location = new System.Drawing.Point(164, 500);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(29, 23);
            this.fatLabel.TabIndex = 181;
            this.fatLabel.Text = "2 g";
            this.fatLabel.Click += new System.EventHandler(this.fatLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 180;
            this.label10.Text = "Total Fat";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbLabel.ForeColor = System.Drawing.Color.White;
            this.carbLabel.Location = new System.Drawing.Point(164, 465);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(30, 23);
            this.carbLabel.TabIndex = 179;
            this.carbLabel.Text = "5 g";
            this.carbLabel.Click += new System.EventHandler(this.carbLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 178;
            this.label8.Text = "Total Carbs";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calLabel.ForeColor = System.Drawing.Color.White;
            this.calLabel.Location = new System.Drawing.Point(164, 425);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(26, 23);
            this.calLabel.TabIndex = 177;
            this.calLabel.Text = "113";
            this.calLabel.Click += new System.EventHandler(this.calLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 176;
            this.label6.Text = "Calories";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(25, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 2);
            this.panel3.TabIndex = 175;
            // 
            // servingsBox
            // 
            this.servingsBox.BackColor = System.Drawing.Color.Transparent;
            this.servingsBox.BorderColor = System.Drawing.Color.Gray;
            this.servingsBox.BorderRadius = 5;
            this.servingsBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.servingsBox.DefaultText = "";
            this.servingsBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.servingsBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.servingsBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.servingsBox.DisabledState.Parent = this.servingsBox;
            this.servingsBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.servingsBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.servingsBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingsBox.FocusedState.Parent = this.servingsBox;
            this.servingsBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingsBox.ForeColor = System.Drawing.Color.White;
            this.servingsBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingsBox.HoverState.Parent = this.servingsBox;
            this.servingsBox.Location = new System.Drawing.Point(105, 362);
            this.servingsBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.servingsBox.Name = "servingsBox";
            this.servingsBox.PasswordChar = '\0';
            this.servingsBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.servingsBox.PlaceholderText = "";
            this.servingsBox.SelectedText = "";
            this.servingsBox.ShadowDecoration.Parent = this.servingsBox;
            this.servingsBox.Size = new System.Drawing.Size(82, 35);
            this.servingsBox.TabIndex = 174;
            this.servingsBox.TextChanged += new System.EventHandler(this.servingsBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 173;
            this.label5.Text = "Servings:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(25, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 2);
            this.panel2.TabIndex = 172;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 37);
            this.label2.TabIndex = 171;
            this.label2.Text = "Nutrition Facts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // foodNameLbl
            // 
            this.foodNameLbl.AutoSize = true;
            this.foodNameLbl.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLbl.ForeColor = System.Drawing.Color.White;
            this.foodNameLbl.Location = new System.Drawing.Point(12, 11);
            this.foodNameLbl.Name = "foodNameLbl";
            this.foodNameLbl.Size = new System.Drawing.Size(157, 42);
            this.foodNameLbl.TabIndex = 170;
            this.foodNameLbl.Text = "Food Name";
            this.foodNameLbl.Click += new System.EventHandler(this.foodNameLbl_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Poppins", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            chartArea4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(105, 56);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))))};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            series4.CustomProperties = "DoughnutRadius=30, PieLabelStyle=Disabled";
            series4.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(357, 230);
            this.chart1.TabIndex = 169;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(225, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 42);
            this.label3.TabIndex = 192;
            this.label3.Text = "Calories";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chartCal
            // 
            this.chartCal.AutoSize = true;
            this.chartCal.BackColor = System.Drawing.Color.Transparent;
            this.chartCal.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCal.ForeColor = System.Drawing.Color.White;
            this.chartCal.Location = new System.Drawing.Point(257, 129);
            this.chartCal.Name = "chartCal";
            this.chartCal.Size = new System.Drawing.Size(56, 48);
            this.chartCal.TabIndex = 191;
            this.chartCal.Text = "113";
            this.chartCal.Click += new System.EventHandler(this.chartCal_Click);
            // 
            // servingUnitBox
            // 
            this.servingUnitBox.BackColor = System.Drawing.Color.Transparent;
            this.servingUnitBox.BorderColor = System.Drawing.Color.Gray;
            this.servingUnitBox.BorderRadius = 5;
            this.servingUnitBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.servingUnitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servingUnitBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.servingUnitBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servingUnitBox.FocusedColor = System.Drawing.Color.Empty;
            this.servingUnitBox.FocusedState.Parent = this.servingUnitBox;
            this.servingUnitBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingUnitBox.ForeColor = System.Drawing.Color.White;
            this.servingUnitBox.FormattingEnabled = true;
            this.servingUnitBox.HoverState.Parent = this.servingUnitBox;
            this.servingUnitBox.ItemHeight = 28;
            this.servingUnitBox.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Snacks"});
            this.servingUnitBox.ItemsAppearance.Parent = this.servingUnitBox;
            this.servingUnitBox.Location = new System.Drawing.Point(376, 362);
            this.servingUnitBox.Margin = new System.Windows.Forms.Padding(2);
            this.servingUnitBox.Name = "servingUnitBox";
            this.servingUnitBox.ShadowDecoration.Parent = this.servingUnitBox;
            this.servingUnitBox.Size = new System.Drawing.Size(135, 34);
            this.servingUnitBox.TabIndex = 193;
            this.servingUnitBox.SelectedIndexChanged += new System.EventHandler(this.servingUnitBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(322, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 23);
            this.label7.TabIndex = 194;
            this.label7.Text = "for";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chartCal);
            this.panel1.Controls.Add(this.servingUnitBox);
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
            this.panel1.Location = new System.Drawing.Point(528, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 605);
            this.panel1.TabIndex = 195;
            // 
            // FormAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1110, 669);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddFood";
            this.Text = "FormAddFood";
            this.Load += new System.EventHandler(this.FormAddFood_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2ComboBox servingUnitBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panel1;
    }
}