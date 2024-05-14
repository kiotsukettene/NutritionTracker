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
        public MyPersonalFood()
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

        private void MyPersonalFood_Load(object sender, EventArgs e)
        {
            DynamicPersonalFoodList();
            usernameLbl.Visible = false;
        }

        private void createFood(object sender, EventArgs e)
        {
            loadForm(create);
            create.label43.Text = usernameLbl.Text;
            PersonalFoodLbl.Visible = false;
            foodListLbl.Visible = false;
            viewLbl.Visible = false;
            createFoodBtn.Visible = false;
            nutritionFactsPanel.Visible = false;
            FoodListPanel.Visible = false;
            
        }
    }
}
