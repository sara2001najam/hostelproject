﻿using System;
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
    public partial class HomeStudent : Form
    {
        public HomeStudent()
        {
            InitializeComponent();
        }

        private void buttoncustom7_Click(object sender, EventArgs e)
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

        private void hostelproject_Load(object sender, EventArgs e)
        {
            panel2.Height = 68;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {


        }

        private void buttoncustom12_Click(object sender, EventArgs e)
        {
            Feechallan fe = new Feechallan();
            fe.Show();
        }

        private void buttoncustom11_Click(object sender, EventArgs e)
        {
            Actcalen ac = new Actcalen();
            ac.Show();
        }

        private void buttoncustom10_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
            p.Show();
        }

        private void buttoncustom9_Click(object sender, EventArgs e)
        {
            Complaints cp = new Complaints();
            cp.Show();
        }

        private void buttoncustom8_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
        }
    }
}
