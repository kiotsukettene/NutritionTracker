using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
    public partial class Step4Macros : Form
    {
        DBConnection myCon = new DBConnection();
        MainForm main = new MainForm();
        Personalization personalize = new Personalization();
        SuccessMessage sm = new SuccessMessage();
        FailedMessage fm = new FailedMessage();
     
        public int TDEE;
        public int carbs;
        public int calories;
        public int protein;
        public int fat;
        public int weight;
        public int height;
        public int age;
        public int gender;
        public double carbspercentage;
        public double proteinpercentage;
        public double fatpercentage;
        public int targetWeight;
        public string username;
        public int sleep;
        public int water;
      
        public Step4Macros(int tDEE, int carbs, int protein, int fat, double carbspercentage, double proteinpercentage, double fatpercentage, int targetWeight, int weight, string username)
        {
            InitializeComponent();
           
            TDEE = tDEE;
            this.carbs = carbs;
            this.protein = protein;
            this.fat = fat;
            this.carbspercentage = carbspercentage;
            this.proteinpercentage = proteinpercentage;
            this.fatpercentage = fatpercentage;
            this.targetWeight = targetWeight;
            this.weight = weight;
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

        public void InsertHealthData()
        {
            try
            {
                myCon.openCon();
                sleep = int.Parse(sleepBox.Text);
                water = int.Parse(waterBox.Text);
                string username = this.username;

                string healthQuery = "INSERT INTO user_lifestyle (user_id, water, sleep) " +
                     "SELECT user.id, @water, @sleep FROM user WHERE user.username = @username";
                MySqlCommand cmd = new MySqlCommand(healthQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@water", water);
                cmd.Parameters.AddWithValue("@sleep", sleep);
                cmd.Parameters.AddWithValue("@username", username);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    
                   
                }
                else
                {
                    fm.Show();
                    fm.failedLbl.Text = "Failed";
                    
                }
                myCon.closeCon();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
           

        }
        public void DataFilled()
        {
            try
            {
                myCon.openCon();
                string successQuery = "UPDATE user SET data_filled = 1 WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(successQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);

                int rows = cmd.ExecuteNonQuery();
                myCon.closeCon();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void SelectData()
        {
            try
            {
                string username = this.username;
                myCon.openCon();

                string SelectQuery = @"SELECT 
                                
                                    u.user_id,
                                    u.weight,
                                    u.age,
                                    u.gender,
                                    u.weight_goal,
                                    u.target_weight,
                                    m.calories,
                                    m.carbs,
                                    m.fat,
                                    m.protein,
                                    m.carb_percent,
                                    m.fat_percent,
                                    m.protein_percent,
                                    l.water,
                                    l.sleep,
                                    usr.firstname,
                                    usr.lastname
                                FROM 
                                    user_fitnessdata u
                                JOIN 
                                    user_macros m ON u.user_id = m.user_id
                                JOIN 
                                    user_lifestyle l ON u.user_id = l.user_id
                                JOIN 
                                    user usr ON u.user_id = usr.id
                                WHERE 
                                    usr.username = @username;";

                MySqlCommand cmd = new MySqlCommand(SelectQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);

                MySqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        int weight = DR.GetInt32("weight");
                        int age = DR.GetInt32("age");
                        int gender = DR.GetInt32("gender");
                        string weightGoal = DR.GetString("weight_goal");
                        int targetWeight = DR.GetInt32("target_weight");
                        int calories = DR.GetInt32("calories");
                        int carbs = DR.GetInt32("carbs");
                        int fat = DR.GetInt32("fat");
                        int protein = DR.GetInt32("protein");
                        int water = DR.GetInt32("water");
                        int sleep = DR.GetInt32("sleep");
                        string firstname = DR.GetString("firstname");
                        string lastname = DR.GetString("lastname");
                        int cPercent = DR.GetInt32("carb_percent");
                        int fPercent = DR.GetInt32("fat_percent");
                        int pPercent =  DR.GetInt32("protein_percent");

                        main.DashboardRetrieveStepsData(calories, carbs, protein, fat, targetWeight, weight, water, sleep);
                        main.DashboardRetrieveValues(firstname);
                        main.PersonalizationRetrieveData(calories, carbs, protein, fat, targetWeight, weight, age, gender, weightGoal, cPercent, fPercent, pPercent, water, sleep);
                        main.PersonalizationRetrieveUserValues(firstname, lastname, username);
                        main.Show();


                    }
                  
                 
                    
                    this.Hide();
                }
                myCon.closeCon();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
           

        }
        private void step4submitBtn(object sender, EventArgs e)
        {

            if (waterBox.Text == "" || sleepBox.Text == "")
            {
                
                fm.Show();
                fm.failedLbl.Text = "All fields are required!\", \"Invalid Input\"";

            }

            else
            {
                InsertHealthData();
                DataFilled();
                SelectData();

            }


        }

        private void Step4Macros_Load(object sender, EventArgs e)
        {
            waterBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            sleepBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the button click event
                submitLastStep.PerformClick();
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }

        private void waterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sleepBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
