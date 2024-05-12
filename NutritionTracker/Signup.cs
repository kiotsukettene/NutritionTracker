using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NutritionTracker
{
    public partial class Signup : Form
    {
        DBConnection myCon = new DBConnection();
       
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
                myCon.openCon();
                string firstname = firstNameTxtBox.Text;
                string lastname = lastNameTxtBox.Text;
                string username = userNameTxtBox.Text;
                string password = passwordTxtBox.Text;
                string confirmPass = confirmTxtBox.Text;

                if (password != confirmPass)
                {
                    MessageBox.Show("Passwords do not match. Please re-enter.");
                    return; 
                }

                string query = "INSERT INTO `user`(`firstname`, `lastname`, `username`, `password`) VALUES (@firstname, @lastname, @username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, myCon.getCon());
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Successful");

                    myCon.closeCon();
                }
                else
                {
                    Console.WriteLine("Failed to Insert");
                    myCon.closeCon();
                }
            }
           catch(Exception e)
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
            this.Dispose();

            loginForm login = new loginForm();
            login.Show();
            
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
    }
}
