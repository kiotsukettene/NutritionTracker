using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NutritionTracker
{
    internal class DBConnection
    {
        public MySqlConnection con = new MySqlConnection("Datasource=localhost; user=root; password=;database=nutritrack");
        
        public MySqlConnection getCon()
        {
            return con;
        }

        public void openCon()
        {
            try { 
                con.Open();
            } catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }

        public void closeCon()
        {
            try
            {
                con.Close();
            }
            catch(Exception e)
            {
               MessageBox.Show("Error: " + e);
            }
        }
    }
}
