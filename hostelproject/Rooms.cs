using System.Data;

namespace hostelproject
{
    public partial class Rooms : Form
    {
        // Create an instance of the function class
        private function fn = new function();

        public Rooms()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Rooms";
            DataSet ds = fn.getdata(query);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                // Handle the case when the DataSet or Tables collection is null or empty
                // For example, you can display a message or clear the DataGridView
                dataGridView1.DataSource = null;
                MessageBox.Show("No data found.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Retrieve the values from the selected row in the DataGridView
                string room_type = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int room_number = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

                // Populate the UI controls with the retrieved values
                txtRoomno.Text = room_type;
                comboBox1.Text = room_number.ToString();
            }
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            buttoncustom1_Click(sender, e, fn);
        }

        private void buttoncustom1_Click(object sender, EventArgs e, function fn)
        {
            string roomNumber = txtRoomno.Text.Trim();

            if (!string.IsNullOrEmpty(roomNumber))
            {
                string query = "SELECT * FROM Rooms WHERE room_number = '" + roomNumber + "'";
                DataSet ds = fn.getdata(query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count == 0)
                {
                    string occupancy_status = checkBox1.Checked ? "Occupied" : "Vacant";
                    string room_type = "Standard"; // Set the appropriate room type here
                    query = "INSERT INTO Rooms (room_number, room_type, occupancy_status) VALUES ('" + roomNumber + "', '" + room_type + "', '" + occupancy_status + "')";
                    fn.setdata(query, "Room added");

                    LoadData(); // Refresh the DataGridView after adding the new room
                }
                else
                {
                    MessageBox.Show("ROOM ALREADY EXISTS!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a room number.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

