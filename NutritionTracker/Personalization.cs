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
        FailedMessage fm = new FailedMessage();
        SuccessMessage sm = new SuccessMessage();
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
                int water = int.Parse(waterBox.Text);
                int sleep = int.Parse(sleepBox.Text);
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

                    fm.Show();
                    fm.failedLbl.Text = "Invalid gender. Please enter 'Male' or 'Female'.";

                    return;
                }

                string updateFitnessDataQuery = @"UPDATE user_fitnessdata
                                JOIN user ON user.id = user_fitnessdata.user_id
                                JOIN user_lifestyle ON user_lifestyle.user_id = user_fitnessdata.user_id
                                SET 
                                    user_fitnessdata.weight = @new_weight,
                                    user_fitnessdata.age = @new_age,
                                    user_fitnessdata.gender = @new_gender,
                                    user_fitnessdata.weight_goal = @new_weight_goal,
                                    user_fitnessdata.target_weight = @new_target_weight,
                                    user_lifestyle.water = @new_water,
                                    user_lifestyle.sleep = @new_sleep
                                WHERE user.username = @username;";

                MySqlCommand updateFitnessDataCmd = new MySqlCommand(updateFitnessDataQuery, myCon.getCon());
                updateFitnessDataCmd.Parameters.AddWithValue("@new_weight", weight);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_age", age);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_gender", gender);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_weight_goal", weightGoal);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_target_weight", targetWeight);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_water", water);
                updateFitnessDataCmd.Parameters.AddWithValue("@new_sleep", sleep);
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

                    fm.Show();
                    fm.failedLbl.Text = "Error updating user fitness data";
                   
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

                sm.Show();
                sm.successLbl.Text = "Update Successful";

                personNameTxtBox.Enabled = false;
                personLastNTxtBox.Enabled = false;
                personGenderTxtBox.Enabled = false;
                personAgeTxtBox.Enabled = false;
                personWeightTxtBox.Enabled = false;
                personTargetWeight.Enabled = false;
                personGoal2TxtBox.Enabled = false;
                updateChangesBtn.Visible = false;
                waterBox.Enabled = false;
                sleepBox.Enabled = false;


                

                myCon.closeCon();
            }
            else
            {
              
                fm.Show();
                fm.failedLbl.Text = "Error updating user information";
            }
        }


        public void updateMacros()
        {
            try
            {
          
                string carbsText = carbsComboBox.Text.TrimEnd('%');
                string fatText = fatComboBox.Text.TrimEnd('%');
                string proteinText = proteinComboBox.Text.TrimEnd('%');

               
                int carbsPercent = int.Parse(carbsText);
                int fatPercent = int.Parse(fatText);
                int proteinPercent = int.Parse(proteinText);

               
                double totalPercentage = carbsPercent + fatPercent + proteinPercent;
                if (Math.Abs(totalPercentage - 100) > 0.01) 
                {
                    fm.Show();
                    fm.failedLbl.Text = ("The total percentage must be 100%. Please adjust the combo box selections.");
                    return;
                }

                if (!int.TryParse(pCalLabel.Text, out int updateCalories))
                {
                    fm.Show();
                    fm.failedLbl.Text = "Invalid calorie value.";
                    return;
           
                }

            
                int updateCarbs = (int)((carbsPercent / 100.0) * updateCalories / 4);
                int updateFats = (int)((fatPercent / 100.0) * updateCalories / 9);
                int updateProtein = (int)((proteinPercent / 100.0) * updateCalories / 4);

                string username = personUserNTxtBox.Text;

                myCon.openCon();

              
                string updateMacrosQuery = @"UPDATE user_macros 
                     JOIN user ON user.id = user_macros.user_id 
                     SET user_macros.calories = @new_calories,
                     user_macros.carbs = @new_carbs,
                     user_macros.fat = @new_fat,
                     user_macros.protein = @new_protein,
                     user_macros.carb_percent = @carb_percent,
                     user_macros.fat_percent = @fat_percent,
                     user_macros.protein_percent = @protein_percent
                     WHERE user.username = @username";

                MySqlCommand updateMacrosCmd = new MySqlCommand(updateMacrosQuery, myCon.getCon());
                updateMacrosCmd.Parameters.AddWithValue("@new_calories", updateCalories);
                updateMacrosCmd.Parameters.AddWithValue("@new_carbs", updateCarbs);
                updateMacrosCmd.Parameters.AddWithValue("@new_fat", updateFats);
                updateMacrosCmd.Parameters.AddWithValue("@new_protein", updateProtein);
                updateMacrosCmd.Parameters.AddWithValue("@carb_percent", carbsPercent);
                updateMacrosCmd.Parameters.AddWithValue("@fat_percent", fatPercent);
                updateMacrosCmd.Parameters.AddWithValue("@protein_percent", proteinPercent);
                updateMacrosCmd.Parameters.AddWithValue("@username", username);

                int rows = updateMacrosCmd.ExecuteNonQuery();
                if (rows > 0)
                {
               
                    sm.Show();
                    sm.successLbl.Text = "Update Successfully";
                    UpdateMacrosChangesBtn.Visible = false;
                    pCalLabel.BorderThickness = 0;

                    pCarbLabel.Text = updateCarbs.ToString();
                    pFatLabel.Text = updateFats.ToString();
                    pProteinLabel.Text = updateProtein.ToString();

                    carbsComboBox.Text = carbsPercent.ToString();
                    proteinComboBox.Text = proteinPercent.ToString();
                    fatComboBox.Text = fatPercent.ToString();

                    carbsComboBox.Enabled = false;
                    fatComboBox.Enabled = false;
                    proteinComboBox.Enabled = false;
                }
                else
                {
           
                    fm.Show();
                    fm.failedLbl.Text = "Error Update";
                }

                myCon.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
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
            waterBox.Enabled = true;
            sleepBox.Enabled = true;


        }

        private void personFitnessGoalsEditBtn_Click(object sender, EventArgs e)
        {
            UpdateMacrosChangesBtn.Visible = true;
            
            carbsComboBox.Enabled = true;
            fatComboBox.Enabled = true;
            proteinComboBox.Enabled = true;
            pCalLabel.Enabled = true;
            pCalLabel.BorderThickness = 1;



        }

        private void UpdateMacrosChangesBtn_Click(object sender, EventArgs e)
        {
            updateMacros();
        }

        private void waterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void personAgeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void personWeightTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void personTargetWeight_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sleepBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pCalLabel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                fm.Show();
                fm.failedLbl.Text = "Please enter only numeric values.\", \"Invalid Input";
            }
            else
            {
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void caloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
