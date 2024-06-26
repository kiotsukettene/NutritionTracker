﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NutritionTracker
{
    public partial class MainForm : Form
    {
        DBConnection db = new DBConnection();
        Dashboard dash = new Dashboard();
        Personalization personalize = new Personalization();
        CreateFood create = new CreateFood();
        FoodDiary fd = new FoodDiary();
        MyPersonalFood personalFood = new MyPersonalFood();
       
        public MainForm()
        {
            InitializeComponent();
          
        }
        #region Round Corner for Form
        public void RoundCorners()
        {
            int arc = 20;

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();

            // Top Left
            graphicsPath.AddArc(new Rectangle(0, 0, 2 * arc, 2 * arc), 180, 90);

            // Top Right
            graphicsPath.AddArc(new Rectangle(this.Width - 2 * arc, 0, 2 * arc, 2 * arc), -90, 90);

            // Bottom Right
            graphicsPath.AddArc(new Rectangle(this.Width - 2 * arc, this.Height - 2 * arc, 2 * arc, 2 * arc), 0, 90);

            // Bottom Left
            graphicsPath.AddArc(new Rectangle(0, this.Height - 2 * arc, 2 * arc, 2 * arc), 90, 90);

            this.Region = new Region(graphicsPath);
        }
        #endregion
        #region Min and Close btn
        private void minBtn(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region TabPanels
        void loadForm(Form panel)
        {
            mainPanel.Controls.Clear();
            panel.TopLevel = false;
            mainPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        #endregion

        public void DashboardRetrieveValues(string firstname)
        {
            dash.welcomeLabel.Text = $"Hello, {firstname}";
        }

        public void DashboardRetrieveStepsData(int TDEE, int carbs, int protein, int fat, int targetWeight, int weight, int water, int sleep)
        {
            dash.calorieNum.Text = TDEE.ToString();
            dash.carbNum.Text = carbs.ToString();
            dash.proteinNum.Text = protein.ToString();
            dash.fatNum.Text = fat.ToString();
            dash.targetWeightLabel.Text = targetWeight.ToString();
            dash.weightLbl.Text = weight.ToString();
            dash.waternum.Text = water.ToString();
            dash.sleepNum.Text = sleep.ToString();
           
        }
         public void PersonalizationRetrieveData(int TDEE, int carbs, int protein, int fat, int targetWeight, int weight, int age, int gender, string weightGoal, int cPercent, int fPercent, int pPercent,int water, int sleep)
         {
            personalize.pCalLabel.Text = TDEE.ToString();
            personalize.pCarbLabel.Text = carbs.ToString();
            personalize.pProteinLabel.Text = protein.ToString();
            personalize.pFatLabel.Text = fat.ToString();
            personalize.personAgeTxtBox.Text = age.ToString();
            personalize.personWeightTxtBox.Text = weight.ToString();
            personalize.personGoal2TxtBox.Text = weightGoal;
            personalize.personTargetWeight.Text = targetWeight.ToString();
            personalize.waterBox.Text = water.ToString();
            personalize.sleepBox.Text = sleep.ToString();
            personalize.carbsComboBox.Text = cPercent.ToString();
            personalize.fatComboBox.Text = fPercent.ToString(); 
            personalize.proteinComboBox.Text = pPercent.ToString();

            if (gender == 0)
            {
                personalize.personGenderTxtBox.Text = "Male";
            }
            else
            {
                personalize.personGenderTxtBox.Text = "Female";
            }

        }
        public void PersonalizationRetrieveUserValues(string firstname, string lastname, string username)
        {
            personalize.personNameTxtBox.Text = firstname;
            personalize.personLastNTxtBox.Text = lastname;
            personalize.personUserNTxtBox.Text = username;
            usernameLbl.Text = username;   
        }
       
        public void PersonalizationUpdateWeights(int targetWeight, int weight)
        {
            dash.targetWeightLabel.Text = targetWeight.ToString();
            dash.weightLbl.Text = weight.ToString();
        }
        
     
      
        private void MainForm_Load(object sender, EventArgs e)
        {
            RoundCorners();

            dash.dashUsername.Text = usernameLbl.Text;
           
            
            loadForm(dash);
            fd.DisplayFoodDiary();

            dash.chartData();
            dash.RemainingMacros();
            dash.SelectMacros();
            personalFood.usernameLbl.Text = personalize.personUserNTxtBox.Text;
            create.createUserLabel.Text = personalize.personUserNTxtBox.Text;
            fd.fdUsername.Text = personalize.personUserNTxtBox.Text;
          

            db.closeCon();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            fd.DisplayFoodDiary();
            loadForm(dash);
            dash.SelectMacros();
            dash.chartData();
            dash.RemainingMacros();
            dash.dashUsername.Text = usernameLbl.Text;
            dash.welcomeLabel.Text = "Hello, " + personalize.personNameTxtBox.Text;
            dash.targetWeightLabel.Text = personalize.personWeightTxtBox.Text;
            dash.weightLbl.Text = personalize.personTargetWeight.Text;
            dash.calorieNum.Text = personalize.pCalLabel.Text;
            dash.proteinNum.Text = personalize.pProteinLabel.Text;
            dash.fatNum.Text = personalize.pFatLabel.Text;
            dash.carbNum.Text = personalize.pCarbLabel.Text;
            dash.waternum.Text = personalize.waterBox.Text;
            dash.sleepNum.Text = personalize.sleepBox.Text;

    

            calculatorBtn.Image = Properties.Resources.calc_gray;
            this.dashboardBtn.Image = global::NutritionTracker.Properties.Resources.home__1_;
            this.fdBtn.Image = global::NutritionTracker.Properties.Resources.add_gray;
            this.personalizationBtn.Image = global::NutritionTracker.Properties.Resources.settings_gray;
            dashboardBtn.BackColor = System.Drawing.Color.Black;
            fdBtn.BackColor = Color.Transparent;
            personalizationBtn.BackColor = Color.Transparent;
            calculatorBtn.BackColor = Color.Transparent;
        }
          
        private void fdBtn_Click(object sender, EventArgs e)
        {
            loadForm(fd);
            dash.SelectMacros();
            fd.DisplayFoodDiary();
            dash.chartData();
            dash.RemainingMacros();
            fd.fdCal.Text = personalize.pCalLabel.Text;
            fd.fdCarbs.Text = personalize.pCarbLabel.Text;
            fd.fdFat.Text = personalize.pFatLabel.Text;
            fd.fdProtein.Text = personalize.pProteinLabel.Text;
            fd.fdUsername.Text = usernameLbl.Text;
           
           
          
            calculatorBtn.Image = Properties.Resources.calc_gray;
            this.fdBtn.Image = Properties.Resources.add;
            this.dashboardBtn.Image = Properties.Resources.home_gray;
            this.personalizationBtn.Image = Properties.Resources.settings_gray;
            dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            fdBtn.BackColor = System.Drawing.Color.Black;
            personalizationBtn.BackColor = Color.Transparent;
            calculatorBtn.BackColor = Color.Transparent;
        }

        private void personalizationBtn_Click(object sender, EventArgs e)
        {
            loadForm(personalize);
            dash.SelectMacros();

            personalize.carbsComboBox.Text = dash.carbP.Text.ToString();
            personalize.fatComboBox.Text = dash.fatP.Text.ToString();
            personalize.proteinComboBox.Text = dash.proteinP.Text.ToString();
            calculatorBtn.Image = Properties.Resources.calc_gray;
            this.fdBtn.Image = Properties.Resources.add_gray;
            this.dashboardBtn.Image = Properties.Resources.home_gray;
            this.personalizationBtn.Image = Properties.Resources.settings;
            dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            fdBtn.BackColor = System.Drawing.Color.Transparent;
            personalizationBtn.BackColor = Color.Black;
            calculatorBtn.BackColor = Color.Transparent;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            loadForm(personalFood);

            personalFood.FoodSelection();
            personalFood.usernameLbl.Text = usernameLbl.Text;
            create.createUserLabel.Text = personalize.personUserNTxtBox.Text;
            calculatorBtn.Image = Properties.Resources.calc;
            this.fdBtn.Image = Properties.Resources.add_gray;
            this.dashboardBtn.Image = Properties.Resources.home_gray;
            this.personalizationBtn.Image = Properties.Resources.settings_gray;
            dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            fdBtn.BackColor = System.Drawing.Color.Transparent;
            personalizationBtn.BackColor = Color.Transparent;
            calculatorBtn.BackColor = Color.Black;
            
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginForm login = new loginForm();
            login.Show();
        }
    }
}
