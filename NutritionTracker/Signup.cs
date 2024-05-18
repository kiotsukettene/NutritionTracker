using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        SuccessMessage sm = new SuccessMessage();
        warningMessage wm = new warningMessage();

        public Signup()
        {
            InitializeComponent();
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
        public void SignUp()
        {
            try
            {
                
        
                string firstname = firstNameTxtBox.Text;
                string lastname = lastNameTxtBox.Text;
                string username = userNameTxtBox.Text;
                string password = passwordTxtBox.Text;
                string confirmPass = confirmTxtBox.Text;

                if (password != confirmPass)
                {
                    wm.Show();
                    wm.warningLbl.Text  = ("Password doesn't match. Please re-enter");
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
                        wm.Show();
                        wm.warningLbl.Text = "All fields are required!";
                        
                        
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
                            sm.successLbl.Text = "Sign up success!!";
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
                showBox.Image = Properties.Resources.hidePassword;
            }
            else
            {
                passwordTxtBox.UseSystemPasswordChar = true;
                passwordTxtBox.Font = new Font("Poppins", 6);
                showBox.Image = Properties.Resources.showPassword;
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
    }
}
