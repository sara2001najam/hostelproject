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

        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom8_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom14_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoncustom1_Click_1(object sender, EventArgs e)
        {
            HostelStaff hs = new HostelStaff();
            hs.Show();
        }

        private void buttoncustom8_Click_1(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
        }

        private void buttoncustom2_Click_1(object sender, EventArgs e)
        {
            utilitybills ut = new utilitybills();
            ut.Show();
        }

        private void buttoncustom11_Click(object sender, EventArgs e)
        {
            Actcalen ac = new Actcalen();
            ac.Show();
        }

        private void buttoncustom10_Click(object sender, EventArgs e)
        {
            Rooms rm = new Rooms();
            rm.Show();
        }

        private void buttoncustom12_Click(object sender, EventArgs e)
        {
            Fee_info fi = new Fee_info();
            fi.Show();
        }

        private void buttoncustom9_Click_1(object sender, EventArgs e)
        {
            ComplaintsAdmin ca = new ComplaintsAdmin();
            ca.Show();
        }

        private void buttoncustom3_Click_1(object sender, EventArgs e)
        {
            Studentinfo si = new Studentinfo();
            si.Show();
        }
    }
}
