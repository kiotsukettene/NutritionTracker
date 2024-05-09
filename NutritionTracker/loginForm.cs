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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
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
        #region TabPanels
        public void loadForm(object Form)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            if (f != null)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(f);
                mainPanel.Tag = f;
                f.Show();
            }
        }
        #endregion 
        private void loginForm_Load(object sender, EventArgs e)
        {
            RoundCorners();
            loadForm(new login());
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

     
    }
}
