using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NutritionTracker
{
    public partial class NutritionFacts : Form
    {
        DBConnection myCon = new DBConnection();

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
                    MessageBox.Show("No data found for the specified food description.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    MessageBox.Show("Insert Success");
                    
                }
                else
                {
                    MessageBox.Show("No way bro, check your query!");
                }
                myCon.closeCon();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
        private void foodName_TextChanged(object sender, EventArgs e)
        {
            nutritionChart();
        }

        private void addToFDBtn_Click(object sender, EventArgs e)
        {
            InsertMyFood();
        }
    }
}
