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

        
        public double BMR;
        public StepsForm() 
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
        #region LoadForm
        private void StepsForm_Load(object sender, EventArgs e)
        {
            RoundCorners();
        }

        #endregion

       
       
        private void step1Btn(object sender, EventArgs e)
        {
            try
            {
                int weight = int.Parse(currentWeightTxtBox.Text);
                int height = int.Parse(currentHeightTxtBox.Text);
                int age = int.Parse(ageTxtBox.Text);
                int gender = genderBox.SelectedIndex;

                this.Hide();
                Step2Form step2 = new Step2Form(weight, height, age, gender);
                step2.Show();
                step2.RoundCorners();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
