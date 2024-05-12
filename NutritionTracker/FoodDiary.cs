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
    public partial class FoodDiary : Form
    {
        public FoodDiary()
        {
            InitializeComponent();
        }
        #region TabPanels
        void loadForm(Form panel)
        {
            mainPanel.Controls.Clear();
            panel.TopLevel = false;
            mainPanel.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
        }
        #endregion
        private void addFoodBtn_Click(object sender, EventArgs e)
        {
            loadForm(new FormAddFood());
            fdPanel.Visible = false;
            fdTotalPanel.Visible = false;
            FDLabel.Visible = false;
            totalTxtPanel.Visible = false;
        }
    }
}
