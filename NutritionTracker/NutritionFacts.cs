using MySql.Data.MySqlClient;
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
    public partial class NutritionFacts : Form
    {
        DBConnection myCon = new DBConnection();

        public NutritionFacts()
        {
            InitializeComponent();
            
        }
        #region TabPanels
        void loadForm(Form panel)
        {
            nutritionFactsPanel.Controls.Clear();
            panel.TopLevel = false;
            nutritionFactsPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        #endregion
        public void nutritionChart()
        {
            try
            {
                string fd = foodName.Text;
                myCon.openCon();

                string selectMacros = "SELECT carbs, total_fat, protein FROM user_personalfood WHERE food_desc = @food_desc";

                MySqlCommand cmd = new MySqlCommand(selectMacros, myCon.getCon());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@food_desc", fd);

                DataTable dt = new DataTable();
                MySqlDataAdapter sqladp = new MySqlDataAdapter(cmd);
                sqladp.Fill(dt);
                myCon.closeCon();

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    double carbs = Convert.ToDouble(row["carbs"]);
                    double fat = Convert.ToDouble(row["total_fat"]);
                    double protein = Convert.ToDouble(row["protein"]);

                    // Clear existing points
                    chart1.Series["Series1"].Points.Clear();

                    // Add new points
                    chart1.Series["Series1"].Points.AddXY("Protein", protein);
                    chart1.Series["Series1"].Points.AddXY("Fat", fat);
                    chart1.Series["Series1"].Points.AddXY("Protein", carbs);

                    // Update the chart
                    chart1.DataBind();
                }
                else
                {
                    MessageBox.Show("No data found for the specified food description.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                myCon.closeCon();
            }

        }

        private void foodName_TextChanged(object sender, EventArgs e)
        {
            nutritionChart();
        }
    }
}
