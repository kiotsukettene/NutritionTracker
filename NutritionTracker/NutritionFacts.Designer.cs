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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainPanel = new System.Windows.Forms.Panel();
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
            this.dbDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
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
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(522, 594);
            this.mainPanel.TabIndex = 0;
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
            this.deleteBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Location = new System.Drawing.Point(240, 546);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(127, 37);
            this.deleteBtn.TabIndex = 201;
            this.deleteBtn.Text = "Delete ";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(323, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 23);
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
            this.mealBox.Location = new System.Drawing.Point(358, 360);
            this.mealBox.Margin = new System.Windows.Forms.Padding(2);
            this.mealBox.Name = "mealBox";
            this.mealBox.ShadowDecoration.Parent = this.mealBox;
            this.mealBox.Size = new System.Drawing.Size(135, 34);
            this.mealBox.StartIndex = 0;
            this.mealBox.TabIndex = 199;
            // 
            // nfUsername
            // 
            this.nfUsername.AutoSize = true;
            this.nfUsername.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfUsername.ForeColor = System.Drawing.Color.Black;
            this.nfUsername.Location = new System.Drawing.Point(190, 312);
            this.nfUsername.Name = "nfUsername";
            this.nfUsername.Size = new System.Drawing.Size(63, 23);
            this.nfUsername.TabIndex = 198;
            this.nfUsername.Text = "Calories";
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
            this.addToFDBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToFDBtn.ForeColor = System.Drawing.Color.Black;
            this.addToFDBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.addToFDBtn.HoverState.Parent = this.addToFDBtn;
            this.addToFDBtn.Location = new System.Drawing.Point(374, 546);
            this.addToFDBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addToFDBtn.Name = "addToFDBtn";
            this.addToFDBtn.ShadowDecoration.Parent = this.addToFDBtn;
            this.addToFDBtn.Size = new System.Drawing.Size(127, 37);
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
            this.label3.Location = new System.Drawing.Point(200, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 42);
            this.label3.TabIndex = 170;
            this.label3.Text = "Calories";
            // 
            // chartCal
            // 
            this.chartCal.AutoSize = true;
            this.chartCal.BackColor = System.Drawing.Color.Transparent;
            this.chartCal.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartCal.ForeColor = System.Drawing.Color.Black;
            this.chartCal.Location = new System.Drawing.Point(232, 128);
            this.chartCal.Name = "chartCal";
            this.chartCal.Size = new System.Drawing.Size(56, 48);
            this.chartCal.TabIndex = 169;
            this.chartCal.Text = "113";
            // 
            // proteinPercentLbl
            // 
            this.proteinPercentLbl.AutoSize = true;
            this.proteinPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.proteinPercentLbl.Location = new System.Drawing.Point(398, 241);
            this.proteinPercentLbl.Name = "proteinPercentLbl";
            this.proteinPercentLbl.Size = new System.Drawing.Size(63, 23);
            this.proteinPercentLbl.TabIndex = 168;
            this.proteinPercentLbl.Text = "Calories";
            // 
            // carbPercentLbl
            // 
            this.carbPercentLbl.AutoSize = true;
            this.carbPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.carbPercentLbl.Location = new System.Drawing.Point(398, 218);
            this.carbPercentLbl.Name = "carbPercentLbl";
            this.carbPercentLbl.Size = new System.Drawing.Size(63, 23);
            this.carbPercentLbl.TabIndex = 167;
            this.carbPercentLbl.Text = "Calories";
            // 
            // fatPercentLbl
            // 
            this.fatPercentLbl.AutoSize = true;
            this.fatPercentLbl.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatPercentLbl.ForeColor = System.Drawing.Color.Black;
            this.fatPercentLbl.Location = new System.Drawing.Point(398, 195);
            this.fatPercentLbl.Name = "fatPercentLbl";
            this.fatPercentLbl.Size = new System.Drawing.Size(63, 23);
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
            this.guna2CircleButton3.Location = new System.Drawing.Point(382, 248);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(10, 10);
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
            this.guna2CircleButton2.Location = new System.Drawing.Point(382, 224);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(10, 10);
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(382, 200);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(10, 10);
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
            this.unitBox.Location = new System.Drawing.Point(188, 360);
            this.unitBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.unitBox.Name = "unitBox";
            this.unitBox.PasswordChar = '\0';
            this.unitBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.unitBox.PlaceholderText = "";
            this.unitBox.SelectedText = "";
            this.unitBox.ShadowDecoration.Parent = this.unitBox;
            this.unitBox.Size = new System.Drawing.Size(128, 35);
            this.unitBox.TabIndex = 162;
            // 
            // totalProteinLabel
            // 
            this.totalProteinLabel.AutoSize = true;
            this.totalProteinLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProteinLabel.ForeColor = System.Drawing.Color.Black;
            this.totalProteinLabel.Location = new System.Drawing.Point(157, 538);
            this.totalProteinLabel.Name = "totalProteinLabel";
            this.totalProteinLabel.Size = new System.Drawing.Size(24, 23);
            this.totalProteinLabel.TabIndex = 161;
            this.totalProteinLabel.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(23, 538);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 160;
            this.label12.Text = "Total Protein";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatLabel.ForeColor = System.Drawing.Color.Black;
            this.fatLabel.Location = new System.Drawing.Point(157, 498);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(29, 23);
            this.fatLabel.TabIndex = 159;
            this.fatLabel.Text = "2 g";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(23, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 23);
            this.label10.TabIndex = 158;
            this.label10.Text = "Total Fat";
            // 
            // carbLabel
            // 
            this.carbLabel.AutoSize = true;
            this.carbLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbLabel.ForeColor = System.Drawing.Color.Black;
            this.carbLabel.Location = new System.Drawing.Point(157, 463);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(30, 23);
            this.carbLabel.TabIndex = 157;
            this.carbLabel.Text = "5 g";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 156;
            this.label8.Text = "Total Carbs";
            // 
            // calLabel
            // 
            this.calLabel.AutoSize = true;
            this.calLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calLabel.ForeColor = System.Drawing.Color.Black;
            this.calLabel.Location = new System.Drawing.Point(157, 423);
            this.calLabel.Name = "calLabel";
            this.calLabel.Size = new System.Drawing.Size(26, 23);
            this.calLabel.TabIndex = 155;
            this.calLabel.Text = "113";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 154;
            this.label6.Text = "Calories";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(18, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 2);
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
            this.servingsBox.Location = new System.Drawing.Point(98, 360);
            this.servingsBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.servingsBox.Name = "servingsBox";
            this.servingsBox.PasswordChar = '\0';
            this.servingsBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.servingsBox.PlaceholderText = "";
            this.servingsBox.SelectedText = "";
            this.servingsBox.ShadowDecoration.Parent = this.servingsBox;
            this.servingsBox.Size = new System.Drawing.Size(82, 35);
            this.servingsBox.TabIndex = 141;
            this.servingsBox.TextChanged += new System.EventHandler(this.servingsBox_TextChanged);
            this.servingsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.servingsBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 139;
            this.label5.Text = "Servings:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(18, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 2);
            this.panel2.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 104;
            this.label1.Text = "Nutrition Facts";
            // 
            // foodName
            // 
            this.foodName.AutoSize = true;
            this.foodName.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodName.ForeColor = System.Drawing.Color.Black;
            this.foodName.Location = new System.Drawing.Point(5, 9);
            this.foodName.Name = "foodName";
            this.foodName.Size = new System.Drawing.Size(175, 48);
            this.foodName.TabIndex = 103;
            this.foodName.Text = "Food Name";
            this.foodName.TextChanged += new System.EventHandler(this.foodName_TextChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Poppins", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(92)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(79, 60);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))))};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            series3.CustomProperties = "DoughnutRadius=30, PieLabelStyle=Disabled";
            series3.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(357, 230);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
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
            this.dbDateTime.Location = new System.Drawing.Point(368, 307);
            this.dbDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dbDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dbDateTime.Name = "dbDateTime";
            this.dbDateTime.ShadowDecoration.Parent = this.dbDateTime;
            this.dbDateTime.Size = new System.Drawing.Size(133, 28);
            this.dbDateTime.TabIndex = 202;
            this.dbDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dbDateTime.Value = new System.DateTime(2024, 5, 19, 0, 0, 0, 0);
            // 
            // NutritionFacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 594);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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