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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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


            myCon.openCon();
            try
            {
                string brandname = brandTxtBox.Text;
                string foodDesc = foodDescTxtBox.Text;
                int servingSize = int.Parse(servingValueBox.Text);
                string servingUnit = servingUnitBox.Text;
                int servingContainer = int.Parse(servingContainerBox.Text);
                int cal = int.Parse(caloriesCreateBox.Text);
                int carb = int.Parse(totalCarbCreateBox.Text);
                int fat = int.Parse(totalFatCreateBox.Text);
                int protein = int.Parse(totalProteinCreateBox.Text);
                string username = createUserLabel.Text;

                string insertFoodQuery = @"INSERT INTO `user_personalfood`(`user_id`, `brand`, `food_desc`, `serving_size`, `serving_unit`, `serving_container`, `calories`, `carbs`, `total_fat`, `protein`)
                                        SELECT user.id, @brand, @food_desc, @serving_size, @serving_unit, @serving_container, @calories, @carbs, @total_fat, @protein
                                        FROM user
                                        WHERE user.username = @username;";
                MySqlCommand insertCommand = new MySqlCommand(insertFoodQuery, myCon.getCon());

                insertCommand.Parameters.Clear();
                insertCommand.Parameters.AddWithValue("@brand", brandname);
                insertCommand.Parameters.AddWithValue("@food_desc", foodDesc);
                insertCommand.Parameters.AddWithValue("@serving_size", servingSize);
                insertCommand.Parameters.AddWithValue("@serving_unit", servingUnit);
                insertCommand.Parameters.AddWithValue("@serving_container", servingContainer);
                insertCommand.Parameters.AddWithValue("@calories", cal);
                insertCommand.Parameters.AddWithValue("@carbs", carb);
                insertCommand.Parameters.AddWithValue("@total_fat", fat);
                insertCommand.Parameters.AddWithValue("@protein", protein);
                insertCommand.Parameters.AddWithValue("@username", username);

                int rows = insertCommand.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Insert Success");
                    brandTxtBox.Text = "";
                    foodDescTxtBox.Text = "";
                    servingValueBox.Text = "";
                    servingUnitBox.Text = "";
                    servingContainerBox.Text = "";
                    caloriesCreateBox.Text = "";
                    totalCarbCreateBox.Text = "";
                    totalFatCreateBox.Text = "";
                    totalProteinCreateBox.Text = "";
                    
                    myCon.closeCon();
                    MessageBox.Show("Username after insert: " + username);
                   

                }
                else
                {
                    MessageBox.Show("Insert not success");
                }

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

            private void insertFoodBtn(object sender, EventArgs e)
        {
            InsertFood();
            
        }

        private void CreateFood_Load(object sender, EventArgs e)
        {
           
            
        }

        private void label43_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
