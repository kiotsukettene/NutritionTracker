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

namespace NutritionTracker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void chartData()
        {
            chart1.Series["Series1"].Points.AddXY("04/03/2024", 2000);
            chart1.Series["Series1"].Points.AddXY("04/04/2024", 1900);
            chart1.Series["Series1"].Points.AddXY("04/05/2024", 2100);
            chart1.Series["Series1"].Points.AddXY("04/06/2024", 2400);
            chart1.Series["Series1"].Points.AddXY("04/07/2024", 2300);
            chart1.Series["Series1"].Points.AddXY("04/08/2024", 1700);
            chart1.Series["Series1"].Points.AddXY("04/09/2024", 2156);
            chart1.Series["Series1"].Points.AddXY("04/10/2024", 2355);
            chart1.Series["Series1"].Points.AddXY("04/11/2024", 1111);
                
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            chartData();
        }
    }
}
