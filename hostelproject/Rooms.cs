using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostelproject
{
    public partial class Rooms : Form
    {
        function fn = new function();
        String query;
        public Rooms()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            query = "Select * from Rooms";
            DataSet ds = fn.getdata(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            query = "select * from Rooms where room_number=" +txtRoomno.Texts +"";
            DataSet ds = fn.getdata(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                String occupancy_status;
                if(checkBox1.Checked)
                {
                    occupancy_status = "";
                }
                else
                {
                    occupancy_status = "";
                }
                query="insert into Rooms (room_number,occupancy_status) values("+txtRoomno.Texts+", "+ occupancy_status+")";
                fn.setdata(query, "Room added");

            }
            else
            {
                MessageBox.Show("ROOM ALREADY EXISTS!");
            }
        }
    }
}
