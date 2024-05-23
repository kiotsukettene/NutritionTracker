using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NutritionTracker
{
    
    public partial class MyPersonalFood : Form
    {
        CreateFood create = new CreateFood();
        DBConnection myCon = new DBConnection();
        NutritionFacts nf = new NutritionFacts();
        FailedMessage fm = new FailedMessage();
        SuccessMessage sm = new SuccessMessage();
        
        
        public string username;
        private double dfCal, dfCarbs, dfFat, dfProtein;
        private int dfServings;
        public MyPersonalFood()
        {
            InitializeComponent();
            nf.PersonalFoodForm = this;
            
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

        public void FoodSelection()
        {
            try
            {
                string username = usernameLbl.Text;
                
                myCon.openCon();
            
                string selectFoodQuery = @"SELECT brand, food_desc, serving_size, serving_unit, calories, carbs, total_fat, protein 
                                    FROM user_personalfood
                                  JOIN user ON user.id = user_personalfood.user_id
                                 WHERE user.username = @username;";

                MySqlCommand selectCmd = new MySqlCommand(selectFoodQuery, myCon.getCon());
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
                selectCmd.Parameters.AddWithValue("@username", username);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                int rowCount = dataTable.Rows.Count;
                if (rowCount != 0)
                {
                    FoodListPanel.Controls.Clear();
                    for (int i = 0; i < rowCount; i++)
                    {

                        PersonalFoodControl foodList = new PersonalFoodControl
                        {
                            FoodDescription = dataTable.Rows[i]["food_desc"].ToString(),
                            BrandName = dataTable.Rows[i]["brand"].ToString(),
                            ServingSize = (int)dataTable.Rows[i]["serving_size"],
                            Calories = ((int)dataTable.Rows[i]["calories"]),
                            ServingUnit = dataTable.Rows[i]["serving_unit"].ToString(),
                            Carbs = (int)dataTable.Rows[i]["carbs"],
                            Fat = (int)dataTable.Rows[i]["total_fat"],
                            Protein = (int)dataTable.Rows[i]["protein"]
                        };
                            FoodListPanel.Controls.Add(foodList);
                            foodList.Click += PersonalFood_Click ;
                        
                            
                        //foodList.Tag = new
                        //{
                        //    ServingUnit = dataTable.Rows[i]["serving_unit"],
                        //    Carbs = (int)dataTable.Rows[i]["carbs"],
                        //    Fat = (int)dataTable.Rows[i]["total_fat"],
                        //    Protein = (int)dataTable.Rows[i]["protein"]
                        //};
                    }

                }

                myCon.closeCon();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message);
            }
        }

        public void PersonalFood_Click(object sender, EventArgs e)
        {
            PersonalFoodControl obj = (PersonalFoodControl)sender;
            loadForm(nf);

            dfCal = obj.Calories;
            dfCarbs = obj.Carbs;
            dfProtein = obj.Protein;
            dfFat = obj.Fat;
            dfServings = obj.ServingSize;

            panel1.Visible = false;
            createFoodBtn.Visible = true;
            nf.nfUsername.Text = usernameLbl.Text;
            nf.foodName.Text = (obj.FoodDescription);
            nf.servingsBox.Text = obj.ServingSize.ToString();
            nf.chartCal.Text = obj.Calories.ToString();
            nf.calLabel.Text = obj.Calories.ToString();
            nf.unitBox.Text = obj.ServingUnit;
            nf.carbLabel.Text = obj.Carbs.ToString();
            nf.fatLabel.Text = obj.Fat.ToString();
            nf.totalProteinLabel.Text = obj.Protein.ToString();
            

            double totalMacronutrients = obj.Carbs + obj.Fat +obj.Protein;

            double proteinPercentage = totalMacronutrients > 0 ? (obj.Protein / totalMacronutrients) * 100 : 0;
            double fatPercentage = totalMacronutrients > 0 ? (obj.Fat / totalMacronutrients) * 100 : 0;
            double carbohydratesPercentage = totalMacronutrients > 0 ? (obj.Carbs/ totalMacronutrients) * 100 : 0;

            nf.fatPercentLbl.Text = $"{fatPercentage.ToString("F2")}% Fat";
            nf.proteinPercentLbl.Text = $"{proteinPercentage.ToString("F2")}% Protein";
            nf.carbPercentLbl.Text = $"{carbohydratesPercentage.ToString("F2")}% Carbs";

        }
        public void InsertCreatedFood()
        {
           
            try
            {
                int servingSize, servingContainer, cal, carb, fat, protein;
                string brandname = brandTxtBox.Text;
                string foodDesc = foodDescTxtBox.Text;
                string servingUnit = servingUnitBox.Text;
                int.TryParse(servingValueBox.Text, out servingSize);
                int.TryParse(servingContainerBox.Text, out servingContainer);
                int.TryParse(caloriesCreateBox.Text, out cal);
                int.TryParse(totalCarbCreateBox.Text, out carb);
                int.TryParse(totalFatCreateBox.Text, out fat);
                int.TryParse(totalProteinCreateBox.Text, out protein);
                if (string.IsNullOrWhiteSpace(brandname) ||
                        string.IsNullOrWhiteSpace(foodDesc) ||
                        string.IsNullOrWhiteSpace(servingUnit)) 
                        
                {
                    fm.Show();
                    fm.failedLbl.Text = fm.failedLbl.Text = ("Error: All fields are required\",\"Fields Error\"");
                }
     
                else
                {
                    myCon.openCon();
                    string username = usernameLbl.Text;

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
                        sm.Show();
                        sm.successLbl.Text = "Insert Successful";
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
                        FoodSelection();

                    }
                    else
                    {
                        fm.Show();
                        fm.failedLbl.Text = "Insert Failed";
                    }

                    myCon.closeCon();
                }
                

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

        public void UpdateNutritionValues()
        {
            int serving = dfServings;

            //MessageBox.Show(lastcal.ToString());
            //MessageBox.Show(lastfat.ToString());
            //MessageBox.Show(lastproteins.ToString());
            //MessageBox.Show(lastcarbs.ToString());
            MessageBox.Show(serving.ToString());

            double servingSize = double.Parse(nf.servingsBox.Text);
            double factor = servingSize / serving;



            int updatedCal = (int)(dfCal * factor);
            int updatedFat = (int)(dfFat * factor);
            int updatedCarb = (int)(dfCarbs * factor);
            int updatedProtein = (int)(dfProtein * factor);

            nf.calLabel.Text = updatedCal.ToString();
            nf.fatLabel.Text = updatedFat.ToString();
            nf.carbLabel.Text = updatedCarb.ToString();
            nf.totalProteinLabel.Text = updatedProtein.ToString();
        }

       
        private void MyPersonalFood_Load(object sender, EventArgs e)
        {

        }

        private void createFood(object sender, EventArgs e)
        {
            //loadForm(create);
            //create.createUserLabel.Text = usernameLbl.Text;
            panel1.Visible = true;
            createFoodBtn.Visible = false;
        }

        private void servingValueBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void servingContainerBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void caloriesCreateBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void totalCarbCreateBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void totalFatCreateBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void totalProteinCreateBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            InsertCreatedFood();
        }

        private void usernameLbl_TextChanged(object sender, EventArgs e)
        {
            FoodSelection();
            panel1.Visible = true;
            createFoodBtn.Visible = false;
            //create.label43.Text = usernameLbl.Text;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
