using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NutritionTracker
{
    public partial class Step2Form : Form
    {
        DBConnection myCon = new DBConnection();
       public int activityLevel { get; set; }
       public int weightGoal { get; set; }
        public int targetWeightGoal { get; set; }
        public int BMR;
        public int TDEE;
        public int carbs;
        public int calories;
        public int protein;
        public int fat;
        public int weight;
        public int height;
        public int age;
        public int gender;
        public double carbsPercentage;
        public double proteinPercentage;
        public double fatPercentage;
        public string username;





        public Step2Form(int weight, int height, int age, int gender, string username)
        {
            InitializeComponent();
            this.weight = weight;
            this.height = height;
            this.age = age;
            this.gender = gender;
            this.username = username;

           
        }
        #region RoundForm
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
        public void InsertUserData()
        {
           try
            {
                int weightData = this.weight;
                int heightData = this.height;
                int ageData = this.age;
                int genderData = this.gender;
                string activitylvlData = activityLevelBox.Text;
                string weightGoalData = weightGoalBox.Text;
                int targetWeightData = int.Parse(targetWeightTxtBox.Text);
                string username = this.username;

                myCon.openCon();


                string stepsDataQuery = "INSERT INTO user_fitnessdata (user_id, weight, height, age, gender, activity_level, weight_goal, target_weight)\r\nSELECT user.id, @weight, @height, @age, @gender, @activity_level, @weight_goal, @target_weight\r\nFROM user\r\nWHERE user.username =@username;";

                MySqlCommand cmd = new MySqlCommand(stepsDataQuery, myCon.getCon());

                cmd.Parameters.AddWithValue("@weight", weightData);
                cmd.Parameters.AddWithValue("@height", heightData);
                cmd.Parameters.AddWithValue("@age", ageData);
                cmd.Parameters.AddWithValue("@gender", genderData);
                cmd.Parameters.AddWithValue("@activity_level", activitylvlData);
                cmd.Parameters.AddWithValue("@weight_goal", weightGoalData);
                cmd.Parameters.AddWithValue("@target_weight", targetWeightData);
                cmd.Parameters.AddWithValue("@username", username);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Insert Successfuly");
                    
                }
                else
                {
                    MessageBox.Show("Error Insert");
                   
                }
                myCon.closeCon();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }
        public void CalculateBMR()
        {
            try
            {
               
                switch (gender)
                {
                    case 0:
                        BMR = (int)((10 * weight) + (6.25 * height) - (5 * age) + 5);
                        break;
                    case 1:
                        BMR = (int)((10 * weight) + (6.25 * height) - (5 * age) - 161);
                        break;

                }

              

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }


        }
        public void CalculateTDEE()
        {
            try
            {
                activityLevel = activityLevelBox.SelectedIndex;
                double activityFactor = 1.2;
                

                switch (activityLevel)
                {
                    case 0:
                        activityFactor = 1.2;
                        break;
                    case 1:
                        activityFactor = 1.375;
                        break;
                    case 2:
                        activityFactor = 1.55;
                        break;
                    case 3:
                        activityFactor = 1.725;
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
                TDEE = (int)(BMR * activityFactor);
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public void WeightGoal()
        {
            try
            {
                weightGoal = weightGoalBox.SelectedIndex;
                int weightLoss = 500;
                int weightGain = 250;
                switch (weightGoal)
                {
                    case 0:
                        TDEE -= weightLoss;
                        break;
                    case 1:
                        TDEE += weightGain;
                        break;
                    case 2:
                       TDEE = TDEE;
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:" + e);
            }

        }
        public void CalculatePercentage()
        {
            try
            {
                carbsPercentage = 50;
               
                carbs = (int)((carbsPercentage/100) * TDEE) / 4;

                proteinPercentage = 25;
                protein = (int)((proteinPercentage/100) * TDEE) / 4;

                fatPercentage = 25;
                fat = (int)((fatPercentage / 100)  * TDEE) / 9;
            }
            catch (Exception e )
            {
                Console.WriteLine("Error: " + e);
            }
        }
        
       
        private void step2nxtBtn(object sender, EventArgs e)
        {

            if (activityLevelBox.Text == "" || weightGoalBox.Text == "" || targetWeightTxtBox.Text == "")
            {
                MessageBox.Show("All fields are required!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                CalculateBMR();
                CalculateTDEE();
                WeightGoal();
                CalculatePercentage();
                InsertUserData();
                this.Hide();

                int targetWeight = int.Parse(targetWeightTxtBox.Text);
                Step3Macros step3 = new Step3Macros(TDEE, carbs, protein, fat, carbsPercentage, proteinPercentage, fatPercentage, targetWeight, weight, username);
                step3.calorieLabel.Text = TDEE.ToString();
                step3.carbsLabel.Text = carbs.ToString();
                step3.proteinLabel.Text = protein.ToString();
                step3.fatsLabel.Text = fat.ToString();
                step3.carbPercent.Text = carbsPercentage.ToString() + "%";
                step3.proteinPercent.Text = proteinPercentage.ToString() + "%";
                step3.fatPercent.Text = fatPercentage.ToString() + "%";
                step3.RoundCorners();
                step3.Show();

            }



        }

        private void Step2Form_Load(object sender, EventArgs e)
        {
            RoundCorners();
        }
    }
}
