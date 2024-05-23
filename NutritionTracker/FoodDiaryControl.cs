using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
    public partial class FoodDiaryControl : UserControl
    {
        public FoodDiaryControl()
        {
            InitializeComponent();
        }

        #region Properties
        private int foodID;
        private string meal;
        private string foodDesc;
        private int servingSize;
        private string servingUnit;
        private int calories;
        private int carbs;
        private int fat;
        private int protein;

        [Category("Custom Props")]

        public string Meal
        {
            get { return meal; }
            set { meal = value; mealLbl.Text = value; SetMealColor(value); }
        }
        [Category("Custom Props")]
        public string FoodDesc
        {
            get { return foodDesc; }
            set { foodDesc = value; fdLbl.Text = value; }
        }
        [Category("Custom Props")]
        public int ServingSize
        { 
            get { return servingSize; }
            set { servingSize = value; sizeLbl.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public string ServingUnit
        {
            get { return servingUnit; }
            set { servingUnit = value; unitLbl.Text = value; }
        }
        [Category("Custom Props")]
        public int Calories
        {
            get { return calories; }
            set { calories = value; calLbl.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int Carbs
        {
            get { return carbs; }
            set { carbs = value; carbLbl.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int Fat
        {
            get { return fat; }
            set { fat = value; fatLbl.Text = value.ToString(); }
        }
        [Category("Custom Props")]
        public int Protein
        {
            get { return protein; }
            set { protein = value; proteinLbl.Text = value.ToString(); }
        }
        public int FoodID
        {
            get { return foodID; } 
            set { foodID = value; }
        }
        #endregion

        private void FoodDiaryControl_Load(object sender, EventArgs e)
        {

        }
        private void SetMealColor(string mealType)
        {
            switch (mealType.ToLower())
            {
                case "breakfast":
                    mealLbl.BackColor = Color.LightSteelBlue;
                    break;
                case "snacks":
                    mealLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(139)))));
                    break;
                case "dinner":
                    mealLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(222))))); 
                    break;
                case "lunch":
                    mealLbl.BackColor = Color.Wheat; // LightOrange is not a standard color, use a close alternative
                    break;
                default:
                    mealLbl.BackColor = SystemColors.Control; // Default color
                    break;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, EventArgs.Empty);

        }
        public event EventHandler OnDelete;
        public event EventHandler OnEdit;

        private void editBtn_Click(object sender, EventArgs e)
        {
            OnEdit?.Invoke(this, EventArgs.Empty);
        }
    }
}
