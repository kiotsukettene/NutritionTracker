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
    public partial class PersonalFoodControl : UserControl
    {
        public PersonalFoodControl()
        {
            InitializeComponent();
        }

        #region Properties 

        private string foodDescription;
        private string brandName;
        private int servingSize;
        private int calories;

        [Category("Custom Props")]

        public string FoodDescription
        {
            get { return foodDescription; }
            set { foodDescription = value; foodDescLbl.Text = value; }
        }
        [Category("Custom Props")]
        public string BrandName
        {
            get { return brandName; }
            set { brandName = value; brandNameLbl.Text = value; }
        }
        [Category("Custom Props")]
        public int ServingSize
        {
            get { return servingSize; }
            set { servingSize = value; servingSizeLbl.Text = value.ToString() + " grams"; }
        }
        [Category("Custom Props")]
        public int Calories
        {
            get { return calories; }
            set { calories = value; caloriesLbl.Text = value.ToString() + " calories"; }
        }
        #endregion
    }
}
