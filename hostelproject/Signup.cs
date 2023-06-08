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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btssignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SIGN UP SUCCESSFULL");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fs = new Form1();
            fs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxcustom3__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom4__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom5__Textchanged(object sender, EventArgs e)
        {

        }

        private void txtuser__Textchanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SIGN UP SUCCESSFULL");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
