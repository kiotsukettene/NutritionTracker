using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ZstdSharp.Unsafe;
using static Mysqlx.Datatypes.Scalar.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Mysqlx.Connection;
using MySql.Data.MySqlClient;


namespace NutritionTracker
{
    public partial class FormAddFood : Form
    {
        DBConnection myCon = new DBConnection();
        FoodDiary fd = new FoodDiary();

        
        public FormAddFood()
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
        #region TabPanels
        //void showForm(Form panel)
        //{
        //    nutritionFactsPanel.Controls.Clear();
        //    panel.TopLevel = false;
        //    nutritionFactsPanel.Controls.Add(panel);
        //    panel.Dock = DockStyle.Fill;
        //    panel.Show();
        //}
        #endregion

        #region API CALL
        private async void API()
        {
            string foodItem = addFoodSearchBox.Text;

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://edamam-food-and-grocery-database.p.rapidapi.com/api/food-database/v2/parser?nutrition-type=logging&ingr={Uri.EscapeUriString(foodItem)}"),
                    Headers =
                            {
                                { "X-RapidAPI-Key", "4f4b45e879msh45f87075e3fb93ep11bc5ejsn9044281e5818" },
                                { "X-RapidAPI-Host", "edamam-food-and-grocery-database.p.rapidapi.com" },
                            },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(body);

                    foreach (var food in json["hints"])
                    {
                        var foodDetails = food["food"];
                        var nutrients = foodDetails["nutrients"];
                        var brand = foodDetails["brand"];


                        string foodName = foodDetails["label"].ToString();
                        double calories = nutrients["ENERC_KCAL"] != null ? (double)nutrients["ENERC_KCAL"] : 0;
                        double protein = nutrients["PROCNT"] != null ? (double)nutrients["PROCNT"] : 0;
                        double fat = nutrients["FAT"] != null ? (double)nutrients["FAT"] : 0;
                        double carbohydrates = nutrients["CHOCDF"] != null ? (double)nutrients["CHOCDF"] : 0;
                        string brandName = brand is JValue ? (brand as JValue)?.Value?.ToString() : "Generic";


                        // Calculate total macronutrients
                        // Calculate total macronutrients
                        double totalMacronutrients = protein + fat + carbohydrates;

                        // Calculate percentages
                        double proteinPercentage = totalMacronutrients > 0 ? (protein / totalMacronutrients) * 100 : 0;
                        double fatPercentage = totalMacronutrients > 0 ? (fat / totalMacronutrients) * 100 : 0;
                        double carbohydratesPercentage = totalMacronutrients > 0 ? (carbohydrates / totalMacronutrients) * 100 : 0;

                        //Console.WriteLine($"Food: {foodName}");
                        //Console.WriteLine($"Brand: {brand}");
                        //Console.WriteLine($"Calories: {calories} kcal");
                        //Console.WriteLine($"Total Fat: {fat:F2} g ({fatPercentage:F2}%)");
                        //Console.WriteLine($"Protein: {protein:F2} g ({proteinPercentage:F2}%)");
                        //Console.WriteLine($"Carbohydrates: {carbohydrates:F2} g ({carbohydratesPercentage:F2}%)");
                        //Console.WriteLine("-------------------------");

                        //foodNameLbl.Text = foodName;
                        //servingsBox.Text = 100.ToString();
                        //unitBox.Text = "grams";
                        //calLabel.Text = calories.ToString();
                        //carbLabel.Text = carbLabel.ToString();
                        //fatLabel.Text = fat.ToString();
                        //proteinPercentLbl.Text = protein.ToString();
                        //carbPercentLbl.Text = carbohydratesPercentage.ToString();
                        //fatPercentLbl.Text = fatPercentage.ToString();
                        //proteinPercentLbl.Text = proteinPercentage.ToString();

                        AddFoodConrol add = new AddFoodConrol();
                        add.FoodName = foodName;
                        add.Calories = (int)calories;
                        add.Brand = brandName;
                        add.Carbs = (int)carbohydrates;
                        add.Protein = (int)protein;
                        add.Fat = (int)fat;
                        add.CarbPercent = carbohydratesPercentage;
                        add.ProteinPercent = proteinPercentage;
                        add.FatPercent = fatPercentage;
                        add.Serving = 100;

                        searchFoodPanel.Controls.Add(add);
                        add.Click += AddFood_Click;

                    }
                }
            }
        }
        #endregion
        public void AddFood_Click(object sender, EventArgs e)
        {
            AddFoodConrol add = (AddFoodConrol)sender;
            int servings = 100;
            foodNameLbl.Text = add.FoodName;
            servingsBox.Text = servings.ToString();
            unitBox.Text = "1 gram";
            calLabel.Text = add.Calories.ToString();
            carbLabel.Text = add.Carbs.ToString();
            fatLabel.Text = add.Fat.ToString();
            totalProteinLabel.Text = add.Protein.ToString();
            proteinPercentLbl.Text = $"{add.ProteinPercent.ToString("F2")}%";
            carbPercentLbl.Text = $"{add.CarbPercent.ToString("F2")}%";
            fatPercentLbl.Text = $"{add.FatPercent.ToString("F2")}%";
            chartCal.Text = add.Calories.ToString();

            int protein = int.Parse(totalProteinLabel.Text);
            int fat = int.Parse(fatLabel.Text);
            int carbs = int.Parse(carbLabel.Text);
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY("Protein", protein);
            chart1.Series["Series1"].Points.AddXY("Fat", fat);
            chart1.Series["Series1"].Points.AddXY("Protein", carbs);
            chart1.DataBind();
            panel1.Visible = true;

            

           

        }

        public void InsertToFoodDiary()
        {
            try
            {
                myCon.openCon();
               DateTime date = DateTime.Now;
                string addDate = date.ToString("yyyy-MM-dd");
                string foodname = foodNameLbl.Text;
                string username = usernameLbl.Text;
                int servingSize = int.Parse(servingsBox.Text);
                string unit = unitBox.Text;
                string meal = mealBox.Text;
                int cals = int.Parse(calLabel.Text);
                int fats = int.Parse(fatLabel.Text);
                int carbs = int.Parse(carbLabel.Text);
                int proteins = int.Parse(totalProteinLabel.Text);

                string insertFoodQuery = @"INSERT INTO `user_food_diary`(user_id, `food_name`, `serving_size`, `serving_unit`, `meal`, `calories`, carbs, `fat`, `protein`, added_at) 
                                        SELECT user.id, @food_name, @serving_size, @serving_unit, @meal, @calories,@carbs, @fat, @protein, @added_at
                                        FROM user WHere user.username = @username;
                                        ";
                MySqlCommand insertFoodCmd = new MySqlCommand(insertFoodQuery, myCon.getCon());

                insertFoodCmd.Parameters.Clear();
                insertFoodCmd.Parameters.AddWithValue("@food_name", foodname);
                insertFoodCmd.Parameters.AddWithValue("@serving_size", servingSize);
                insertFoodCmd.Parameters.AddWithValue("@serving_unit", unit);
                insertFoodCmd.Parameters.AddWithValue("@meal", meal);
                insertFoodCmd.Parameters.AddWithValue("@calories", cals);
                insertFoodCmd.Parameters.AddWithValue("@carbs", carbs);
                insertFoodCmd.Parameters.AddWithValue("@fat", fats);
                insertFoodCmd.Parameters.AddWithValue("@protein", proteins);
                insertFoodCmd.Parameters.AddWithValue("@added_at", addDate);
                insertFoodCmd.Parameters.AddWithValue("@username", username);

                int rows = insertFoodCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                myCon.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        public void UpdateNutritionValues()
        {

            

            //int basecals = int.Parse(calLabel.Text);
            //int basefats = int.Parse(fatLabel.Text);
            //int basecarbs = int.Parse(carbLabel.Text);
            //int baseproteins = int.Parse(totalProteinLabel.Text);
            //int lastcal = add.Calories;
            //int lastfat = add.Fat;
            //int lastproteins = add.Protein;
            //int lastcarbs = add.Carbs;
            AddFoodConrol add = new AddFoodConrol();
            int servingSize = int.Parse(servingsBox.Text);

            add.Calories = int.Parse(calLabel.Text);
            add.Carbs = int.Parse(carbLabel.Text);
            add.Fat = int.Parse(fatLabel.Text);
            add.Protein = int.Parse(totalProteinLabel.Text);
            double factor  = servingSize / 100;


            int calories = (int)(add.Calories * factor) ;
            int fats = (int)(add.Fat * factor);
            int carbs = (int)(add.Carbs * factor);  
            int protein = (int)(add.Protein * factor);

            calLabel.Text = calories.ToString();
            fatLabel.Text = fats.ToString();
            carbLabel.Text = carbs.ToString();
            totalProteinLabel.Text = protein.ToString();
          

        }
        private void FormAddFood_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
       
        private void BackBtn_Click(object sender, EventArgs e)
        {
            loadForm(fd);
            fd.fdUsername.Text = usernameLbl.Text;

        }

        private void searchBtn(object sender, EventArgs e)
        {
         
            API();
            searchFoodPanel.Controls.Clear();
            panel1.Visible = false;
        }

        private void AddToFoodDiaryBtn(object sender, EventArgs e)
        {
            InsertToFoodDiary();
            
            
        }

        private void servingsBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void updateValues_Click(object sender, EventArgs e)
        {
            //UpdateNutritionValues();
        }
    }
}
