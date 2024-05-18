namespace NutritionTracker
{
    partial class MyPersonalFood
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
            this.PersonalFoodLbl = new System.Windows.Forms.Label();
            this.FoodListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createFoodBtn = new Guna.UI2.WinForms.Guna2Button();
            this.foodListLbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CFLabel = new System.Windows.Forms.Label();
            this.foodDescTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NFPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.servingUnitBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.saveChangesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalProteinCreateBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalFatCreateBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalCarbCreateBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.caloriesCreateBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.servingValueBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.servingContainerBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.brandTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nutritionFactsPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.NFPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalFoodLbl
            // 
            this.PersonalFoodLbl.AutoSize = true;
            this.PersonalFoodLbl.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalFoodLbl.ForeColor = System.Drawing.Color.Black;
            this.PersonalFoodLbl.Location = new System.Drawing.Point(12, 0);
            this.PersonalFoodLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PersonalFoodLbl.Name = "PersonalFoodLbl";
            this.PersonalFoodLbl.Size = new System.Drawing.Size(351, 56);
            this.PersonalFoodLbl.TabIndex = 14;
            this.PersonalFoodLbl.Text = "Your Personal Foods";
            // 
            // FoodListPanel
            // 
            this.FoodListPanel.AutoScroll = true;
            this.FoodListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.FoodListPanel.Location = new System.Drawing.Point(22, 133);
            this.FoodListPanel.Name = "FoodListPanel";
            this.FoodListPanel.Size = new System.Drawing.Size(492, 523);
            this.FoodListPanel.TabIndex = 18;
            // 
            // createFoodBtn
            // 
            this.createFoodBtn.Animated = true;
            this.createFoodBtn.BorderColor = System.Drawing.Color.White;
            this.createFoodBtn.BorderRadius = 5;
            this.createFoodBtn.CheckedState.Parent = this.createFoodBtn;
            this.createFoodBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createFoodBtn.CustomBorderColor = System.Drawing.Color.White;
            this.createFoodBtn.CustomImages.Parent = this.createFoodBtn;
            this.createFoodBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.createFoodBtn.Font = new System.Drawing.Font("Poppins", 9F);
            this.createFoodBtn.ForeColor = System.Drawing.Color.Black;
            this.createFoodBtn.HoverState.Parent = this.createFoodBtn;
            this.createFoodBtn.Location = new System.Drawing.Point(970, 11);
            this.createFoodBtn.Name = "createFoodBtn";
            this.createFoodBtn.ShadowDecoration.Parent = this.createFoodBtn;
            this.createFoodBtn.Size = new System.Drawing.Size(96, 35);
            this.createFoodBtn.TabIndex = 19;
            this.createFoodBtn.Text = "Create Food";
            this.createFoodBtn.Click += new System.EventHandler(this.createFood);
            // 
            // foodListLbl
            // 
            this.foodListLbl.AutoSize = true;
            this.foodListLbl.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListLbl.ForeColor = System.Drawing.Color.Black;
            this.foodListLbl.Location = new System.Drawing.Point(14, 62);
            this.foodListLbl.Name = "foodListLbl";
            this.foodListLbl.Size = new System.Drawing.Size(137, 48);
            this.foodListLbl.TabIndex = 101;
            this.foodListLbl.Text = "Food List";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.usernameLbl);
            this.mainPanel.Controls.Add(this.foodListLbl);
            this.mainPanel.Controls.Add(this.PersonalFoodLbl);
            this.mainPanel.Controls.Add(this.FoodListPanel);
            this.mainPanel.Controls.Add(this.createFoodBtn);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.nutritionFactsPanel);
            this.mainPanel.Location = new System.Drawing.Point(1, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1109, 672);
            this.mainPanel.TabIndex = 103;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 22);
            this.label1.TabIndex = 109;
            this.label1.Text = "To view a personal food, click on that food below.";
            // 
            // usernameLbl
            // 
            this.usernameLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.Black;
            this.usernameLbl.Location = new System.Drawing.Point(864, 16);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(91, 25);
            this.usernameLbl.TabIndex = 103;
            this.usernameLbl.Text = "username";
            this.usernameLbl.Visible = false;
            this.usernameLbl.TextChanged += new System.EventHandler(this.usernameLbl_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CFLabel);
            this.panel1.Controls.Add(this.foodDescTxtBox);
            this.panel1.Controls.Add(this.NFPanel);
            this.panel1.Controls.Add(this.brandTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(553, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 594);
            this.panel1.TabIndex = 113;
            // 
            // CFLabel
            // 
            this.CFLabel.AutoSize = true;
            this.CFLabel.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CFLabel.ForeColor = System.Drawing.Color.Black;
            this.CFLabel.Location = new System.Drawing.Point(3, 0);
            this.CFLabel.Name = "CFLabel";
            this.CFLabel.Size = new System.Drawing.Size(201, 48);
            this.CFLabel.TabIndex = 105;
            this.CFLabel.Text = "Create Foods";
            // 
            // foodDescTxtBox
            // 
            this.foodDescTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.foodDescTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.foodDescTxtBox.BorderRadius = 5;
            this.foodDescTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.foodDescTxtBox.DefaultText = "";
            this.foodDescTxtBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.foodDescTxtBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.foodDescTxtBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.foodDescTxtBox.DisabledState.Parent = this.foodDescTxtBox;
            this.foodDescTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.foodDescTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.foodDescTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodDescTxtBox.FocusedState.Parent = this.foodDescTxtBox;
            this.foodDescTxtBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodDescTxtBox.ForeColor = System.Drawing.Color.Black;
            this.foodDescTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.foodDescTxtBox.HoverState.Parent = this.foodDescTxtBox;
            this.foodDescTxtBox.Location = new System.Drawing.Point(256, 113);
            this.foodDescTxtBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.foodDescTxtBox.Name = "foodDescTxtBox";
            this.foodDescTxtBox.PasswordChar = '\0';
            this.foodDescTxtBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.foodDescTxtBox.PlaceholderText = "";
            this.foodDescTxtBox.SelectedText = "";
            this.foodDescTxtBox.ShadowDecoration.Parent = this.foodDescTxtBox;
            this.foodDescTxtBox.Size = new System.Drawing.Size(235, 38);
            this.foodDescTxtBox.TabIndex = 112;
            // 
            // NFPanel
            // 
            this.NFPanel.BackColor = System.Drawing.Color.Transparent;
            this.NFPanel.Controls.Add(this.servingUnitBox);
            this.NFPanel.Controls.Add(this.label29);
            this.NFPanel.Controls.Add(this.label28);
            this.NFPanel.Controls.Add(this.saveChangesBtn);
            this.NFPanel.Controls.Add(this.label27);
            this.NFPanel.Controls.Add(this.label12);
            this.NFPanel.Controls.Add(this.totalProteinCreateBox);
            this.NFPanel.Controls.Add(this.totalFatCreateBox);
            this.NFPanel.Controls.Add(this.totalCarbCreateBox);
            this.NFPanel.Controls.Add(this.caloriesCreateBox);
            this.NFPanel.Controls.Add(this.label20);
            this.NFPanel.Controls.Add(this.label17);
            this.NFPanel.Controls.Add(this.label15);
            this.NFPanel.Controls.Add(this.label10);
            this.NFPanel.Controls.Add(this.label9);
            this.NFPanel.Controls.Add(this.servingValueBox);
            this.NFPanel.Controls.Add(this.label7);
            this.NFPanel.Controls.Add(this.label6);
            this.NFPanel.Controls.Add(this.label8);
            this.NFPanel.Controls.Add(this.servingContainerBox);
            this.NFPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.NFPanel.Location = new System.Drawing.Point(16, 172);
            this.NFPanel.Margin = new System.Windows.Forms.Padding(2);
            this.NFPanel.Name = "NFPanel";
            this.NFPanel.Radius = 13;
            this.NFPanel.ShadowColor = System.Drawing.Color.Transparent;
            this.NFPanel.ShadowDepth = 0;
            this.NFPanel.ShadowShift = 0;
            this.NFPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.NFPanel.Size = new System.Drawing.Size(436, 409);
            this.NFPanel.TabIndex = 106;
            // 
            // servingUnitBox
            // 
            this.servingUnitBox.BackColor = System.Drawing.Color.Transparent;
            this.servingUnitBox.BorderColor = System.Drawing.Color.Gray;
            this.servingUnitBox.BorderRadius = 5;
            this.servingUnitBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.servingUnitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servingUnitBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.servingUnitBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servingUnitBox.FocusedColor = System.Drawing.Color.Empty;
            this.servingUnitBox.FocusedState.Parent = this.servingUnitBox;
            this.servingUnitBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingUnitBox.ForeColor = System.Drawing.Color.Black;
            this.servingUnitBox.FormattingEnabled = true;
            this.servingUnitBox.HoverState.Parent = this.servingUnitBox;
            this.servingUnitBox.ItemHeight = 25;
            this.servingUnitBox.Items.AddRange(new object[] {
            "gram",
            "ml",
            "cup",
            "pound",
            "kg"});
            this.servingUnitBox.ItemsAppearance.Parent = this.servingUnitBox;
            this.servingUnitBox.Location = new System.Drawing.Point(210, 43);
            this.servingUnitBox.Margin = new System.Windows.Forms.Padding(2);
            this.servingUnitBox.Name = "servingUnitBox";
            this.servingUnitBox.ShadowDecoration.Parent = this.servingUnitBox;
            this.servingUnitBox.Size = new System.Drawing.Size(165, 31);
            this.servingUnitBox.StartIndex = 0;
            this.servingUnitBox.TabIndex = 168;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label29.ForeColor = System.Drawing.Color.DimGray;
            this.label29.Location = new System.Drawing.Point(292, 312);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 17);
            this.label29.TabIndex = 122;
            this.label29.Text = "g";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label28.ForeColor = System.Drawing.Color.DimGray;
            this.label28.Location = new System.Drawing.Point(292, 264);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 17);
            this.label28.TabIndex = 121;
            this.label28.Text = "g";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.BorderColor = System.Drawing.Color.White;
            this.saveChangesBtn.BorderRadius = 5;
            this.saveChangesBtn.CheckedState.Parent = this.saveChangesBtn;
            this.saveChangesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChangesBtn.CustomBorderColor = System.Drawing.Color.White;
            this.saveChangesBtn.CustomImages.Parent = this.saveChangesBtn;
            this.saveChangesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.saveChangesBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesBtn.ForeColor = System.Drawing.Color.Black;
            this.saveChangesBtn.HoverState.Parent = this.saveChangesBtn;
            this.saveChangesBtn.Location = new System.Drawing.Point(24, 356);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.ShadowDecoration.Parent = this.saveChangesBtn;
            this.saveChangesBtn.Size = new System.Drawing.Size(127, 37);
            this.saveChangesBtn.TabIndex = 86;
            this.saveChangesBtn.Text = "Save Food";
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label27.ForeColor = System.Drawing.Color.DimGray;
            this.label27.Location = new System.Drawing.Point(294, 214);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 17);
            this.label27.TabIndex = 120;
            this.label27.Text = "g";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(294, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 119;
            this.label12.Text = "kCal";
            // 
            // totalProteinCreateBox
            // 
            this.totalProteinCreateBox.BackColor = System.Drawing.Color.Transparent;
            this.totalProteinCreateBox.BorderColor = System.Drawing.Color.Gray;
            this.totalProteinCreateBox.BorderRadius = 5;
            this.totalProteinCreateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalProteinCreateBox.DefaultText = "";
            this.totalProteinCreateBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.totalProteinCreateBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.totalProteinCreateBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.totalProteinCreateBox.DisabledState.Parent = this.totalProteinCreateBox;
            this.totalProteinCreateBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalProteinCreateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.totalProteinCreateBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalProteinCreateBox.FocusedState.Parent = this.totalProteinCreateBox;
            this.totalProteinCreateBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProteinCreateBox.ForeColor = System.Drawing.Color.Black;
            this.totalProteinCreateBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalProteinCreateBox.HoverState.Parent = this.totalProteinCreateBox;
            this.totalProteinCreateBox.Location = new System.Drawing.Point(192, 306);
            this.totalProteinCreateBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.totalProteinCreateBox.Name = "totalProteinCreateBox";
            this.totalProteinCreateBox.PasswordChar = '\0';
            this.totalProteinCreateBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.totalProteinCreateBox.PlaceholderText = "";
            this.totalProteinCreateBox.SelectedText = "";
            this.totalProteinCreateBox.ShadowDecoration.Parent = this.totalProteinCreateBox;
            this.totalProteinCreateBox.Size = new System.Drawing.Size(97, 32);
            this.totalProteinCreateBox.TabIndex = 94;
            this.totalProteinCreateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalFatCreateBox
            // 
            this.totalFatCreateBox.BackColor = System.Drawing.Color.Transparent;
            this.totalFatCreateBox.BorderColor = System.Drawing.Color.Gray;
            this.totalFatCreateBox.BorderRadius = 5;
            this.totalFatCreateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalFatCreateBox.DefaultText = "";
            this.totalFatCreateBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.totalFatCreateBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.totalFatCreateBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.totalFatCreateBox.DisabledState.Parent = this.totalFatCreateBox;
            this.totalFatCreateBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalFatCreateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.totalFatCreateBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalFatCreateBox.FocusedState.Parent = this.totalFatCreateBox;
            this.totalFatCreateBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFatCreateBox.ForeColor = System.Drawing.Color.Black;
            this.totalFatCreateBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalFatCreateBox.HoverState.Parent = this.totalFatCreateBox;
            this.totalFatCreateBox.Location = new System.Drawing.Point(192, 256);
            this.totalFatCreateBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.totalFatCreateBox.Name = "totalFatCreateBox";
            this.totalFatCreateBox.PasswordChar = '\0';
            this.totalFatCreateBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.totalFatCreateBox.PlaceholderText = "";
            this.totalFatCreateBox.SelectedText = "";
            this.totalFatCreateBox.ShadowDecoration.Parent = this.totalFatCreateBox;
            this.totalFatCreateBox.Size = new System.Drawing.Size(97, 32);
            this.totalFatCreateBox.TabIndex = 93;
            this.totalFatCreateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalCarbCreateBox
            // 
            this.totalCarbCreateBox.BackColor = System.Drawing.Color.Transparent;
            this.totalCarbCreateBox.BorderColor = System.Drawing.Color.Gray;
            this.totalCarbCreateBox.BorderRadius = 5;
            this.totalCarbCreateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalCarbCreateBox.DefaultText = "";
            this.totalCarbCreateBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.totalCarbCreateBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.totalCarbCreateBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.totalCarbCreateBox.DisabledState.Parent = this.totalCarbCreateBox;
            this.totalCarbCreateBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalCarbCreateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.totalCarbCreateBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalCarbCreateBox.FocusedState.Parent = this.totalCarbCreateBox;
            this.totalCarbCreateBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCarbCreateBox.ForeColor = System.Drawing.Color.Black;
            this.totalCarbCreateBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalCarbCreateBox.HoverState.Parent = this.totalCarbCreateBox;
            this.totalCarbCreateBox.Location = new System.Drawing.Point(192, 206);
            this.totalCarbCreateBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.totalCarbCreateBox.Name = "totalCarbCreateBox";
            this.totalCarbCreateBox.PasswordChar = '\0';
            this.totalCarbCreateBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.totalCarbCreateBox.PlaceholderText = "";
            this.totalCarbCreateBox.SelectedText = "";
            this.totalCarbCreateBox.ShadowDecoration.Parent = this.totalCarbCreateBox;
            this.totalCarbCreateBox.Size = new System.Drawing.Size(97, 32);
            this.totalCarbCreateBox.TabIndex = 92;
            this.totalCarbCreateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // caloriesCreateBox
            // 
            this.caloriesCreateBox.BackColor = System.Drawing.Color.Transparent;
            this.caloriesCreateBox.BorderColor = System.Drawing.Color.Gray;
            this.caloriesCreateBox.BorderRadius = 5;
            this.caloriesCreateBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caloriesCreateBox.DefaultText = "";
            this.caloriesCreateBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.caloriesCreateBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.caloriesCreateBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.caloriesCreateBox.DisabledState.Parent = this.caloriesCreateBox;
            this.caloriesCreateBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.caloriesCreateBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.caloriesCreateBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caloriesCreateBox.FocusedState.Parent = this.caloriesCreateBox;
            this.caloriesCreateBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesCreateBox.ForeColor = System.Drawing.Color.Black;
            this.caloriesCreateBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.caloriesCreateBox.HoverState.Parent = this.caloriesCreateBox;
            this.caloriesCreateBox.Location = new System.Drawing.Point(192, 156);
            this.caloriesCreateBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.caloriesCreateBox.Name = "caloriesCreateBox";
            this.caloriesCreateBox.PasswordChar = '\0';
            this.caloriesCreateBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.caloriesCreateBox.PlaceholderText = "";
            this.caloriesCreateBox.SelectedText = "";
            this.caloriesCreateBox.ShadowDecoration.Parent = this.caloriesCreateBox;
            this.caloriesCreateBox.Size = new System.Drawing.Size(97, 32);
            this.caloriesCreateBox.TabIndex = 79;
            this.caloriesCreateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(24, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 18);
            this.label20.TabIndex = 89;
            this.label20.Text = "Total Protein";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(24, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 18);
            this.label17.TabIndex = 86;
            this.label17.Text = "Total Fat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(24, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 26);
            this.label15.TabIndex = 84;
            this.label15.Text = "Total Carbs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(24, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 26);
            this.label10.TabIndex = 80;
            this.label10.Text = "Calories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label9.Location = new System.Drawing.Point(19, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 28);
            this.label9.TabIndex = 78;
            this.label9.Text = "Amount Per Serving";
            // 
            // servingValueBox
            // 
            this.servingValueBox.BackColor = System.Drawing.Color.Transparent;
            this.servingValueBox.BorderColor = System.Drawing.Color.Gray;
            this.servingValueBox.BorderRadius = 5;
            this.servingValueBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.servingValueBox.DefaultText = "";
            this.servingValueBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.servingValueBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.servingValueBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.servingValueBox.DisabledState.Parent = this.servingValueBox;
            this.servingValueBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.servingValueBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.servingValueBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingValueBox.FocusedState.Parent = this.servingValueBox;
            this.servingValueBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingValueBox.ForeColor = System.Drawing.Color.Black;
            this.servingValueBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingValueBox.HoverState.Parent = this.servingValueBox;
            this.servingValueBox.Location = new System.Drawing.Point(118, 43);
            this.servingValueBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.servingValueBox.Name = "servingValueBox";
            this.servingValueBox.PasswordChar = '\0';
            this.servingValueBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.servingValueBox.PlaceholderText = "";
            this.servingValueBox.SelectedText = "";
            this.servingValueBox.ShadowDecoration.Parent = this.servingValueBox;
            this.servingValueBox.Size = new System.Drawing.Size(86, 32);
            this.servingValueBox.TabIndex = 26;
            this.servingValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Serving Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.label6.Location = new System.Drawing.Point(22, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nutrition Facts";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Servings per container: (about)";
            // 
            // servingContainerBox
            // 
            this.servingContainerBox.BackColor = System.Drawing.Color.Transparent;
            this.servingContainerBox.BorderColor = System.Drawing.Color.Gray;
            this.servingContainerBox.BorderRadius = 5;
            this.servingContainerBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.servingContainerBox.DefaultText = "";
            this.servingContainerBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.servingContainerBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.servingContainerBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.servingContainerBox.DisabledState.Parent = this.servingContainerBox;
            this.servingContainerBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.servingContainerBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.servingContainerBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingContainerBox.FocusedState.Parent = this.servingContainerBox;
            this.servingContainerBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servingContainerBox.ForeColor = System.Drawing.Color.Black;
            this.servingContainerBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.servingContainerBox.HoverState.Parent = this.servingContainerBox;
            this.servingContainerBox.Location = new System.Drawing.Point(250, 83);
            this.servingContainerBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.servingContainerBox.Name = "servingContainerBox";
            this.servingContainerBox.PasswordChar = '\0';
            this.servingContainerBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.servingContainerBox.PlaceholderText = "";
            this.servingContainerBox.SelectedText = "";
            this.servingContainerBox.ShadowDecoration.Parent = this.servingContainerBox;
            this.servingContainerBox.Size = new System.Drawing.Size(85, 32);
            this.servingContainerBox.TabIndex = 29;
            this.servingContainerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brandTxtBox
            // 
            this.brandTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.brandTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.brandTxtBox.BorderRadius = 5;
            this.brandTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brandTxtBox.DefaultText = "";
            this.brandTxtBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.brandTxtBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.brandTxtBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.brandTxtBox.DisabledState.Parent = this.brandTxtBox;
            this.brandTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.brandTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.brandTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandTxtBox.FocusedState.Parent = this.brandTxtBox;
            this.brandTxtBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTxtBox.ForeColor = System.Drawing.Color.Black;
            this.brandTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.brandTxtBox.HoverState.Parent = this.brandTxtBox;
            this.brandTxtBox.Location = new System.Drawing.Point(16, 113);
            this.brandTxtBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.brandTxtBox.Name = "brandTxtBox";
            this.brandTxtBox.PasswordChar = '\0';
            this.brandTxtBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.brandTxtBox.PlaceholderText = "";
            this.brandTxtBox.SelectedText = "";
            this.brandTxtBox.ShadowDecoration.Parent = this.brandTxtBox;
            this.brandTxtBox.Size = new System.Drawing.Size(204, 38);
            this.brandTxtBox.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 107;
            this.label2.Text = "Brand / Restaurant:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(251, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 26);
            this.label5.TabIndex = 110;
            this.label5.Text = "Food Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "(e.g. “Quaker Oats“)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(253, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "(e.g. “100% Whole grain oats - Old Fashioned“)";
            // 
            // nutritionFactsPanel
            // 
            this.nutritionFactsPanel.Location = new System.Drawing.Point(553, 62);
            this.nutritionFactsPanel.Name = "nutritionFactsPanel";
            this.nutritionFactsPanel.Size = new System.Drawing.Size(516, 594);
            this.nutritionFactsPanel.TabIndex = 104;
            // 
            // MyPersonalFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1110, 669);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPersonalFood";
            this.Text = "s";
            this.Load += new System.EventHandler(this.MyPersonalFood_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NFPanel.ResumeLayout(false);
            this.NFPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PersonalFoodLbl;
        private Guna.UI2.WinForms.Guna2Button createFoodBtn;
        private System.Windows.Forms.Label foodListLbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel nutritionFactsPanel;
        public System.Windows.Forms.Label usernameLbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel NFPanel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private Guna.UI2.WinForms.Guna2Button saveChangesBtn;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox totalProteinCreateBox;
        private Guna.UI2.WinForms.Guna2TextBox totalFatCreateBox;
        private Guna.UI2.WinForms.Guna2TextBox totalCarbCreateBox;
        private Guna.UI2.WinForms.Guna2TextBox caloriesCreateBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox servingValueBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox servingContainerBox;
        private System.Windows.Forms.Label CFLabel;
        private Guna.UI2.WinForms.Guna2TextBox foodDescTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox brandTxtBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox servingUnitBox;
        public System.Windows.Forms.FlowLayoutPanel FoodListPanel;
        public System.Windows.Forms.Panel panel1;
    }
}