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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.totalTxtPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.fdTotalPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.totalTxtPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FDLabel
            // 
            this.FDLabel.AutoSize = true;
            this.FDLabel.Font = new System.Drawing.Font("Poppins SemiBold", 24.75F, System.Drawing.FontStyle.Bold);
            this.FDLabel.ForeColor = System.Drawing.Color.Black;
            this.FDLabel.Location = new System.Drawing.Point(20, -2);
            this.FDLabel.Name = "FDLabel";
            this.FDLabel.Size = new System.Drawing.Size(202, 58);
            this.FDLabel.TabIndex = 7;
            this.FDLabel.Text = "Food Diary";
            // 
            // dbDateTime
            // 
            this.dbDateTime.Animated = true;
            this.dbDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.dbDateTime.BorderColor = System.Drawing.Color.Transparent;
            this.dbDateTime.BorderRadius = 10;
            this.dbDateTime.BorderThickness = 1;
            this.dbDateTime.CheckedState.Parent = this.dbDateTime;
            this.dbDateTime.CustomFormat = "";
            this.dbDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(181)))));
            this.dbDateTime.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbDateTime.ForeColor = System.Drawing.Color.Black;
            this.dbDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dbDateTime.HoverState.Parent = this.dbDateTime;
            this.dbDateTime.Location = new System.Drawing.Point(948, 9);
            this.dbDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dbDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dbDateTime.Name = "dbDateTime";
            this.dbDateTime.ShadowDecoration.Parent = this.dbDateTime;
            this.dbDateTime.Size = new System.Drawing.Size(133, 36);
            this.dbDateTime.TabIndex = 9;
            this.dbDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbDateTime.Value = new System.DateTime(2024, 5, 8, 0, 0, 0, 0);
            // 
            // addFoodBtn
            // 
            this.addFoodBtn.BorderColor = System.Drawing.Color.White;
            this.addFoodBtn.CheckedState.Parent = this.addFoodBtn;
            this.addFoodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoodBtn.CustomBorderColor = System.Drawing.Color.White;
            this.addFoodBtn.CustomImages.Parent = this.addFoodBtn;
            this.addFoodBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.addFoodBtn.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodBtn.ForeColor = System.Drawing.Color.Black;
            this.addFoodBtn.HoverState.Parent = this.addFoodBtn;
            this.addFoodBtn.Location = new System.Drawing.Point(22, 549);
            this.addFoodBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addFoodBtn.Name = "addFoodBtn";
            this.addFoodBtn.ShadowDecoration.Parent = this.addFoodBtn;
            this.addFoodBtn.Size = new System.Drawing.Size(133, 36);
            this.addFoodBtn.TabIndex = 44;
            this.addFoodBtn.Text = "Add Food";
            this.addFoodBtn.Click += new System.EventHandler(this.addFoodBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.mainPanel.Controls.Add(this.fdUsername);
            this.mainPanel.Controls.Add(this.FDLabel);
            this.mainPanel.Controls.Add(this.addFoodBtn);
            this.mainPanel.Controls.Add(this.foodDiaryPanel);
            this.mainPanel.Controls.Add(this.dbDateTime);
            this.mainPanel.Controls.Add(this.fdTotalPanel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.totalTxtPanel);
            this.mainPanel.Location = new System.Drawing.Point(2, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1109, 668);
            this.mainPanel.TabIndex = 43;
            // 
            // fdUsername
            // 
            this.fdUsername.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdUsername.ForeColor = System.Drawing.Color.Black;
            this.fdUsername.Location = new System.Drawing.Point(837, 9);
            this.fdUsername.Name = "fdUsername";
            this.fdUsername.Size = new System.Drawing.Size(91, 25);
            this.fdUsername.TabIndex = 104;
            this.fdUsername.Text = "username";
            this.fdUsername.TextChanged += new System.EventHandler(this.fdUsername_TextChanged);
            this.fdUsername.Click += new System.EventHandler(this.fdUsername_Click);
            // 
            // foodDiaryPanel
            // 
            this.foodDiaryPanel.AutoScroll = true;
            this.foodDiaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.foodDiaryPanel.Location = new System.Drawing.Point(22, 109);
            this.foodDiaryPanel.Name = "foodDiaryPanel";
            this.foodDiaryPanel.Size = new System.Drawing.Size(1084, 421);
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
            this.fdTotalPanel.Location = new System.Drawing.Point(554, 540);
            this.fdTotalPanel.Margin = new System.Windows.Forms.Padding(2);
            this.fdTotalPanel.Name = "fdTotalPanel";
            this.fdTotalPanel.Radius = 13;
            this.fdTotalPanel.ShadowColor = System.Drawing.Color.Transparent;
            this.fdTotalPanel.ShadowDepth = 0;
            this.fdTotalPanel.ShadowShift = 0;
            this.fdTotalPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.fdTotalPanel.Size = new System.Drawing.Size(527, 125);
            this.fdTotalPanel.TabIndex = 40;
            // 
            // fdProtein
            // 
            this.fdProtein.AutoSize = true;
            this.fdProtein.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdProtein.ForeColor = System.Drawing.Color.Black;
            this.fdProtein.Location = new System.Drawing.Point(261, 50);
            this.fdProtein.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fdProtein.Name = "fdProtein";
            this.fdProtein.Size = new System.Drawing.Size(18, 22);
            this.fdProtein.TabIndex = 46;
            this.fdProtein.Text = "0";
            // 
            // RemainProtein
            // 
            this.RemainProtein.AutoSize = true;
            this.RemainProtein.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainProtein.Location = new System.Drawing.Point(261, 89);
            this.RemainProtein.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemainProtein.Name = "RemainProtein";
            this.RemainProtein.Size = new System.Drawing.Size(18, 22);
            this.RemainProtein.TabIndex = 45;
            this.RemainProtein.Text = "0";
            // 
            // TotalProtein
            // 
            this.TotalProtein.AutoSize = true;
            this.TotalProtein.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalProtein.ForeColor = System.Drawing.Color.Black;
            this.TotalProtein.Location = new System.Drawing.Point(261, 13);
            this.TotalProtein.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalProtein.Name = "TotalProtein";
            this.TotalProtein.Size = new System.Drawing.Size(18, 22);
            this.TotalProtein.TabIndex = 44;
            this.TotalProtein.Text = "0";
            // 
            // fdFat
            // 
            this.fdFat.AutoSize = true;
            this.fdFat.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdFat.ForeColor = System.Drawing.Color.Black;
            this.fdFat.Location = new System.Drawing.Point(184, 50);
            this.fdFat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fdFat.Name = "fdFat";
            this.fdFat.Size = new System.Drawing.Size(18, 22);
            this.fdFat.TabIndex = 43;
            this.fdFat.Text = "0";
            // 
            // RemainFat
            // 
            this.RemainFat.AutoSize = true;
            this.RemainFat.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainFat.Location = new System.Drawing.Point(184, 89);
            this.RemainFat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemainFat.Name = "RemainFat";
            this.RemainFat.Size = new System.Drawing.Size(18, 22);
            this.RemainFat.TabIndex = 42;
            this.RemainFat.Text = "0";
            // 
            // TotalFat
            // 
            this.TotalFat.AutoSize = true;
            this.TotalFat.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFat.ForeColor = System.Drawing.Color.Black;
            this.TotalFat.Location = new System.Drawing.Point(184, 13);
            this.TotalFat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalFat.Name = "TotalFat";
            this.TotalFat.Size = new System.Drawing.Size(18, 22);
            this.TotalFat.TabIndex = 41;
            this.TotalFat.Text = "0";
            // 
            // fdCarbs
            // 
            this.fdCarbs.AutoSize = true;
            this.fdCarbs.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdCarbs.ForeColor = System.Drawing.Color.Black;
            this.fdCarbs.Location = new System.Drawing.Point(113, 50);
            this.fdCarbs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fdCarbs.Name = "fdCarbs";
            this.fdCarbs.Size = new System.Drawing.Size(18, 22);
            this.fdCarbs.TabIndex = 40;
            this.fdCarbs.Text = "0";
            // 
            // RemainCarb
            // 
            this.RemainCarb.AutoSize = true;
            this.RemainCarb.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainCarb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainCarb.Location = new System.Drawing.Point(113, 89);
            this.RemainCarb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemainCarb.Name = "RemainCarb";
            this.RemainCarb.Size = new System.Drawing.Size(18, 22);
            this.RemainCarb.TabIndex = 39;
            this.RemainCarb.Text = "0";
            // 
            // TotalCarb
            // 
            this.TotalCarb.AutoSize = true;
            this.TotalCarb.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCarb.ForeColor = System.Drawing.Color.Black;
            this.TotalCarb.Location = new System.Drawing.Point(113, 13);
            this.TotalCarb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCarb.Name = "TotalCarb";
            this.TotalCarb.Size = new System.Drawing.Size(18, 22);
            this.TotalCarb.TabIndex = 38;
            this.TotalCarb.Text = "0";
            // 
            // fdCal
            // 
            this.fdCal.AutoSize = true;
            this.fdCal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdCal.ForeColor = System.Drawing.Color.Black;
            this.fdCal.Location = new System.Drawing.Point(28, 50);
            this.fdCal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fdCal.Name = "fdCal";
            this.fdCal.Size = new System.Drawing.Size(18, 22);
            this.fdCal.TabIndex = 37;
            this.fdCal.Text = "0";
            // 
            // RemainCal
            // 
            this.RemainCal.AutoSize = true;
            this.RemainCal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.RemainCal.Location = new System.Drawing.Point(28, 89);
            this.RemainCal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemainCal.Name = "RemainCal";
            this.RemainCal.Size = new System.Drawing.Size(18, 22);
            this.RemainCal.TabIndex = 36;
            this.RemainCal.Text = "0";
            // 
            // TotalCal
            // 
            this.TotalCal.AutoSize = true;
            this.TotalCal.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCal.ForeColor = System.Drawing.Color.Black;
            this.TotalCal.Location = new System.Drawing.Point(28, 13);
            this.TotalCal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalCal.Name = "TotalCal";
            this.TotalCal.Size = new System.Drawing.Size(18, 22);
            this.TotalCal.TabIndex = 35;
            this.TotalCal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(22, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 56);
            this.panel1.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 68;
            this.label5.Text = "Meal";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(156, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Food Description";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(481, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Unit";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(391, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 66;
            this.label2.Text = "Servings";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gray;
            this.label21.Location = new System.Drawing.Point(793, 33);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 22);
            this.label21.TabIndex = 65;
            this.label21.Text = "g";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(716, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 22);
            this.label14.TabIndex = 60;
            this.label14.Text = "Fat";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gray;
            this.label20.Location = new System.Drawing.Point(718, 33);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 22);
            this.label20.TabIndex = 64;
            this.label20.Text = "g";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(550, 11);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 22);
            this.label12.TabIndex = 58;
            this.label12.Text = "Calories";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(637, 33);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 22);
            this.label19.TabIndex = 63;
            this.label19.Text = "g";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(633, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 22);
            this.label13.TabIndex = 59;
            this.label13.Text = "Carbs";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(540, 33);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 22);
            this.label18.TabIndex = 62;
            this.label18.Text = "kCal";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(784, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 22);
            this.label15.TabIndex = 61;
            this.label15.Text = "Protein";
            // 
            // totalTxtPanel
            // 
            this.totalTxtPanel.Controls.Add(this.label6);
            this.totalTxtPanel.Controls.Add(this.label7);
            this.totalTxtPanel.Controls.Add(this.label8);
            this.totalTxtPanel.Location = new System.Drawing.Point(417, 539);
            this.totalTxtPanel.Name = "totalTxtPanel";
            this.totalTxtPanel.Size = new System.Drawing.Size(132, 127);
            this.totalTxtPanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label6.Location = new System.Drawing.Point(78, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label7.Location = new System.Drawing.Point(27, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 42;
            this.label7.Text = "Your Daily Goal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label8.Location = new System.Drawing.Point(43, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "Remaining";
            // 
            // FoodDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1110, 669);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodDiary";
            this.Text = "FoodDiary";
            this.Load += new System.EventHandler(this.FoodDiary_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.fdTotalPanel.ResumeLayout(false);
            this.fdTotalPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.totalTxtPanel.ResumeLayout(false);
            this.totalTxtPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FDLabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dbDateTime;
        private Guna.UI2.WinForms.Guna2Button addFoodBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label4;
    }
}