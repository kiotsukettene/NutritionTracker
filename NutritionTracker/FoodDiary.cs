using Guna.UI2.WinForms.Suite;
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
    public partial class FoodDiary : Form
    {
        public FoodDiary()
        {
            InitializeComponent();
            addFoodBtn.Visible = true;
            FDLabel.Visible = true;
            DynamicFoodDiary();
            totalTxtPanel.Visible = true;
            foodDiaryPanel.Visible = true;
            fdTotalPanel.Visible = true;
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
        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            FormAddFood add = new FormAddFood();
            loadForm(add);
            add.panel1.Visible = false;
            FDLabel.Visible = false;

            
        }

        
        private void FoodDiary_Load(object sender, EventArgs e)
        {
            DynamicFoodDiary();
            addFoodBtn.Visible = true;
            FDLabel.Visible = true;
            totalTxtPanel.Visible = true;
            foodDiaryPanel.Visible = true;
            fdTotalPanel.Visible = true;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
