﻿using System;
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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginBtn(object sender, EventArgs e)
        {
            this.Dispose();
            loginForm login = new loginForm();
            login.Show();
            
        }
    }
}
