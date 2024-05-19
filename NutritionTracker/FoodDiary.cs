using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NutritionTracker
{

    public partial class FoodDiary : Form
    {
        DBConnection myCon = new DBConnection();
        FailedMessage fm = new FailedMessage();
        SuccessMessage sm = new SuccessMessage();

       
        public int food_id { get; set; }
        public string unit, meal, username;
        private double originalServingSize;
        public double cal, carbs, fats, protein;
        public FoodDiary()
        {
            InitializeComponent();
            addFoodBtn.Visible = true;
            FDLabel.Visible = true;
           
            totalTxtPanel.Visible = true;
            foodDiaryPanel.Visible = true;
            fdTotalPanel.Visible = true;
           
        }
        #region TabPanels
        public void loadForm(Form panel)
        {
            mainPanel.Controls.Clear();
            panel.TopLevel = false;
            mainPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        #endregion

        public void DynamicFoodDiary()
        {
            foodDiaryPanel.Controls.Clear();

            FoodDiaryControl[] foodDiary = new FoodDiaryControl[5];
            string[] meal = new string[5] {"Breakfast", "Lunch", "Dinner", "Snacks", "Breakfast"};
            string[] foodDesc = new string[5] {"White Rice, cooked", "Chicken breast, cooked, skinless", "Ice coffee", "Chicken breast, raw, skinless", "Chicken breast, cooked, with skin"};
            int[] servings = new int[5] { 100, 200, 300, 400, 500 };
            string[] unit = new string[5] { "grams", "grams", "ml", "grams", "grams" };
            int[] cal = new int[5] { 117, 300, 240, 400, 500 };
            int[] carb = new int[5] { 36, 0, 23, 0, 0};
            int[] fat = new int[5] { 4, 2, 0, 4, 25 };
            int[] protein = new int[5] { 6, 25, 2, 25, 36 };

            for(int i = 0; i < foodDiary.Length; i++)
            {
                foodDiary[i] = new FoodDiaryControl();

                foodDiary[i].Meal = meal[i];
                foodDiary[i].FoodDesc = foodDesc[i];
                foodDiary[i].ServingSize = servings[i];
                foodDiary[i].ServingUnit = unit[i];
                foodDiary[i].Calories = cal[i];
                foodDiary[i].Carbs= carb[i];
                foodDiary[i].Fat = fat[i];
                foodDiary[i].Protein = protein[i];

                foodDiaryPanel.Controls.Add(foodDiary[i]);

            }

        }

        public void DisplayFoodDiary()
        {
            try
            {
                

                DateTime date = dbDateTime.Value;
                string username = fdUsername.Text;
                string added_at = date.ToString("yyyy-MM-dd");

                myCon.openCon();
               
                string selectQuery = @"SELECT user_food_diary.id, food_name, serving_size, serving_unit, meal, calories, carbs, fat, protein 
                                    FROM user_food_diary
                                    JOIN user ON user.id = user_food_diary.user_id 
                                    WHERE user.username = @username AND user_food_diary.added_at = @added_at
                                    ORDER BY FIELD(meal, 'BREAKFAST', 'lunch', 'dinner', 'snacks');";

                MySqlCommand selectCmd = new MySqlCommand(selectQuery, myCon.getCon());
                selectCmd.Parameters.Clear();
                selectCmd.Parameters.AddWithValue("@username", username);
                selectCmd.Parameters.AddWithValue("@added_at", added_at);

                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                int rowCount = dt.Rows.Count;

                if (rowCount > 0)
                {
                    foodDiaryPanel.Controls.Clear();
                    int totalCalories = 0;
                    int totalCarbs = 0;
                    int totalFat = 0;
                    int totalProtein = 0;
                    
                    for (int i = 0; i < rowCount; i++)
                    {
                        FoodDiaryControl fdc = new FoodDiaryControl
                        {
                            FoodID = (int)dt.Rows[i]["id"],
                            Meal = dt.Rows[i]["meal"].ToString(),
                            FoodDesc = dt.Rows[i]["food_name"].ToString(),
                            ServingSize = (int)dt.Rows[i]["serving_size"],
                            ServingUnit = dt.Rows[i]["serving_unit"].ToString(),
                            Calories = (int)dt.Rows[i]["calories"],
                            Carbs = (int)dt.Rows[i]["carbs"],
                            Protein = (int)dt.Rows[i]["protein"],
                            Fat = (int)dt.Rows[i]["fat"]
                          
                        };
                       

                        foodDiaryPanel.Controls.Add(fdc);       
                        totalCalories += (int)dt.Rows[i]["calories"];
                        totalCarbs += (int)dt.Rows[i]["carbs"];
                        totalFat += (int)dt.Rows[i]["fat"];
                        totalProtein += (int)dt.Rows[i]["protein"];
                        InitializeDeleteFoodDiaryControl(fdc);
                        InitializeEditFoodDiaryControl(fdc);
                    }
                    
                    TotalCal.Text = totalCalories.ToString();
                    TotalCarb.Text = totalCarbs.ToString();
                    TotalProtein.Text = totalProtein.ToString();
                    TotalFat.Text = totalFat.ToString();

                    UpdateRemainingGoals(username, totalCalories, totalCarbs, totalFat, totalProtein);



                }
                else
                {
                    foodDiaryPanel.Controls.Clear();
                    TotalCal.Text = "0";
                    TotalCarb.Text = "0";
                    TotalProtein.Text = "0";
                    TotalFat.Text = "0";
                    RemainCal.Text = fdCal.Text.ToString();
                    RemainCarb.Text = fdCarbs.Text.ToString();
                    RemainFat.Text = fdFat.Text.ToString();
                    RemainProtein.Text = fdProtein.Text.ToString();
                    RemainCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                    RemainCarb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                    RemainFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                    RemainProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                }
                myCon.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
           
        }
        private void UpdateRemainingGoals(string username, int totalCalories, int totalCarbs, int totalFat, int totalProtein)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(@"SELECT calories, carbs, fat, protein 
                                                            FROM user_macros 
                                                            JOIN user ON user.id = user_macros.user_id 
                                                            WHERE username = @username;", myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int calGoal = dr.GetInt32("calories");
                        int carbGoal = dr.GetInt32("carbs");
                        int fatGoal = dr.GetInt32("fat");
                        int proteinGoal = dr.GetInt32("protein");

                        fdCal.Text = calGoal.ToString();
                        fdCarbs.Text = carbGoal.ToString();
                        fdFat.Text = fatGoal.ToString();
                        fdProtein.Text = proteinGoal.ToString();

                        int calRemain = (calGoal - totalCalories);
                        int carbRemain = (carbGoal - totalCarbs);
                        int fatRemain = (fatGoal - totalFat);
                        int proteinRemain = (proteinGoal - totalProtein);

                        RemainCal.Text = calRemain.ToString();
                        RemainCarb.Text = carbRemain.ToString();
                        RemainFat.Text = fatRemain.ToString();
                        RemainProtein.Text = proteinRemain.ToString();
                        if (totalCalories > calGoal)
                        {
                            RemainCal.ForeColor = Color.Red;
                        }
                        else
                        {
                            RemainCal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                        }
                        if (totalCarbs > carbGoal)
                        {
                            RemainCarb.ForeColor = Color.Red;
                        }
                        else
                        {
                            RemainCarb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                        }
                        if (totalFat > fatGoal)
                        {
                            RemainFat.ForeColor = Color.Red;
                        }
                        else
                        {
                            RemainFat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                        }
                        if (totalProtein > proteinGoal)
                        {
                            RemainProtein.ForeColor = Color.Red;
                        }
                        else
                        {
                            RemainProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(187)))), ((int)(((byte)(133)))));
                        }
                    }


                    dr.Close();
                

                }
                myCon.closeCon();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
        public void DeleteCertainFood(int foodID, FoodDiaryControl fdc)
        {
            try
            {
                myCon.openCon();
                DateTime date = dbDateTime.Value;
                string added_at = date.ToString("yyyy-MM-dd");
                string username = fdUsername.Text;
                

                string deleteQuery = @"DELETE user_food_diary
                                    FROM user_food_diary
                                    JOIN user ON user.id = user_food_diary.user_id
                                    WHERE user.username = @username AND user_food_diary.added_at = @added_at AND user_food_diary.id = @foodID;";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@added_at", added_at);
                cmd.Parameters.AddWithValue("@foodID", foodID);

                cmd.ExecuteNonQuery();

                myCon.closeCon();
                DisplayFoodDiary();

            }
            catch (Exception e) 
            {
               MessageBox.Show("Error" + e.Message);
            }
        }
        private void InitializeDeleteFoodDiaryControl(FoodDiaryControl fdc)
        {
            fdc.OnDelete += (sender, e) =>
            {
                var control = sender as FoodDiaryControl;
                if (control != null)
                {
                    DeleteCertainFood(control.FoodID, control);
                    foodDiaryPanel.Controls.Remove(control);
                }
            };
        }
        private void EditCertainFood(int foodID, FoodDiaryControl fdc)
        {
            try
            {

                FormAddFood add = new FormAddFood();
                loadForm(add);
                add.panel1.Visible = true;
                add.addToDiaryBtn.Visible = false;
                FDLabel.Visible = false;
                add.usernameLbl.Text = fdUsername.Text;
                
                string username = add.usernameLbl.Text;
               

                myCon.openCon();

                string selectQuery = @"SELECT user_food_diary.id, food_name, serving_size, serving_unit, meal, calories, carbs, fat, protein, added_at 
                                       FROM user_food_diary
                                        JOIN user ON user.id = user_food_diary.user_id
                                       WHERE user_food_diary.id = @foodID AND user.username = @username;";

                MySqlCommand cmd = new MySqlCommand(selectQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@foodID", foodID);
                cmd.Parameters.AddWithValue("@username", username);
                //cmd.Parameters.AddWithValue("@added_at", added_at);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    food_id = dr.GetInt32("id");
                    string foodNameEdit = dr.GetString("food_name");
                    originalServingSize = dr.GetInt32("serving_size");
                    string unit = dr.GetString("serving_unit");
                    string meal = dr.GetString("meal");
                    double cal = dr.GetDouble("calories");
                    double carbs = dr.GetDouble("carbs");
                    double fats = dr.GetDouble("fat");
                    double protein = dr.GetDouble("protein");
                    DateTime date = dr.GetDateTime("added_at");


                  
                    add.foodNameLbl.Text = foodNameEdit.ToString();
                    add.servingsBox.Text = originalServingSize.ToString();
                    add.unitBox.Text = unit;
                    add.mealBox.Text = meal;
                    add.calLabel.Text = cal.ToString();
                    add.chartCal.Text = cal.ToString();
                    add.carbLabel.Text = carbs.ToString();
                    add.fatLabel.Text = fats.ToString();
                    add.totalProteinLabel.Text = protein.ToString();
                    add.dbDateTime.Value = date;

                    double totalMacronutrients = protein + fats + carbs;
                    
                    // Calculate percentages
                    double proteinPercentage = totalMacronutrients > 0 ? (protein / totalMacronutrients) * 100 : 0;
                    double fatPercentage = totalMacronutrients > 0 ? (fats / totalMacronutrients) * 100 : 0;
                    double carbohydratesPercentage = totalMacronutrients > 0 ? (carbs / totalMacronutrients) * 100 : 0;

                    
                    add.carbPercentLbl.Text =$"{carbohydratesPercentage.ToString("F2")}%";
                    add.fatPercentLbl.Text = $"{fatPercentage.ToString("F2")}%";
                    add.proteinPercentLbl.Text = $"{proteinPercentage.ToString("F2")}%";

                    //double carbP = double.Parse(add.carbPercentLbl.Text);
                    //double fatP = double.Parse(add.fatPercentLbl.Text);
                    //double proteinP = double.Parse(add.proteinPercentLbl.Text);

                    add.chart1.Series["Series1"].Points.Clear();
                    add.chart1.Series["Series1"].Points.AddXY("Protein", proteinPercentage);
                    add.chart1.Series["Series1"].Points.AddXY("Fat", fatPercentage);
                    add.chart1.Series["Series1"].Points.AddXY("Carbohydrates", carbohydratesPercentage);
                    add.chart1.DataBind();

                   

                    add.servingsBox.TextChanged += (s, e) => UpdateNutritionalValues(add, cal, carbs, fats, protein);
                    add.updateBtn.Click += (sender, e) => UpdateToDiary(foodID, add);

                }
                dr.Close();
                myCon.closeCon();
            }
            catch (Exception e) 
            { 
                MessageBox.Show("Error" + e);
            }
        }
        private void UpdateNutritionalValues(FormAddFood add, double cal, double carbs, double fats, double protein)
        {
           

            if (double.TryParse(add.servingsBox.Text, out double servingSize))
            {
                double factor = servingSize / originalServingSize;

                int updatedCal = (int)(cal * factor);
                int updatedFat = (int)(fats * factor);
                int updatedCarb = (int)(carbs * factor);
                int updatedProtein = (int)(protein * factor);

                add.calLabel.Text = updatedCal.ToString();
                add.fatLabel.Text = updatedFat.ToString();
                add.carbLabel.Text = updatedCarb.ToString();
                add.totalProteinLabel.Text = updatedProtein.ToString();
                add.chartCal.Text = updatedCal.ToString();
            }
        }
        private void InitializeEditFoodDiaryControl(FoodDiaryControl fdc)
        {
            fdc.OnEdit += (sender, e) =>
            {
                var control = sender as FoodDiaryControl;
                if (control != null)
                {
                    EditCertainFood(control.FoodID, control);
                   
                }
            };
        }


        public void SelectMacros()
        {
            myCon.openCon();
            string username = fdUsername.Text;
            try
            {
                MySqlCommand cmd = new MySqlCommand(@"SELECT calories, carbs, fat, protein 
                                                            FROM user_macros 
                                                            JOIN user ON user.id = user_macros.user_id 
                                                            WHERE username = @username;", myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int calGoal = dr.GetInt32("calories");
                        int carbGoal = dr.GetInt32("carbs");
                        int fatGoal = dr.GetInt32("fat");
                        int proteinGoal = dr.GetInt32("protein");

                        RemainCal.Text = calGoal.ToString();
                        RemainCarb.Text = carbGoal.ToString();
                        RemainFat.Text = fatGoal.ToString();
                        RemainProtein.Text = proteinGoal.ToString();
                        fdCal.Text = calGoal.ToString();
                        fdCarbs.Text = carbGoal.ToString();
                        fdFat.Text = fatGoal.ToString();
                        fdProtein.Text = proteinGoal.ToString();


                    }
                    dr.Close();
                }
                myCon.closeCon();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }

        public void UpdateToDiary(int foodID, FormAddFood add)
        {
            try
            {
                string username = add.usernameLbl.Text;
                string foodName = add.foodNameLbl.Text;
                originalServingSize = double.Parse(add.servingsBox.Text);
                string servingUnit = add.unitBox.Text;
                string meal = add.mealBox.Text;
                double calories = double.Parse(add.calLabel.Text);
                double carbs = double.Parse(add.carbLabel.Text);
                double fats = double.Parse(add.fatLabel.Text);
                double protein = double.Parse(add.totalProteinLabel.Text);
                DateTime addedAt = add.dbDateTime.Value;
                string added_at = addedAt.ToString("yyyy-MM-dd");
                myCon.openCon();

                string updateQuery = @"UPDATE `user_food_diary` 
                                    JOIN user on user.id = user_food_diary.user_id
                                    SET
                                        user_food_diary.serving_size = @serving_size,
                                        user_food_diary.serving_unit = @serving_unit,
                                        user_food_diary.meal = @meal,
                                        user_food_diary.calories = @calories,
                                        user_food_diary.carbs = @carbs,
                                        user_food_diary.fat = @fat,
                                        user_food_diary.protein = @protein,
                                        user_food_diary.added_at = @added_at
                                    WHERE user.username = @username AND user_food_diary.id = @food_id;
                                        ";
                MySqlCommand cmd = new MySqlCommand(updateQuery, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@serving_size", originalServingSize);
                cmd.Parameters.AddWithValue("@serving_unit", servingUnit);
                cmd.Parameters.AddWithValue("@meal", meal);
                cmd.Parameters.AddWithValue("@calories", calories);
                cmd.Parameters.AddWithValue("@carbs", carbs);
                cmd.Parameters.AddWithValue("@fat", fats);
                cmd.Parameters.AddWithValue("@protein", protein);
                cmd.Parameters.AddWithValue("@added_at", added_at);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@food_id", foodID);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    sm.Show();
                    sm.successLbl.Text = "Update Success!";
                    
                   
                }
                else
                {
                    fm.Show();
                    fm.failedLbl.Text = "Update Failed";
                }
                myCon.closeCon();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }
       

        private void addFoodBtn_Click(object sender, EventArgs e)
        {
                FormAddFood add = new FormAddFood();
                loadForm(add);
                add.panel1.Visible = false;
                FDLabel.Visible = false;
                add.usernameLbl.Text = fdUsername.Text;


       }


            private void FoodDiary_Load(object sender, EventArgs e)
        {
            //DynamicFoodDiary();
            SelectMacros();
            dbDateTime.Value = DateTime.Now;
            addFoodBtn.Visible = true;
            FDLabel.Visible = true;
            totalTxtPanel.Visible = true;
            foodDiaryPanel.Visible = true;
            fdTotalPanel.Visible = true;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fdUsername_TextChanged(object sender, EventArgs e)
        {
            
            DisplayFoodDiary();
        }

        private void fdUsername_Click(object sender, EventArgs e)
        {

        }

        private void dbDateTime_ValueChanged(object sender, EventArgs e)
        {
            DisplayFoodDiary();
        }
    }
}
