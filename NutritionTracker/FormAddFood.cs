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


namespace NutritionTracker
{
    public partial class FormAddFood : Form
    {
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
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string foodItem = addFoodSearchBox.Text;


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://edamam-food-and-grocery-database.p.rapidapi.com/api/food-database/v2/parser?nutrition-type=cooking&ingr={Uri.EscapeUriString(foodItem)}&health%5B0%5D=alcohol-free"),
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

                    string foodName = foodDetails["label"].ToString();
                    double calories = nutrients["ENERC_KCAL"] != null ? (int)nutrients["ENERC_KCAL"] : 0;
                    double protein = nutrients["PROCNT"] != null ? (int)nutrients["PROCNT"] : 0;
                    double fat = nutrients["FAT"] != null ? (int)nutrients["FAT"] : 0;
                    double carbohydrates = nutrients["CHOCDF"] != null ? (int)nutrients["CHOCDF"] : 0;
                    double cholesterol = nutrients["CHOLE"] != null ? (int)nutrients["CHOLE"] : 0;
                    double sodium = nutrients["NA"] != null ? (int)nutrients["NA"] : 0;
                    double potassium = nutrients["K"] != null ? (int)nutrients["K"] : 0;
                    double sugar = nutrients["SUGAR"] != null ? (int)nutrients["SUGAR"] : 0;
                    Console.WriteLine($"Food: {foodName}");
                    Console.WriteLine($"Calories: {calories} kcal");
                    Console.WriteLine($"Total Fat: {fat} g");
                    Console.WriteLine($"Cholesterol: {cholesterol} mg");
                    Console.WriteLine($"Sodium: {sodium} mg");
                    Console.WriteLine($"Potassium: {potassium} mg");
                    Console.WriteLine($"Total Carbohydrates: {carbohydrates} g");
                    Console.WriteLine($"Sugar: {sugar} g");
                    Console.WriteLine($"Protein: {protein} g");
                    Console.WriteLine("-------------------------");
                }
            }

        }

        private void FormAddFood_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            loadForm(new FoodDiary());
        }
    }
}
