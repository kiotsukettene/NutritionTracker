using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
    public partial class MainForm : Form
    {
        Dashboard dash = new Dashboard();
        Personalization personalize = new Personalization();
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
            dash.targetWeightLabel.Text = targetWeight.ToString() + " kg";
            dash.weightLbl.Text = weight.ToString() + " kg";
            dash.waternum.Text = water.ToString();
            dash.sleepNum.Text = sleep.ToString();
            dash.calRemain.Text = TDEE.ToString();
            dash.proteinRemain.Text = protein.ToString();
            dash.carbRemain.Text = carbs.ToString();
        }
         public void PersonalizationRetrieveData(int TDEE, int carbs, int protein, int fat, int targetWeight, int weight, int age, int gender, string weightGoal)
         {
            personalize.pCalLabel.Text = TDEE.ToString();
            personalize.pCarbLabel.Text = carbs.ToString();
            personalize.pProteinLabel.Text = protein.ToString();
            personalize.pFatLabel.Text = fat.ToString();
            personalize.personAgeTxtBox.Text = age.ToString() + " years old"; 
            personalize.personWeightTxtBox.Text = weight.ToString() + " kg";
            personalize.personGoal2TxtBox.Text = weightGoal;
            personalize.personTargetWeight.Text = targetWeight.ToString() + " kg";

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
            personalize.personNameTxtBox.Text = firstname + " " + lastname;
            personalize.personUserNTxtBox.Text = username;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            RoundCorners();
            loadForm(dash);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            loadForm(dash);
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
            loadForm(new FoodDiary());
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
    }
}
