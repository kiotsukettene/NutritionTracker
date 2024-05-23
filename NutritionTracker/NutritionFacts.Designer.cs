namespace NutritionTracker
{
    partial class NutritionFacts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dbDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mealBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nfUsername = new System.Windows.Forms.Label();
            this.addToFDBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chartCal = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.foodName = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.dbDateTime);
            this.mainPanel.Controls.Add(this.deleteBtn);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.mealBox);
            this.mainPanel.Controls.Add(this.nfUsername);
            this.mainPanel.Controls.Add(this.addToFDBtn);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.chartCal);
            this.mainPanel.Controls.Add(this.proteinPercentLbl);
            this.mainPanel.Controls.Add(this.carbPercentLbl);
            this.mainPanel.Controls.Add(this.fatPercentLbl);
            this.mainPanel.Controls.Add(this.guna2CircleButton3);
            this.mainPanel.Controls.Add(this.guna2CircleButton2);
            this.mainPanel.Controls.Add(this.guna2CircleButton1);
            this.mainPanel.Controls.Add(this.unitBox);
            this.mainPanel.Controls.Add(this.totalProteinLabel);
            this.mainPanel.Controls.Add(this.label12);
            this.mainPanel.Controls.Add(this.fatLabel);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.carbLabel);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.calLabel);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.servingsBox);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.foodName);
            this.mainPanel.Controls.Add(this.chart1);
            this.mainPanel.Location = new System.Drawing.Point(-1, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(696, 731);
            this.mainPanel.TabIndex = 0;
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
            this.dbDateTime.Location = new System.Drawing.Point(491, 378);
            this.dbDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dbDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dbDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dbDateTime.Name = "dbDateTime";
            this.dbDateTime.ShadowDecoration.Parent = this.dbDateTime;
            this.dbDateTime.Size = new System.Drawing.Size(177, 34);
            this.dbDateTime.TabIndex = 202;
            this.dbDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbDateTime.Value = new System.DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BorderColor = System.Drawing.Color.White;
            this.deleteBtn.BorderRadius = 5;
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.CustomBorderColor = System.Drawing.Color.White;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.deleteBtn.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Location = new System.Drawing.Point(320, 672);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(169, 46);
            this.deleteBtn.TabIndex = 201;
            this.deleteBtn.Text = "Delete ";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(431, 450);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 30);
            this.label7.TabIndex = 200;
            this.label7.Text = "for";
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
            this.mealBox.Location = new System.Drawing.Point(477, 443);
            this.mealBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealBox.Name = "mealBox";
            this.mealBox.ShadowDecoration.Parent = this.mealBox;
            this.mealBox.Size = new System.Drawing.Size(179, 34);
            this.mealBox.StartIndex = 0;
            this.mealBox.TabIndex = 143;
            // 
            // nfUsername
            // 
            this.nfUsername.AutoSize = true;
            this.nfUsername.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfUsername.ForeColor = System.Drawing.Color.Black;
            this.nfUsername.Location = new System.Drawing.Point(253, 384);
            this.nfUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nfUsername.Name = "nfUsername";
            this.nfUsername.Size = new System.Drawing.Size(82, 30);
            this.nfUsername.TabIndex = 198;
            this.nfUsername.Text = "Calories";
            this.nfUsername.Visible = false;
            // 
            // addToFDBtn
            // 
            this.addToFDBtn.BorderColor = System.Drawing.Color.White;
            this.addToFDBtn.BorderRadius = 5;
            this.addToFDBtn.CheckedState.Parent = this.addToFDBtn;
            this.addToFDBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToFDBtn.CustomBorderColor = System.Drawing.Color.White;
            this.addToFDBtn.CustomImages.Parent = this.addToFDBtn;
            this.addToFDBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.addToFDBtn.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToFDBtn.ForeColor = System.Drawing.Color.Black;
            this.addToFDBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.addToFDBtn.HoverState.Parent = this.addToFDBtn;
            this.addToFDBtn.Location = new System.Drawing.Point(499, 672);
            this.addToFDBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToFDBtn.Name = "addToFDBtn";
            this.addToFDBtn.ShadowDecoration.Parent = this.addToFDBtn;
            this.addToFDBtn.Size = new System.Drawing.Size(169, 46);
            this.addToFDBtn.TabIndex = 196;
            this.addToFDBtn.Text = "Add to Diary";
            this.addToFDBtn.Click += new System.EventHandler(this.addToFDBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(267, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 53);
            this.label3.TabIndex = 170;
            this.label3.Text = "Calories";
            // 
            // chartCal
            // 
            this.chartCal.AutoSize = true;
            this.chartCal.BackColor = System.Drawing.Color.Transparent;
            this.chartCal.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCal.ForeColor = System.Drawing.Color.Black;
            this.chartCal.Location = new System.Drawing.Point(309, 158);
            this.chartCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chartCal.Name = "chartCal";
            this.chartCal.Size = new System.Drawing.Size(69, 60);
            this.chartCal.TabIndex = 169;
            this.chartCal.Text = "113";
            // 
            // proteinPercentLbl
            // 
            this.proteinPercentLbl.AutoSize = true;
            this.proteinPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.proteinPercentLbl.Location = new System.Drawing.Point(531, 297);
            this.proteinPercentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proteinPercentLbl.Name = "proteinPercentLbl";
            this.proteinPercentLbl.Size = new System.Drawing.Size(82, 30);
            this.proteinPercentLbl.TabIndex = 168;
            this.proteinPercentLbl.Text = "Calories";
            // 
            // carbPercentLbl
            // 
            this.carbPercentLbl.AutoSize = true;
            this.carbPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.carbPercentLbl.Location = new System.Drawing.Point(531, 268);
            this.carbPercentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbPercentLbl.Name = "carbPercentLbl";
            this.carbPercentLbl.Size = new System.Drawing.Size(82, 30);
            this.carbPercentLbl.TabIndex = 167;
            this.carbPercentLbl.Text = "Calories";
            // 
            // fatPercentLbl
            // 
            this.fatPercentLbl.AutoSize = true;
            this.fatPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.fatPercentLbl.Location = new System.Drawing.Point(531, 240);
            this.fatPercentLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatPercentLbl.Name = "fatPercentLbl";
            this.fatPercentLbl.Size = new System.Drawing.Size(82, 30);
            this.fatPercentLbl.TabIndex = 166;
            this.fatPercentLbl.Text = "Calories";
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(509, 305);
            this.guna2CircleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton3.TabIndex = 165;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(509, 276);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton2.TabIndex = 164;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(509, 246);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(13, 12);
            this.guna2CircleButton1.TabIndex = 163;
            // 
            // unitBox
            // 
            this.unitBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.unitBox.BorderColor = System.Drawing.Color.Gray;
            this.unitBox.BorderRadius = 12;
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
            this.unitBox.Location = new System.Drawing.Point(251, 443);
            this.unitBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.unitBox.Name = "unitBox";
            this.unitBox.PasswordChar = '\0';
            this.unitBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.unitBox.PlaceholderText = "";
            this.unitBox.SelectedText = "";
            this.unitBox.ShadowDecoration.Parent = this.unitBox;
            this.unitBox.Size = new System.Drawing.Size(171, 43);
            this.unitBox.TabIndex = 142;
            // 
            // totalProteinLabel
            // 
            this.totalProteinLabel.AutoSize = true;
            this.totalProteinLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProteinLabel.ForeColor = System.Drawing.Color.Black;
            this.totalProteinLabel.Location = new System.Drawing.Point(209, 662);
            this.totalProteinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalProteinLabel.Name = "totalProteinLabel";
            this.totalProteinLabel.Size = new System.Drawing.Size(31, 30);
            this.totalProteinLabel.TabIndex = 161;
            this.totalProteinLabel.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(31, 662);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 30);
            this.label12.TabIndex = 160;
            this.label12.Text = "Total Protein";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.ForeColor = System.Drawing.Color.Black;
            this.fatLabel.Location = new System.Drawing.Point(209, 613);
            this.fatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(39, 30);
            this.fatLabel.TabIndex = 159;
            this.fatLabel.Text = "2 g";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(31, 613);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 30);
            this.label10.TabIndex = 158;
            this.label10.Text = "Total Fat";
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbLabel.ForeColor = System.Drawing.Color.Black;
            this.carbLabel.Location = new System.Drawing.Point(209, 570);
            this.carbLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(40, 30);
            this.carbLabel.TabIndex = 157;
            this.carbLabel.Text = "5 g";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 570);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 156;
            this.label8.Text = "Total Carbs";
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calLabel.ForeColor = System.Drawing.Color.Black;
            this.calLabel.Location = new System.Drawing.Point(209, 521);
            this.calLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(33, 30);
            this.calLabel.TabIndex = 155;
            this.calLabel.Text = "113";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 521);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 30);
            this.label6.TabIndex = 154;
            this.label6.Text = "Calories";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(24, 497);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 2);
            this.panel3.TabIndex = 153;
            // 
            // servingsBox
            // 
            this.servingsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.servingsBox.BorderColor = System.Drawing.Color.Gray;
            this.servingsBox.BorderRadius = 12;
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
            this.servingsBox.Location = new System.Drawing.Point(131, 443);
            this.servingsBox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.servingsBox.Name = "servingsBox";
            this.servingsBox.PasswordChar = '\0';
            this.servingsBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.servingsBox.PlaceholderText = "";
            this.servingsBox.SelectedText = "";
            this.servingsBox.ShadowDecoration.Parent = this.servingsBox;
            this.servingsBox.Size = new System.Drawing.Size(109, 43);
            this.servingsBox.TabIndex = 141;
            this.servingsBox.TextChanged += new System.EventHandler(this.servingsBox_TextChanged);
            this.servingsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.servingsBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 139;
            this.label5.Text = "Servings:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(24, 421);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 2);
            this.panel2.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 48);
            this.label1.TabIndex = 104;
            this.label1.Text = "Nutrition Facts";
            // 
            // foodName
            // 
            this.foodName.AutoSize = true;
            this.foodName.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodName.ForeColor = System.Drawing.Color.Black;
            this.foodName.Location = new System.Drawing.Point(7, 11);
            this.foodName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(223, 60);
            this.foodName.TabIndex = 103;
            this.foodName.Text = "Food Name";
            this.foodName.TextChanged += new System.EventHandler(this.foodName_TextChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Poppins", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(105, 74);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            series1.CustomProperties = "DoughnutRadius=30, PieLabelStyle=Disabled";
            series1.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(476, 283);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // NutritionFacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 731);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NutritionFacts";
            this.Text = "NutritionFacts";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label foodName;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox servingsBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label totalProteinLabel;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label fatLabel;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label carbLabel;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label calLabel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panel3;
        public Guna.UI2.WinForms.Guna2TextBox unitBox;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        public System.Windows.Forms.Label proteinPercentLbl;
        public System.Windows.Forms.Label carbPercentLbl;
        public System.Windows.Forms.Label fatPercentLbl;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label chartCal;
        private Guna.UI2.WinForms.Guna2Button addToFDBtn;
        public System.Windows.Forms.Label nfUsername;
        private Guna.UI2.WinForms.Guna2ComboBox mealBox;
        public System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dbDateTime;
    }
}