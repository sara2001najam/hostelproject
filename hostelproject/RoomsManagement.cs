using System.Data;

namespace hostelproject
{
    public partial class RoomsManagement : Form
    {
        // Create an instance of the function class
        private function fn = new function();

        public RoomsManagement()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            buttoncustom1_Click(sender, e, fn);
        }

        private void buttoncustom1_Click(object sender, EventArgs e, function fn)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

