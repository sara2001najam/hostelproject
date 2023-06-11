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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoncustom8_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();

        }

        private void buttoncustom9_Click(object sender, EventArgs e)
        {
            Complaints cp = new Complaints();
            cp.Show();
        }

        private void buttoncustom11_Click(object sender, EventArgs e)
        {
            Actcalen ac = new Actcalen();
            ac.Show();
        }

        private void buttoncustom12_Click(object sender, EventArgs e)
        {
            Feechallan fe = new Feechallan();
            fe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
