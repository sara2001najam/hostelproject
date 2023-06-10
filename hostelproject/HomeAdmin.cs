using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostelproject
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void buttoncustom9_Click(object sender, EventArgs e)
        {

        }
        private void button2_click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoncustom7_Click(object sender, EventArgs e)
        {
            Rooms rm = new Rooms();
            rm.Show();
        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {
            Actcalen ac = new Actcalen();
            ac.Show();
        }

        private void buttoncustom8_Click(object sender, EventArgs e)
        {
            utilitybills us = new utilitybills();
            us.Show();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void buttoncustom14_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 278)
            {
                panel2.Height = 68;
            }
            else
            {
                panel2.Height = 278;
            }
        }

        private void buttoncustom13_Click(object sender, EventArgs e)
        {

        }
    }
}
