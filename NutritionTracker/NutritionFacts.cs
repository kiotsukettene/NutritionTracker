using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static Mysqlx.Datatypes.Scalar.Types;

namespace NutritionTracker
{
    public partial class NutritionFacts : Form
    {
        DBConnection myCon = new DBConnection();
        FailedMessage fm = new FailedMessage();
        SuccessMessage sm = new SuccessMessage();
        warningMessage wm = new warningMessage();

        private double servings, cals, carbs, fats, proteins;
        public NutritionFacts()
        {
            InitializeComponent();
               
        }
        FoodDiary fd = new FoodDiary();
        #region TabPanels
        //void loadForm(Form panel)
        //{
        //    mainPanel.Controls.Clear();
        //    panel.TopLevel = false;
        //    mainPanel.Controls.Add(panel);
        //    panel.Dock = DockStyle.Fill;
        //    panel.Show();
        //}
        #endregion
        public void nutritionChart()
        {
            try
            {
                string fd = foodName.Text;
                myCon.openCon();

                string selectMacros = "SELECT carbs, total_fat, protein FROM user_personalfood WHERE food_desc = @food_desc";

                MySqlCommand cmd = new MySqlCommand(selectMacros, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@food_desc", fd);

                DataTable dt = new DataTable();
                MySqlDataAdapter sqladp = new MySqlDataAdapter(cmd);
                sqladp.Fill(dt);
                myCon.closeCon();

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    double carbs = Convert.ToDouble(row["carbs"]);
                    double fat = Convert.ToDouble(row["total_fat"]);
                    double protein = Convert.ToDouble(row["protein"]);

                    // Clear existing points
                    chart1.Series["Series1"].Points.Clear();

                    // Add new points
                    chart1.Series["Series1"].Points.AddXY("Protein", protein);
                    chart1.Series["Series1"].Points.AddXY("Fat", fat);
                    chart1.Series["Series1"].Points.AddXY("Protein", carbs);

                    // Update the chart
                    chart1.DataBind();
                }
                else
                {
                    fm.Show();
                    fm.failedLbl.Text = "No data found for the specified food description.";
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                myCon.closeCon();
            }

        }

        public void UpdateBasedOnServings()
        {
            myCon.openCon();
            string username = nfUsername.Text;
            string foodname = foodName.Text;


            string updateValuesQuery = @"SELECT serving_size, serving_unit, calories, carbs, total_fat, protein
                                        FROM user_personalfood
                                        JOIN user ON user.id = user_personalfood.user_id
                                        WHERE user.username = @username AND user_personalfood.food_desc = @food_desc";

            MySqlCommand cmd = new MySqlCommand(updateValuesQuery, myCon.getCon());
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@food_desc", foodname);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    servings = dr.GetInt32("serving_size");
                    string unit = dr.GetString("serving_unit");
                    cals = dr.GetInt32("calories");
                    carbs = dr.GetInt32("carbs");
                    fats = dr.GetInt32("total_fat");
                    proteins = dr.GetInt32("protein");



                    //servingsBox.Text = servings.ToString();
                    unitBox.Text = unit.ToString();
                    //calLabel.Text = cals.ToString();
                    //carbLabel.Text = carbs.ToString();
                    //fatLabel.Text = fats.ToString();
                    //totalProteinLabel.Text = proteins.ToString();

                    double servingSize = double.Parse(servingsBox.Text);
                    double factor = servingSize / servings;



                    int updatedCal = (int)(cals * factor);
                    int updatedFat = (int)(fats * factor);
                    int updatedCarb = (int)(carbs * factor);
                    int updatedProtein = (int)(proteins * factor);

                    calLabel.Text = updatedCal.ToString();
                    fatLabel.Text = updatedFat.ToString();
                    carbLabel.Text = updatedCarb.ToString();
                    totalProteinLabel.Text = updatedProtein.ToString();

                }
                dr.Close();
                myCon.closeCon();
            }


        }
        public void InsertMyFood()
        {
            
            try
            {
                myCon.openCon();
                DateTime date = DateTime.Now;
                string added_at = date.ToString("yyyy-MM-dd");
                string foodname = foodName.Text;
                string username = nfUsername.Text;
                int servingSize = int.Parse(servingsBox.Text);
                string unit = (unitBox.Text);
                int cal = int.Parse(calLabel.Text);
                int carbs = int.Parse(carbLabel.Text);
                int fat = int.Parse(fatLabel.Text);
                int protein = int.Parse(totalProteinLabel.Text);
                string meal = mealBox.Text;
                string insertCreatedFoodQuery = @"INSERT INTO `user_food_diary`(`user_id`, `food_name`, `serving_size`, `serving_unit`, `meal`,     `calories`, `carbs`, `fat`, `protein`, `added_at`)
                                    SELECT user.id, @food_name, @serving_size, @serving_unit, @meal, @calories, @carbs, @fat, @protein, @added_at
                                    FROM user WHERE user.username = @username;";
                MySqlCommand cmd = new MySqlCommand(insertCreatedFoodQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@food_name", foodname);
                cmd.Parameters.AddWithValue("@serving_size", servingSize);
                cmd.Parameters.AddWithValue("@serving_unit", unit);
                cmd.Parameters.AddWithValue("@meal", meal);
                cmd.Parameters.AddWithValue("@calories", cal);
                cmd.Parameters.AddWithValue("@carbs", carbs);
                cmd.Parameters.AddWithValue("@fat", fat);
                cmd.Parameters.AddWithValue("@protein", protein);
                cmd.Parameters.AddWithValue("@added_at", added_at);
                cmd.Parameters.AddWithValue("@username", username);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    sm.Show();
                    sm.successLbl.Text = "Food is inserted into your food diary";
                }
                else
                {
                    fm.Show();
                    fm.failedLbl.Text = "Insert failed";
                }
                myCon.closeCon();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }

        private void updateValues_Click(object sender, EventArgs e)
        {
            UpdateBasedOnServings();
        }
            


        private void foodName_TextChanged(object sender, EventArgs e)
        {
            nutritionChart();
        }

        private void addToFDBtn_Click(object sender, EventArgs e)
        {
            InsertMyFood();
        }

        private void servingsBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
