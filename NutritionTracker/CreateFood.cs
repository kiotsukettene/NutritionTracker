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

namespace NutritionTracker
{
    public partial class CreateFood : Form
    {
        DBConnection myCon = new DBConnection();
        
       
        public CreateFood()
        {
            InitializeComponent();
        
        }
        #region TabPanels
        void loadForm(Form panel)
        {
            mainPanel.Controls.Clear();
            panel.TopLevel = false;
            mainPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        #endregion
        public void InsertFood()
        {

            try
            {
                // Validate input
              
                int servingSize =  int.Parse(servingValueBox.Text);
                string servingUnit = servingUnitBox.Text;
                int servingContainer = int.Parse(servingContainerBox.Text);
                int calories = int.Parse(caloriesCreateBox.Text);
                int totalFat = int.Parse(totalFatCreateBox.Text);
                int saturated = int.Parse(saturatedCreateBox.Text);
                int trans = int.Parse(transCreateBox.Text);
                int poly = int.Parse(polyCreateBox.Text);
                int mono = int.Parse(monoCreateBox.Text);
                int sodium = int.Parse(sodiumCreateBox.Text);
                int potassium = int.Parse(potassiumCreateBox.Text);
                int totalCarbs = int.Parse(totalCarbCreateBox.Text);
                int fiber = int.Parse(fiberCreateBox.Text);
                int sugar = int.Parse(sugarCreateBox.Text);
                int cholesterol = int.Parse(cholesterolBox.Text);
                int protein = int.Parse(proteinCreateBox.Text);
                int vitA = int.Parse(vitABox.Text);
                int vitC = int.Parse(vitCBox.Text);
                int iron = int.Parse(ironBox.Text);
                int calcium = int.Parse(calciumBox.Text);


                string brandName = brandTxtBox.Text;
                string foodDescription = foodDescTxtBox.Text;
               
                string username = label43.Text;
                
                myCon.openCon();
                string checkUserQuery = "SELECT COUNT(*) FROM user WHERE username = @username";
                MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, myCon.getCon());
                checkUserCmd.Parameters.AddWithValue("@username", username);
                int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                if (userCount == 0)
                {
                    MessageBox.Show("Username does not exist.");
                    return;
                }
                else
                {
                    string insertFoodQuery = @"INSERT INTO `user_personalfood` (user_id, `brand`, `food_desc`, `serving_size`, `serving_unit`, `serving_container`, `calories`, `total_fat`, `saturated`, `trans`, `poly`, `mono`, `sodium`, `potassium`, `total_carbs`, `dietary_fiber`, `sugars`, `cholesterol`, `protein`, `vitamin_a`, `vitamin_c`, `calcium`, `iron`) 
                               SELECT user.id, @brand, @food_desc, @serving_size, @serving_unit, @serving_container, @calories, @total_fat, @saturated, @trans, @poly, @mono, @sodium, @potassium, @total_carbs, @dietary_fiber, @sugars, @cholesterol, @protein, @vitamin_a, @vitamin_c, @calcium, @iron 
                               FROM user WHERE user.username = @username;";
                    MySqlCommand insertFoodCmd = new MySqlCommand(insertFoodQuery, myCon.getCon());
                    insertFoodCmd.Parameters.Clear();
                    insertFoodCmd.Parameters.AddWithValue("@brand", brandName);
                    insertFoodCmd.Parameters.AddWithValue("@food_desc", foodDescription);
                    insertFoodCmd.Parameters.AddWithValue("@serving_size", servingSize);
                    insertFoodCmd.Parameters.AddWithValue("@serving_unit", servingUnit);
                    insertFoodCmd.Parameters.AddWithValue("@serving_container", servingContainer);
                    insertFoodCmd.Parameters.AddWithValue("@calories", calories);
                    insertFoodCmd.Parameters.AddWithValue("@total_fat", totalFat);
                    insertFoodCmd.Parameters.AddWithValue("@saturated", saturated);
                    insertFoodCmd.Parameters.AddWithValue("@trans", trans);
                    insertFoodCmd.Parameters.AddWithValue("@poly", poly);
                    insertFoodCmd.Parameters.AddWithValue("@mono", mono);
                    insertFoodCmd.Parameters.AddWithValue("@sodium", sodium);
                    insertFoodCmd.Parameters.AddWithValue("@potassium", potassium);
                    insertFoodCmd.Parameters.AddWithValue("@total_carbs", totalCarbs);
                    insertFoodCmd.Parameters.AddWithValue("@dietary_fiber", fiber);
                    insertFoodCmd.Parameters.AddWithValue("@sugars", sugar);
                    insertFoodCmd.Parameters.AddWithValue("@cholesterol", cholesterol);
                    insertFoodCmd.Parameters.AddWithValue("@protein", protein);
                    insertFoodCmd.Parameters.AddWithValue("@vitamin_a", vitA);
                    insertFoodCmd.Parameters.AddWithValue("@vitamin_c", vitC);
                    insertFoodCmd.Parameters.AddWithValue("@calcium", calcium);
                    insertFoodCmd.Parameters.AddWithValue("@iron", iron);
                    insertFoodCmd.Parameters.AddWithValue("@username", username);

                    int rows = insertFoodCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                    MessageBox.Show("Insert Successful");
                    brandTxtBox.Text = "";
                    foodDescTxtBox.Text = "";
                    servingValueBox.Text = "";
                    servingUnitBox.Text = "";
                    servingContainerBox.Text = "";
                    caloriesCreateBox.Text = "";
                    totalFatCreateBox.Text = "";
                    saturatedCreateBox.Text = "";
                    transCreateBox.Text = "";
                    polyCreateBox.Text = "";
                    monoCreateBox.Text = "";
                    sodiumCreateBox.Text = "";
                    potassiumCreateBox.Text = "";
                    totalCarbCreateBox.Text = "";
                    fiberCreateBox.Text = "";
                    sugarCreateBox.Text = "";
                    cholesterolBox.Text = "";
                    proteinCreateBox.Text = "";
                    vitABox.Text = "";
                    vitCBox.Text = "";
                    ironBox.Text = "";
                    calciumBox.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("Insert not successful");
                    }

                    myCon.closeCon();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                myCon.closeCon();
            }
        }

        private void insertFoodBtn(object sender, EventArgs e)
        {
            InsertFood();
        }
    }
}
