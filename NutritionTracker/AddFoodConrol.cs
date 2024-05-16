using Org.BouncyCastle.Asn1;
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
    public partial class AddFoodConrol : UserControl
    {
        public AddFoodConrol()
        {
            InitializeComponent();
        }
        
         private string foodName;
        private string brand;
        private int serving;
        private int calories;
        private int carbs;
        private int fat;
        private int protein;
        private double cpercent;
        private double fpercent;
        private double ppercent;

        [Category("Custom Props")]

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; foodDescLbl.Text = value; }
        }

        [Category("Custom Props")]

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;

                brandNameLbl.Text = value;
            }
        }
        [Category("Custom Props")]

        public int Serving
        {
            get { return serving; }
            set { serving = value; servingSizeLbl.Text = value.ToString() + " g"; }
        }
        [Category("Custom Props")]
        public int Calories
        {
            get { return calories; }
            set { calories = value; caloriesLbl.Text = value.ToString() + " calories"; }
        }
        [Category("Custom Props")]
        public int Carbs
        {
            get { return carbs; }
            set { carbs = value;}
        }
        [Category("Custom Props")]
        public int Fat
        {
            get { return fat; }
            set { fat = value; }
        }
        [Category("Custom Props")]
        public int Protein
        {
            get { return protein; }
            set { protein = value; }
        }
        [Category("Custom Props")]
        public double CarbPercent
        {
            get { return cpercent; }
            set { cpercent = value; }
        }
        public double ProteinPercent
        {
            get { return ppercent; }
            set { ppercent = value; }
        }
        public double FatPercent
        {
            get { return fpercent; }
            set { fpercent = value; }
        }

    }
}
