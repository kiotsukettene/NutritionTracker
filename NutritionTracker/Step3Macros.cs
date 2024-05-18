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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NutritionTracker
{

  
    public partial class Step3Macros : Form
    {
        DBConnection myCon = new DBConnection();
        FailedMessage fm = new FailedMessage();
        SuccessMessage sm = new SuccessMessage();

        private int TDEE;
        private int carbs;
        private int protein;
        private int fat;
        private int targetWeight;
        private int weight;
        private double carbspercentage;
        private double proteinpercentage;
        private double fatpercentage;
        private string username;

        public Step3Macros(int tDEE, int carbs, int protein, int fat, double carbspercentage, double proteinpercentage, double fatpercentage, int targetWeight, int weight, string username)
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
        public void InsertMacros()
        {
            try
            {
                myCon.openCon();

                int totalCalories = TDEE;
                int carbsData = this.carbs;
                int proteinData = this.protein;
                int fatData = this.fat;
                string username = this.username;
                string macroQuery = "INSERT into user_macros (user_id, calories, carbs, fat, protein)" +
                    "SELECT user.id, @calories, @carbs, @fat, @protein FROM user WHERE user.username=@username";
                MySqlCommand cmd = new MySqlCommand(macroQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@calories", totalCalories);
                cmd.Parameters.AddWithValue("@carbs", carbsData);
                cmd.Parameters.AddWithValue("@fat", fatData);
                cmd.Parameters.AddWithValue("@protein", proteinData);
                cmd.Parameters.AddWithValue("@username", username);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0 )
                {
                    
                }
                else
                {
                    fm.Show();
                    fm.failedLbl.Text = "Error";

                }
                myCon.closeCon();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                myCon.closeCon();
            }
        }
        private void step3nxtBtn(object sender, EventArgs e)
        {
            this.Dispose();

            Step4Macros step4 = new Step4Macros(TDEE, carbs, protein, fat, carbspercentage, proteinpercentage, fatpercentage, targetWeight, weight, username);
            InsertMacros();

            step4.Show();
            step4.RoundCorners();
        }

        private void Step3Macros_Load(object sender, EventArgs e)
        {
           
        }
    }
}
