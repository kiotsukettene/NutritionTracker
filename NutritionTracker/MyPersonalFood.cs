using MySql.Data.MySqlClient;
using Mysqlx.Connection;
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
    
    public partial class MyPersonalFood : Form
    {
        CreateFood create = new CreateFood();
        DBConnection myCon = new DBConnection();
        public string username;
        public MyPersonalFood()
        {
            InitializeComponent();
            
           
        }
        #region TabPanels
        void loadForm(Form panel)
        {
            nutritionFactsPanel.Controls.Clear();
            panel.TopLevel = false;
            nutritionFactsPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        #endregion
        private void DynamicPersonalFoodList()
        {
            FoodListPanel.Controls.Clear();

            PersonalFoodControl[] foodList = new PersonalFoodControl[5];

            string[] foodDescription = new string[5] { "Chicken Breast Nuggets", "Chicken Nuggets", "Chocolate Ice Cream Cone", "Nutribun - Carrots", "Chicken Breast" };
            string[] brandName = new string[5] { "Purefoods", "STAR", "Cornetto", "PanSarap", "Magnolia" };
            int[] servings = new int[5] { 4, 4, 1, 1, 100 };
            int[] calories = new int[5] { 113, 99, 120, 250, 15 };

            for (int i = 0;  i < foodList.Length; i++)
            {
                foodList[i] = new PersonalFoodControl();

                foodList[i].FoodDescription = foodDescription[i];
                foodList[i].BrandName = brandName[i];
                foodList[i].ServingSize = servings[i];
                foodList[i].Calories = calories[i];

                FoodListPanel.Controls.Add(foodList[i]);
            }
        }

        //public void FoodSelection()
        //{
        //    try
        //    {
        //        myCon.openCon();

        //        username = usernameLbl.Text;
        //        string selectFoodQuery = @"SELECT user_personalfood.user_id,  user_personalfood.brand,  user_personalfood.food_desc,  user_personalfood.serving_size,  user_personalfood.calories
        //                           FROM user_personalfood
        //                           JOIN user ON user.id = user_personalfood.user_id
        //                           WHERE user.username = @username;";

        //        MySqlCommand selectCmd = new MySqlCommand(selectFoodQuery, myCon.getCon());
        //        selectCmd.Parameters.AddWithValue("@username", username);

        //        MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
        //        DataTable dataTable = new DataTable();
        //        adapter.Fill(dataTable);

        //        // Clear any existing controls in the panel before adding new ones
        //        FoodListPanel.Controls.Clear();

        //        int rowCount = dataTable.Rows.Count;
        //        if (rowCount > 0)
        //        {
        //            PersonalFoodControl[] foodList = new PersonalFoodControl[rowCount];

        //            for (int i = 0; i < foodList.Length; i++)
        //            {
        //                foodList[i] = new PersonalFoodControl
        //                {
        //                    FoodDescription = dataTable.Rows[i]["food_desc"].ToString(),
        //                    BrandName = dataTable.Rows[i]["brand"].ToString(),
        //                    ServingSize = (int)(dataTable.Rows[i]["serving_size"]),
        //                    Calories = (int)(dataTable.Rows[i]["calories"])
        //                };

        //                // Add the control to the panel
        //                FoodListPanel.Controls.Add(foodList[i]);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No food items found for the specified user.");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error: " + e.Message);
        //    }
        //    finally
        //    {
        //        // Ensure the connection is closed properly
        //        myCon.closeCon();
        //    }
        //}

        public void FoodSelection(string username)
        {
            try
            {
                username = usernameLbl.Text;
                myCon.openCon();
               
                string checkUserQuery = "SELECT id FROM user WHERE username = @username";
                MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, myCon.getCon());
                checkUserCmd.Parameters.AddWithValue("@username", username);
                object userId = checkUserCmd.ExecuteScalar();

                if (userId == null)
                {
                    MessageBox.Show("Username does not exist.");
                    myCon.closeCon();
                    return;
                }

                string selectFoodQuery = @"SELECT user.id, brand, food_desc, serving_size, calories  FROM user_personalfood
                                  JOIN user ON user.id = user_personalfood.user_id
                                 WHERE user.username = @username;";

                MySqlCommand selectCmd = new MySqlCommand(selectFoodQuery, myCon.getCon());
               
                selectCmd.Parameters.AddWithValue("@username", username);

                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int rowCount = dataTable.Rows.Count;
                if (rowCount != 0)
                {
                    PersonalFoodControl[] foodList = new PersonalFoodControl[rowCount];

                    for (int i = 0; i < rowCount; i++)
                    {
                        foodList[i] = new PersonalFoodControl();

                        foodList[i].FoodDescription = dataTable.Rows[i]["food_desc"].ToString();
                        foodList[i].BrandName = dataTable.Rows[i]["brand"].ToString(); ;
                        foodList[i].ServingSize = (int)dataTable.Rows[i]["serving_size"];
                        foodList[i].Calories = ((int)dataTable.Rows[i]["calories"]);

                        FoodListPanel.Controls.Add(foodList[i]);
                    }

                    
                }
                else
                {
                    MessageBox.Show("Error selection");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message);
            }





        }
        private void MyPersonalFood_Load(object sender, EventArgs e)
        {
            FoodSelection(username);
            
        }

        private void createFood(object sender, EventArgs e)
        {
            loadForm(create);
            create.label43.Text = usernameLbl.Text;
            
            
        }
    }
}
