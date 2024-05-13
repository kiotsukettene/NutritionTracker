using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NutritionTracker
{
    public partial class Personalization : Form
        
    {
        public event EventHandler DataUpdated;
        DBConnection myCon = new DBConnection();
        
        public Personalization()
        {
            InitializeComponent();
            
        }
        public void UpdateFitnessData()
        {
            try
            {
                myCon.openCon();

                string username = personUserNTxtBox.Text;
                string genderString = personGenderTxtBox.Text;
                int age = int.Parse(personAgeTxtBox.Text);
                int weight = int.Parse(personWeightTxtBox.Text);
                int targetWeight = int.Parse(personTargetWeight.Text);
                string weightGoal = personGoal2TxtBox.Text;
                int gender;
                if (personGenderTxtBox.Text == "Male")
                {
                    gender = 0;

                }
                else if (personGenderTxtBox.Text == "Female")
                {
                    gender = 1;
                }
                else
                {
                    MessageBox.Show("Invalid gender. Please enter 'Male' or 'Female'.");
                    return;
                }

                string updateFitnessDataQuery = @"UPDATE user_fitnessdata
                                JOIN user ON user.id = user_fitnessdata.user_id
                                SET 
                                    user_fitnessdata.weight = @new_weight,
                                    user_fitnessdata.age = @new_age,
                                    user_fitnessdata.gender = @new_gender,
                                    user_fitnessdata.weight_goal = @new_weight_goal,
                                    user_fitnessdata.target_weight = @new_target_weight
                                WHERE user.username = @username;";

                MySqlCommand updateFitnessDataCmd = new MySqlCommand(updateFitnessDataQuery, myCon.getCon());
                updateFitnessDataCmd.Parameters.AddWithValue("@new_weight", weight);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_age", age);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_gender", gender);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_weight_goal", weightGoal);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_target_weight", targetWeight);
                updateFitnessDataCmd.Parameters.AddWithValue("@username", username);


                int rowsAffected = updateFitnessDataCmd.ExecuteNonQuery();
                
                if (rowsAffected > 0)
                {
                   
                   
                    personAgeTxtBox.Text = age.ToString();
                    personTargetWeight.Text = targetWeight.ToString();
                    personWeightTxtBox.Text = weight.ToString();

                    

                }
                else
                {

                    MessageBox.Show("Error updating user fitness data");
                }
                myCon.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                myCon.closeCon();
            }
        }

        public void UpdateOnDashboard()
        {
            myCon.openCon();
            string firstname = personNameTxtBox.Text;
            string lastname = personLastNTxtBox.Text;
            string username = personUserNTxtBox.Text;
            string updateUserQuery = @"UPDATE user
                                SET firstname = @new_firstname,
                                    lastname = @new_lastname
                                WHERE username = @username;";

            MySqlCommand updateUserCmd = new MySqlCommand(updateUserQuery, myCon.getCon());
            updateUserCmd.Parameters.AddWithValue("@new_firstname", firstname);
            updateUserCmd.Parameters.AddWithValue("@new_lastname", lastname);
            updateUserCmd.Parameters.AddWithValue("@username", username);


            int userRowsAffected = updateUserCmd.ExecuteNonQuery();

            if (userRowsAffected > 0)
            {

                MessageBox.Show("Update Successful");
                personNameTxtBox.Enabled = false;
                personLastNTxtBox.Enabled = false;
                personGenderTxtBox.Enabled = false;
                personAgeTxtBox.Enabled = false;
                personWeightTxtBox.Enabled = false;
                personTargetWeight.Enabled = false;
                personGoal2TxtBox.Enabled = false;
                updateChangesBtn.Visible = false;

                

                myCon.closeCon();
            }
            else
            {

                MessageBox.Show("Error updating user information");
            }
        }

        private void updateChangesBtn_Click(object sender, EventArgs e)
        {
            UpdateFitnessData();
            UpdateOnDashboard();
        }

        private void personInfoEditBtn_Click(object sender, EventArgs e)
        {
            personNameTxtBox.Enabled = true;
            personLastNTxtBox.Enabled = true;
            personGenderTxtBox.Enabled = true;
            personAgeTxtBox.Enabled = true;
            personWeightTxtBox.Enabled = true;
            personTargetWeight.Enabled = true;
            personGoal2TxtBox.Enabled = true;
            updateChangesBtn.Visible = true;
        }
    }
}
