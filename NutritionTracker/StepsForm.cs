using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
    public partial class StepsForm : Form
    {
        FailedMessage fm = new FailedMessage();
        SuccessMessage sm = new SuccessMessage();
    
        public string username { get;set; }
        public double BMR;
        public StepsForm(string  username) 
        {
            InitializeComponent();
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
        #region LoadForm
        private void StepsForm_Load(object sender, EventArgs e)
        {
            RoundCorners();
            currentWeightTxtBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            currentHeightTxtBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            ageTxtBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            genderBox.KeyDown += new KeyEventHandler(comboBox_KeyDown);
        }

        #endregion

       
       
        private void step1Btn(object sender, EventArgs e)
        {
            if (currentWeightTxtBox.Text == "" || currentHeightTxtBox.Text == "" || ageTxtBox.Text == "")
            {
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";

            }
            else if (genderBox.SelectedItem == null)
            {
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
                try
                {

                    int weight = int.Parse(currentWeightTxtBox.Text);
                    int height = int.Parse(currentHeightTxtBox.Text);
                    int age = int.Parse(ageTxtBox.Text);
                    int gender = genderBox.SelectedIndex;

                    this.Hide();
                    Step2Form step2 = new Step2Form(weight, height, age, gender, username);
                    step2.Show();
                    step2.RoundCorners();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
            }
           
        }

        private void currentWeightTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void currentHeightTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ageTxtBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }

        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
                e.SuppressKeyPress = true; // Prevents the "ding" sound when Enter is pressed
            }
        }
    }
}
