using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionTracker
{
  
    
    public partial class Step3Macros : Form
    {
        private int TDEE;
        private int carbs;
        private int protein;
        private int fat;
        private int targetWeight;
        private int weight;
        private double carbspercentage;
        private double proteinpercentage;
        private double fatpercentage;
        private Step2Form step2form;

        public Step3Macros(int tDEE, int carbs, int protein, int fat, double carbspercentage, double proteinpercentage, double fatpercentage, int targetWeight, int weight, Step2Form step2form)
        {
            InitializeComponent();
            TDEE = tDEE;
            this.carbs = carbs;
            this.protein = protein;
            this.fat = fat;
            this.carbspercentage = carbspercentage;
            this.proteinpercentage = proteinpercentage;
            this.fatpercentage = fatpercentage;
            this.targetWeight = targetWeight;
            this.weight = weight;
            this.step2form = step2form;
        }
        #region RoundForm
        public void RoundCorners()
        {
            int arc = 20;

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();

            // Top Left
            graphicsPath.AddArc(new Rectangle(0, 0, 2 * arc, 2 * arc), 180, 90);

            // Top Right
            graphicsPath.AddArc(new Rectangle(this.Width - 2 * arc, 0, 2 * arc, 2 * arc), -90, 90);

            // Bottom Right
            graphicsPath.AddArc(new Rectangle(this.Width - 2 * arc, this.Height - 2 * arc, 2 * arc, 2 * arc), 0, 90);

            // Bottom Left
            graphicsPath.AddArc(new Rectangle(0, this.Height - 2 * arc, 2 * arc, 2 * arc), 90, 90);

            this.Region = new Region(graphicsPath);
        }
        #endregion
        private void step3nxtBtn(object sender, EventArgs e)
        {
            this.Dispose();

            Step4Macros step4 = new Step4Macros();
          

            step4.Show();
            step4.RoundCorners();
        }

        private void Step3Macros_Load(object sender, EventArgs e)
        {
           
        }
    }
}
