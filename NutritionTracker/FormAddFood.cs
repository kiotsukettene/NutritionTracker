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


namespace NutritionTracker
{
    public partial class FormAddFood : Form
    {
        public FormAddFood()
        {
            InitializeComponent();
            nutritionChart();
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
            foodNameLbl.Text = add.FoodName;
            servingsBox.Text = 100.ToString();
            unitBox.Text = "grams";
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
        private void FormAddFood_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        public void nutritionChart()
        {
            AddFoodConrol add = new AddFoodConrol();

            
            int protein = add.Protein;
            int fat = add.Fat;
            int carbs = add.Carbs;
            // Add new points
            chart1.Series["Series1"].Points.AddXY("Protein", protein);
            chart1.Series["Series1"].Points.AddXY("Fat", fat);
            chart1.Series["Series1"].Points.AddXY("Protein", carbs);
            chart1.DataBind();
        }
       
        private void BackBtn_Click(object sender, EventArgs e)
        {
            loadForm(new FoodDiary());
        }

        private void searchBtn(object sender, EventArgs e)
        {
         
            API();
            searchFoodPanel.Controls.Clear();
            //nutritionChart();
        }

        private void foodNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chartCal_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void fatPercentLbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void carbPercentLbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void proteinPercentLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void servingsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void servingUnitBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calLabel_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void totalProteinLabel_Click(object sender, EventArgs e)
        {

        }

        private void fatLabel_Click(object sender, EventArgs e)
        {

        }

        private void carbLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
