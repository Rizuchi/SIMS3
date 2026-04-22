using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIMS3
{
    public partial class SplashForm : Form
    {
        int progress = 0;
        public SplashForm()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progress++;

            progressBar1.Value = progress;

            if (progress >= 100)
            {
                timer2.Stop();

                LoginForm main = new LoginForm();
                main.Show();
                this.Hide();
            }
        }
    }
}
