namespace NutritionTracker
{
    partial class Step2Form
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
            this.calculateMacrosBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.weightGoalBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.activityLevelBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.targetWeightTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // calculateMacrosBtn
            // 
            this.calculateMacrosBtn.BorderColor = System.Drawing.Color.White;
            this.calculateMacrosBtn.BorderRadius = 10;
            this.calculateMacrosBtn.CheckedState.Parent = this.calculateMacrosBtn;
            this.calculateMacrosBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateMacrosBtn.CustomBorderColor = System.Drawing.Color.White;
            this.calculateMacrosBtn.CustomImages.Parent = this.calculateMacrosBtn;
            this.calculateMacrosBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.calculateMacrosBtn.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateMacrosBtn.ForeColor = System.Drawing.Color.White;
            this.calculateMacrosBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(83)))));
            this.calculateMacrosBtn.HoverState.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateMacrosBtn.HoverState.Parent = this.calculateMacrosBtn;
            this.calculateMacrosBtn.Location = new System.Drawing.Point(445, 478);
            this.calculateMacrosBtn.Margin = new System.Windows.Forms.Padding(2);
            this.calculateMacrosBtn.Name = "calculateMacrosBtn";
            this.calculateMacrosBtn.ShadowDecoration.Parent = this.calculateMacrosBtn;
            this.calculateMacrosBtn.Size = new System.Drawing.Size(110, 38);
            this.calculateMacrosBtn.TabIndex = 106;
            this.calculateMacrosBtn.Text = "Calculate";
            this.calculateMacrosBtn.Click += new System.EventHandler(this.step2nxtBtn);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(168, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 104;
            this.label3.Text = "Target Weight Goal";
            // 
            // weightGoalBox
            // 
            this.weightGoalBox.BackColor = System.Drawing.Color.Transparent;
            this.weightGoalBox.BorderRadius = 10;
            this.weightGoalBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.weightGoalBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightGoalBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.weightGoalBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weightGoalBox.FocusedColor = System.Drawing.Color.Empty;
            this.weightGoalBox.FocusedState.Parent = this.weightGoalBox;
            this.weightGoalBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightGoalBox.ForeColor = System.Drawing.Color.White;
            this.weightGoalBox.FormattingEnabled = true;
            this.weightGoalBox.HoverState.Parent = this.weightGoalBox;
            this.weightGoalBox.ItemHeight = 40;
            this.weightGoalBox.Items.AddRange(new object[] {
            "Weight Loss",
            "Weight Gain",
            "Weight Maintenance"});
            this.weightGoalBox.ItemsAppearance.Parent = this.weightGoalBox;
            this.weightGoalBox.Location = new System.Drawing.Point(172, 306);
            this.weightGoalBox.Margin = new System.Windows.Forms.Padding(2);
            this.weightGoalBox.Name = "weightGoalBox";
            this.weightGoalBox.ShadowDecoration.Parent = this.weightGoalBox;
            this.weightGoalBox.Size = new System.Drawing.Size(399, 46);
            this.weightGoalBox.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 102;
            this.label2.Text = "Weight Goal";
            // 
            // activityLevelBox
            // 
            this.activityLevelBox.BackColor = System.Drawing.Color.Transparent;
            this.activityLevelBox.BorderRadius = 10;
            this.activityLevelBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.activityLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityLevelBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.activityLevelBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityLevelBox.FocusedColor = System.Drawing.Color.Empty;
            this.activityLevelBox.FocusedState.Parent = this.activityLevelBox;
            this.activityLevelBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLevelBox.ForeColor = System.Drawing.Color.White;
            this.activityLevelBox.FormattingEnabled = true;
            this.activityLevelBox.HoverState.Parent = this.activityLevelBox;
            this.activityLevelBox.ItemHeight = 40;
            this.activityLevelBox.Items.AddRange(new object[] {
            "Sedentary (little to no exercise)",
            "Lightly active (light exercise/sports 1-3 days a week)",
            "Moderately active (moderate exercise/sports 3-5 days a week)",
            "Very active (hard exercise/sports 6-7 days a week)"});
            this.activityLevelBox.ItemsAppearance.Parent = this.activityLevelBox;
            this.activityLevelBox.Location = new System.Drawing.Point(172, 212);
            this.activityLevelBox.Margin = new System.Windows.Forms.Padding(2);
            this.activityLevelBox.Name = "activityLevelBox";
            this.activityLevelBox.ShadowDecoration.Parent = this.activityLevelBox;
            this.activityLevelBox.Size = new System.Drawing.Size(399, 46);
            this.activityLevelBox.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Activity Level";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(103, 135);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(525, 1);
            this.panel7.TabIndex = 99;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderRadius = 5;
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(534, 101);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(76, 8);
            this.guna2Panel4.TabIndex = 98;
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.CheckedState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.CustomImages.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton4.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.DimGray;
            this.guna2CircleButton4.HoverState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Location = new System.Drawing.Point(496, 87);
            this.guna2CircleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.ShadowDecoration.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Size = new System.Drawing.Size(34, 31);
            this.guna2CircleButton4.TabIndex = 97;
            this.guna2CircleButton4.Text = "4";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(408, 101);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(76, 8);
            this.guna2Panel3.TabIndex = 96;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.DimGray;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(370, 87);
            this.guna2CircleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(34, 31);
            this.guna2CircleButton3.TabIndex = 95;
            this.guna2CircleButton3.Text = "3";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2Panel2.Location = new System.Drawing.Point(282, 101);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(76, 8);
            this.guna2Panel2.TabIndex = 94;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2CircleButton2.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(244, 87);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(34, 31);
            this.guna2CircleButton2.TabIndex = 93;
            this.guna2CircleButton2.Text = "2";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2Panel1.Location = new System.Drawing.Point(156, 101);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(76, 8);
            this.guna2Panel1.TabIndex = 92;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(118, 87);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(34, 31);
            this.guna2CircleButton1.TabIndex = 91;
            this.guna2CircleButton1.Text = "1";
            // 
            // targetWeightTxtBox
            // 
            this.targetWeightTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.targetWeightTxtBox.BorderColor = System.Drawing.Color.Gray;
            this.targetWeightTxtBox.BorderRadius = 12;
            this.targetWeightTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.targetWeightTxtBox.DefaultText = "";
            this.targetWeightTxtBox.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.targetWeightTxtBox.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.targetWeightTxtBox.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.targetWeightTxtBox.DisabledState.Parent = this.targetWeightTxtBox;
            this.targetWeightTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.targetWeightTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.targetWeightTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.targetWeightTxtBox.FocusedState.Parent = this.targetWeightTxtBox;
            this.targetWeightTxtBox.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWeightTxtBox.ForeColor = System.Drawing.Color.White;
            this.targetWeightTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.targetWeightTxtBox.HoverState.Parent = this.targetWeightTxtBox;
            this.targetWeightTxtBox.Location = new System.Drawing.Point(173, 399);
            this.targetWeightTxtBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.targetWeightTxtBox.Name = "targetWeightTxtBox";
            this.targetWeightTxtBox.PasswordChar = '\0';
            this.targetWeightTxtBox.PlaceholderForeColor = System.Drawing.Color.Turquoise;
            this.targetWeightTxtBox.PlaceholderText = "";
            this.targetWeightTxtBox.SelectedText = "";
            this.targetWeightTxtBox.ShadowDecoration.Parent = this.targetWeightTxtBox;
            this.targetWeightTxtBox.Size = new System.Drawing.Size(399, 45);
            this.targetWeightTxtBox.TabIndex = 136;
            // 
            // Step2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(731, 594);
            this.Controls.Add(this.targetWeightTxtBox);
            this.Controls.Add(this.calculateMacrosBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weightGoalBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activityLevelBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2CircleButton4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Step2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Step2Form";
            this.Load += new System.EventHandler(this.Step2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button calculateMacrosBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox weightGoalBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox activityLevelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox targetWeightTxtBox;
    }
}