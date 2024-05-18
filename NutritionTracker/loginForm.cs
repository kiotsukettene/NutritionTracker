using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NutritionTracker
{
    
    public partial class loginForm : Form
    {
        public string username;
        DBConnection myCon = new DBConnection();
        MainForm main = new MainForm();
        FailedMessage fm = new FailedMessage();
        SuccessMessage sm = new SuccessMessage();
        warningMessage wm = new warningMessage();
        public loginForm()
        {
            InitializeComponent();
           
           
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

        #region Min and Close
        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        #endregion
        private void loginForm_Load(object sender, EventArgs e)
        {
            RoundCorners();
        
        }

        public void Login()

        {
            
            username = loginUserBox.Text.Trim();
            string password = loginPassBox.Text.Trim();

            if (username == "" || password == "")
            {
                wm.Show();
                wm.warningLbl.Text = "Username and Password required!!";
                return;
            }
            else
            {
                try
                {

                    string userDisplay = "";
                    string fname = "";
                    string lname = "";
                    myCon.openCon();

                    string loginQuery = "SELECT * FROM user WHERE username=@username AND password=@password";
                    MySqlCommand cmd = new MySqlCommand(loginQuery, myCon.getCon());

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader DR = cmd.ExecuteReader();

                    if (DR.HasRows)
                    {
                        while (DR.Read())
                        {
                            userDisplay = DR.GetString("username");
                            fname = DR.GetString("firstname");
                            lname = DR.GetString("lastname");
                            //int weight = DR.GetInt32("weight");
                            //int targetWeight = DR.GetInt32("target_weight");
                            //int calories = DR.GetInt32("calories");
                            //int carbs = DR.GetInt32("carbs");
                            //int fat = DR.GetInt32("fat");
                            //int protein = DR.GetInt32("protein");
                            //int water = DR.GetInt32("water");
                            //int sleep = DR.GetInt32("sleep");
                           
                            main.DashboardRetrieveValues(fname);
                            main.PersonalizationRetrieveUserValues(fname, lname, userDisplay);
                            
                            //main.RetrieveStepsData(calories, carbs, protein, fat, targetWeight, weight, water, sleep);
                        }
                        
                        DR.Close();

                        
                        string selectQuery = "SELECT data_filled FROM user WHERE username = @username";
                        MySqlCommand selectCmd = new MySqlCommand(selectQuery, myCon.getCon());
                        selectCmd.Parameters.AddWithValue("@username", username);
                        int dataFilled = Convert.ToInt32(selectCmd.ExecuteScalar());

                        
                       if (dataFilled == 1)
                        {
                            string userDataQuery = @"SELECT u.weight, u.age, u.gender, u.weight_goal, u.target_weight, m.calories, m.carbs, m.fat, m.protein, l.water, l.sleep
                                                    FROM user_fitnessdata u
                                                    JOIN user_macros m ON u.user_id = m.user_id
                                                    JOIN user_lifestyle l ON u.user_id = l.user_id
                                                    JOIN user usr ON u.user_id = usr.id
                                                    WHERE usr.username = @username";
                            MySqlCommand userDataCmd = new MySqlCommand(userDataQuery, myCon.getCon());
                            userDataCmd.Parameters.AddWithValue("@username", username);

                            MySqlDataReader dataReader = userDataCmd.ExecuteReader();

                                if (dataReader.HasRows)
                                {
                                    while (dataReader.Read())
                                    {
                                    int weight = dataReader.GetInt32("weight");
                                    int age = dataReader.GetInt32("age");
                                    int gender = dataReader.GetInt32("gender");
                                    string weightGoal = dataReader.GetString("weight_goal");
                                    int targetWeight = dataReader.GetInt32("target_weight");
                                    int calories = dataReader.GetInt32("calories");
                                    int carbs = dataReader.GetInt32("carbs");
                                    int fat = dataReader.GetInt32("fat");
                                    int protein = dataReader.GetInt32("protein");
                                    int water = dataReader.GetInt32("water");
                                    int sleep = dataReader.GetInt32("sleep");


                                    main.DashboardRetrieveStepsData(calories, carbs, protein, fat, targetWeight, weight, water, sleep);
                                    main.PersonalizationRetrieveData(calories, carbs, protein, fat, targetWeight, weight, age, gender, weightGoal, water, sleep);

                                    }
                            
                                dataReader.Close();
                                }
                           
                            main.Show();
                        }
                        else
                        {
                        StepsForm step1 = new StepsForm(username);
                        step1.Show();
                          
                        }
                        this.Hide();

                       
                    }
                    else
                    {
                        wm.Show();
                        wm.warningLbl.Text = "Invalid Username or Password";
                    }

                    myCon.closeCon();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e);
                }
                finally
                {
                    myCon.closeCon();
                }

            }
        }
        

        private void loginShowBtn(object sender, EventArgs e)
        {
            if (loginPassBox.UseSystemPasswordChar)
            {
                loginPassBox.UseSystemPasswordChar = false;
                showPassBox.Image = Properties.Resources.hidePassword;
                loginPassBox.Font = new Font("Poppins", 10);

            }
            else
            {
                loginPassBox.UseSystemPasswordChar = true;
                loginPassBox.Font = new Font("Poppins", 6);
                showPassBox.Image = Properties.Resources.showPassword;
            }
        }

        private void LoginBtn(object sender, EventArgs e)
        {
            string username = loginUserBox.Text;
            string password = loginPassBox.Text;
       
            Login();
            

           
        }

        private void redirectSignForm(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
