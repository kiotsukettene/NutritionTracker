using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace NutritionTracker
{
    public partial class Signup : Form
    {
        DBConnection myCon = new DBConnection();
        FailedMessage fm = new FailedMessage();
      
        
        public Signup()
        {
            InitializeComponent();
            RoundCorners();
            firstNameTxtBox.KeyDown += new KeyEventHandler(firstNameTxtBox_KeyDown);
            lastNameTxtBox.KeyDown += new KeyEventHandler(lastNameTxtBox_KeyDown);
            userNameTxtBox.KeyDown += new KeyEventHandler(userNameTxtBox_KeyDown);
            passwordTxtBox.KeyDown += new KeyEventHandler(passwordTxtBox_KeyDown);
            confirmTxtBox.KeyDown += new KeyEventHandler(confirmTxtBox_KeyDown);
        }
        #region Exit and Min Button
        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
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
        public void SignUp()
        {
            try
            {
                string firstname = firstNameTxtBox.Text;
                string lastname = lastNameTxtBox.Text;
                string username = userNameTxtBox.Text.ToLower();
                string password = passwordTxtBox.Text;
                string confirmPass = confirmTxtBox.Text;

                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                firstname = textInfo.ToTitleCase(firstname.ToLower());
                lastname = textInfo.ToTitleCase(lastname.ToLower());

                if (password != confirmPass)
                {
                    fm.Show();
                    fm.failedLbl.Text  = ("Password doesn't match. Please re-enter");
                    return;
                }
                myCon.openCon();
                string checkUsernameQuery = "SELECT COUNT(*) FROM `user` WHERE `username` = @username";
                MySqlCommand checkUsernameCmd = new MySqlCommand(checkUsernameQuery, myCon.getCon());
                checkUsernameCmd.Parameters.AddWithValue("@username", username);
                int count = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());

                if (count > 0)
                {
                    userNameTxtBox.Text = "";
                    userNameTxtBox.PlaceholderText = "Username already exist";
                    userNameTxtBox.PlaceholderForeColor = Color.Red;
                    userNameTxtBox.BorderColor = Color.Red;
                    
                }
                else
                {
                    if (firstname == "" || lastname == "" || username == "" || password == "" || confirmPass == "")
                    {
                        fm.Show();
                        fm.failedLbl.Text = "All fields are required!";
                        
                        
                    }
                    else {
                        string query = "INSERT INTO `user`(`firstname`, `lastname`, `username`, `password`) VALUES (@firstname, @lastname, @username, @password)";
                        MySqlCommand cmd = new MySqlCommand(query, myCon.getCon());
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            
                                loginForm login = new loginForm();
                                login.Show();
                                this.Dispose();
                            
                        }
                        else
                        {
                            fm.Show();
                            fm.failedLbl.Text = "Error signing up!";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            finally
            {
                myCon.closeCon();
            }
        }

        private void loginBtn(object sender, EventArgs e)
        {
            SignUp();
            
          
            
        }

        private void showBtn(object sender, EventArgs e)
        {
            if (passwordTxtBox.UseSystemPasswordChar)
            {
                passwordTxtBox.UseSystemPasswordChar = false;
                passwordTxtBox.Font = new Font("Poppins", 10);
                showBox.Image = Properties.Resources.showPassword;
            }
            else
            {
                passwordTxtBox.UseSystemPasswordChar = true;
                passwordTxtBox.Font = new Font("Poppins", 6);
                showBox.Image = Properties.Resources.hidePassword;
            }
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            passwordTxtBox.PlaceholderText = "";
        }

        private void userNameTxtBox_Enter(object sender, EventArgs e)
        {
            userNameTxtBox.BorderColor = Color.Gray;
            userNameTxtBox.PlaceholderText = "Username";
            userNameTxtBox.PlaceholderForeColor = Color.White;
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
      
            loginForm login = new loginForm();
            login.Show();
            this.Dispose();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miniBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void firstNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter letters only.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lastNameTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter letters only.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void firstNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUp();
                
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }

        private void lastNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUp();
               
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }

        private void userNameTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUp();
                
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }

        private void passwordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUp();
               
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }

        private void confirmTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUp();
         
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }
    }
}
