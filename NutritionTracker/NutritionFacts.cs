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
        public MyPersonalFood PersonalFoodForm { get; set; }
       

        private int food_id;
        private double servings, cals, carbs, fats, proteins;
        public NutritionFacts()
        {
            InitializeComponent();
            dbDateTime.Value = DateTime.Now;
               
        }
       
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
            try
            {
                // Open the database connection
                myCon.openCon();

                // Get the username and food name from text boxes
                string username = nfUsername.Text;
                string foodname = foodName.Text;

                // Define the query to select the food details
                string updateValuesQuery = @"SELECT user_personalfood.id, serving_size, serving_unit, calories, carbs, total_fat, protein
                                     FROM user_personalfood
                                     JOIN user ON user.id = user_personalfood.user_id
                                     WHERE user.username = @username AND user_personalfood.food_desc = @food_desc";

                // Create a command object
                MySqlCommand cmd = new MySqlCommand(updateValuesQuery, myCon.getCon());

                // Clear previous parameters and add new ones
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@food_desc", foodname);

                // Execute the query and get a data reader
                MySqlDataReader dr = cmd.ExecuteReader();

                // Check if any rows are returned
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        // Get the values from the database
                        food_id = dr.GetInt32("id");
                        int servings = dr.GetInt32("serving_size");
                        string unit = dr.GetString("serving_unit");
                        int cals = dr.GetInt32("calories");
                        int carbs = dr.GetInt32("carbs");
                        int fats = dr.GetInt32("total_fat");
                        int proteins = dr.GetInt32("protein");

                       
                        // Update the UI controls with the retrieved values
                        unitBox.Text = unit.ToString();

                        // Parse the serving size from the text box and calculate the factor
                        double servingSize = double.Parse(servingsBox.Text);
                        double factor = servingSize / servings;

                        // Calculate the updated nutritional values
                        int updatedCal = (int)(cals * factor);
                        int updatedFat = (int)(fats * factor);
                        int updatedCarb = (int)(carbs * factor);
                        int updatedProtein = (int)(proteins * factor);

                        // Update the UI controls with the updated values
                        calLabel.Text = updatedCal.ToString();
                        fatLabel.Text = updatedFat.ToString();
                        carbLabel.Text = updatedCarb.ToString();
                        totalProteinLabel.Text = updatedProtein.ToString();
                        chartCal.Text = updatedCal.ToString();
                    }
                }
                else
                {
                    fm.Show();
                    fm.failedLbl.Text = ("No matching food found for the given username and food description.");
                }

                // Close the data reader
                dr.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the operation
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                myCon.closeCon();
            }
        }
        
        public void DeleteMyFood()
        {
            try
            {
                DateTime date = dbDateTime.Value;
                string added_at = date.ToString("yyyy-MM-dd");
                string username = nfUsername.Text;

                myCon.openCon();

                string deleteQuery = @"DELETE user_personalfood
                                    FROM user_personalfood
                                    JOIN user on user.id = user_personalfood.user_id
                                    WHERE user.username = @username AND user_personalfood.id = @food_id;";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, myCon.getCon());
                deleteCmd.Parameters.Clear();
                deleteCmd.Parameters.AddWithValue("@username", username);
                deleteCmd.Parameters.AddWithValue("@food_id", food_id);

                int rows = deleteCmd.ExecuteNonQuery();
                
                if (rows > 0)
                {
                    sm.Show();
                    sm.successLbl.Text = "Deleted Successfully";
                   
               
                }
           

                myCon.closeCon();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
           



        }
        public void InsertMyFood()
        {
            
            try
            {
                myCon.openCon();
                DateTime date = dbDateTime.Value;
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

        private void servingsBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteMyFood();
            this.Hide();
            if (PersonalFoodForm != null)
            {
                PersonalFoodForm.FoodSelection();
                PersonalFoodForm.panel1.Visible = true;
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
            this.Hide();
            PersonalFoodForm.panel1.Visible = true;

        }

        private void servingsBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(servingsBox.Text))
            {
                UpdateBasedOnServings();
               
            }
            
        }
    }
}
