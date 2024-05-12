using MySql.Data.MySqlClient;
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
    
    public partial class loginForm : Form
    {
        DBConnection myCon = new DBConnection();
        
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
            try
            {
                string username = loginUserBox.Text;
                string password = loginPassBox.Text;
                string userDisplay = "";
                string fname = "";
                string lname = "";
                myCon.openCon();

                string loginQuery = "SELECT * FROM user WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(loginQuery, myCon.getCon());

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        userDisplay = dataReader.GetString("username");
                        fname = dataReader.GetString("firstname");
                        lname = dataReader.GetString("lastname");
                    }

                   
                    MainForm main = new MainForm();
                    main.RetrieveValues(fname);
                    main.Show();
                }
                dataReader.Close();

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
            Login();
            this.Hide();

           
        }
    }
}
