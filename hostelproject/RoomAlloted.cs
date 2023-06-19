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
    public partial class RoomAlloted : Form
    {
        public RoomAlloted()
        {
            InitializeComponent();
        }

        private void RoomAvailability_Load(object sender, EventArgs e)
        {

        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
