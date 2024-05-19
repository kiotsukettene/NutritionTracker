using MySql.Data.MySqlClient;
using Mysqlx.Connection;
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
        DBConnection myCon = new DBConnection();
        public string water { get; set; }
        public string sleep { get; set; }
        public int TDEE { get; set; }
        public int carbs { get; set; }
        public int protein { get; set; }
        public int fat { get; set; }
        public double carbspercentage { get; set; }
        public double proteinpercentage { get; set; }
        public double fatpercentage { get; set; }
        public int targetweight { get; set; }
        public int weight { get; set; }
        public Dashboard()
        {
            InitializeComponent();
          
            //this.TDEE = TDEE;
            //this.carbs = carbs;
            //this.protein = protein;
            //this .fat = fat;
            //this.carbspercentage = carbspercentage;
            //this.proteinpercentage = proteinpercentage;
            //this.fatpercentage = fatpercentage;
        }
        public void chartPlaceHolder()
        {
            chart1.Series.Add("PlaceholderSeries");
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/03/2024", 2000);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/04/2024", 1900);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/05/2024", 2100);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/06/2024", 2400);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/07/2024", 2300);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/08/2024", 1700);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/09/2024", 2156);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/10/2024", 2355);
            chart1.Series["PlaceholderSeries"].Points.AddXY("04/11/2024", 1111);

            // Set maximum Y value
            chart1.ChartAreas[0].AxisY.Maximum = 2500;

            // Set chart properties
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;

            // Update chart
            chart1.DataBind();
        }
        public void chartData()
        {
            try
            {
                myCon.openCon();
                string username = dashUsername.Text;

                MySqlCommand cmd = new MySqlCommand(@"SELECT 
                             DATE_FORMAT(ufd.added_at, '%Y-%m-%d') AS dateOnly, 
                             SUM(ufd.calories) AS totalCalories, 
                             um.calories AS targetCalories
                         FROM 
                             user_food_diary ufd
                         JOIN 
                             user u ON u.id = ufd.user_id
                         JOIN 
                             user_macros um ON u.id = um.user_id
                         WHERE 
                             u.username = @username
                         GROUP BY 
                             dateOnly, um.calories
                         ORDER BY 
                             dateOnly;", myCon.getCon());
                cmd.Parameters.AddWithValue("@username", username);

                DataTable dt = new DataTable();
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);

                // Clear existing data in the chart
                chart1.Series.Clear();

                // Add series for total calories
                chart1.Series.Add("Total Calories");
                chart1.Series["Total Calories"].ChartType = SeriesChartType.Column;

                // Add series for target calories
                chart1.Series.Add("Target Calories");
                chart1.Series["Target Calories"].ChartType = SeriesChartType.Line;
                chart1.Series["Target Calories"].Color = Color.Red;

                // If dt is null or has zero rows, add hardcoded values
                if (dt == null || dt.Rows.Count == 0)
                {
                    // Clear existing "Series1" if it exists
                    if (chart1.Series.IndexOf("Series1") != -1)
                        chart1.Series.Remove(chart1.Series["Series1"]);

                    // Add placeholder data
                    chart1.Series.Add("PlaceholderSeries");
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/03/2024", 2000);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/04/2024", 1900);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/05/2024", 2100);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/06/2024", 2400);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/07/2024", 2300);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/08/2024", 1700);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/09/2024", 2156);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/10/2024", 2355);
                    chart1.Series["PlaceholderSeries"].Points.AddXY("04/11/2024", 1111);

                    // Set maximum Y value
                    chart1.ChartAreas[0].AxisY.Maximum = 2500;

                    // Set chart properties
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                    chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;

                    // Update chart
                    chart1.DataBind();
                }
                else
                {
                    // Add data points from the DataTable to the chart series
                    foreach (DataRow row in dt.Rows)
                    {
                        string dateOnly = row["dateOnly"].ToString();
                        int totalCalories = Convert.ToInt32(row["totalCalories"]);
                        int targetCalories = Convert.ToInt32(row["targetCalories"]);

                        chart1.Series["Total Calories"].Points.AddXY(dateOnly, totalCalories);
                        chart1.Series["Target Calories"].Points.AddXY(dateOnly, targetCalories);
                    }

                    // Set maximum Y value to the target calories
                    int maxTargetCalories = Convert.ToInt32(dt.Rows[0]["targetCalories"]);
                    chart1.ChartAreas[0].AxisY.Maximum = maxTargetCalories + 500;

                    // Set chart properties
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                    chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;

                    // Update chart
                    chart1.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                myCon.closeCon();
            }
        }


        public void RemainingMacros()
        {
            try
            {
                myCon.openCon();
                string username = dashUsername.Text; // replace with actual username
                DateTime date = dbDateTime.Value; // replace with the desired date
                string added_at = date.ToString("yyyy-MM-dd");

                MySqlCommand cmd = new MySqlCommand(@"SELECT 
                                     SUM(ufd.calories) AS totalCalories,
                                     SUM(ufd.carbs) AS totalCarbs,
                                     SUM(ufd.fat) AS totalFat,
                                     SUM(ufd.protein) AS totalProtein,
                                     um.calories AS SuperTotalCal,
                                     um.carb_percent as CarbPercent,
                                     um.fat_percent as FatPercent,
                                     um.protein_percent as ProteinPercent
                                 FROM 
                                     user_food_diary ufd
                                LEFT JOIN 
                                    user_macros um ON um.user_id = ufd.user_id
                                 JOIN 
                                     user ON user.id = ufd.user_id
                                 WHERE 
                                     user.username = @username
                                 AND 
                                     DATE(ufd.added_at) = @added_at;", myCon.getCon());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@added_at", added_at);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int totalCalories = reader.IsDBNull(reader.GetOrdinal("totalCalories")) ? 0 : reader.GetInt32("totalCalories");
                        int totalCarbs = reader.IsDBNull(reader.GetOrdinal("totalCarbs")) ? 0 : reader.GetInt32("totalCarbs");
                        int totalFat = reader.IsDBNull(reader.GetOrdinal("totalFat")) ? 0 : reader.GetInt32("totalFat");
                        int totalProtein = reader.IsDBNull(reader.GetOrdinal("totalProtein")) ? 0 : reader.GetInt32("totalProtein");
                        int SuperTotalCal = reader.IsDBNull(reader.GetOrdinal("SuperTotalCal")) ? 0 : reader.GetInt32("SuperTotalCal");
                        int cPercent = reader.IsDBNull(reader.GetOrdinal("CarbPercent")) ? 0 : reader.GetInt32("CarbPercent");
                        int fPercent = reader.IsDBNull(reader.GetOrdinal("FatPercent")) ? 0 : reader.GetInt32("FatPercent");
                        int pPercent = reader.IsDBNull(reader.GetOrdinal("ProteinPercent")) ? 0 : reader.GetInt32("ProteinPercent");

                        consumedBar.Maximum = SuperTotalCal;
                        consumedBar.Minimum = 0;
                        consumedBar.Value = totalCalories;
                        // Update the labels with total values
                        calRemain.Text = totalCalories.ToString();
                        carbRemain.Text = totalCarbs.ToString();
                        fatRemain.Text = totalFat.ToString();
                        proteinRemain.Text = totalProtein.ToString();

                        carbP.Text = cPercent.ToString() + "%";
                        fatP.Text = fPercent.ToString() + "%";
                        proteinP.Text = pPercent.ToString() + "%";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                myCon.closeCon();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void dashUsername_Click(object sender, EventArgs e)
        {

        }

        private void dashUsername_TextChanged(object sender, EventArgs e)
        {
            chartData();
            RemainingMacros();
            
        }

        private void calRemain_Click(object sender, EventArgs e)
        {
            
        }

        private void calRemain_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
