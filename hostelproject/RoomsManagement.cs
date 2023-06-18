﻿using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace hostelproject
{
    public partial class RoomsManagement : Form
    {
        // Create an instance of the function class
        private function fn = new function();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public RoomsManagement()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void populate()
        {
            con.Open();
            string query = "select * from Rooms";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomno.Texts;
            string roomType = comboBox1.SelectedItem.ToString();
            string occupancyStatus = "vacant";

            // Replace with your actual connection string
            string query = "INSERT INTO Rooms (room_number, room_type, occupancy_status) VALUES (@RoomNumber, @RoomType, @OccupancyStatus)";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                con.Open();
                command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@OccupancyStatus", occupancyStatus);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Room inserted successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to insert room!");
                }
            }
            con.Close();
            populate();
        }

        private void buttoncustom1_Click(object sender, EventArgs e, function fn)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void LoadRooms()
        //{
        //    string query = "SELECT room_id, room_number FROM Rooms WHERE occupancy_status = 'Vacant';";

        //    using (SqlCommand command = new SqlCommand(query, con))
        //    {
        //        con.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        // Clear existing items in the combobox
        //        comboBox2.Items.Clear();

        //        while (reader.Read())
        //        {
        //            int roomId = (int)reader["room_id"];
        //            string roomNumber = (string)reader["room_number"];
        //            Room room = new Room(roomId, roomNumber);

        //            comboBox2.Items.Add(room);
        //        }

        //        reader.Close();
        //    }
        //}

        //private void buttoncustom3_Click(object sender, EventArgs e)
        //{

        //    if (comboBox2.SelectedIndex == 0 || string.IsNullOrEmpty(txtxtdID.Text))
        //    {
        //        MessageBox.Show("Please select a room and enter a student ID.");
        //        return;
        //    }

        //    Room selectedRoom = (Room)comboBox2.SelectedItem;
        //    int studentId;

        //    if (!int.TryParse(txtxtdID.Text, out studentId))
        //    {
        //        MessageBox.Show("Invalid student ID. Please enter a numeric value.");
        //        return;
        //    }
        //    string updateRoomQuery = "UPDATE Rooms SET occupancy_status = 'Occupied', student_id = @studentId WHERE room_id = @roomId;";
        //    string updateStudentQuery = "UPDATE Student SET room_id = @roomId WHERE student_id = @studentId;";


        //    using (SqlCommand updateRoomCommand = new SqlCommand(updateRoomQuery, con))
        //    {
        //        updateRoomCommand.Parameters.AddWithValue("@studentId", studentId);
        //        updateRoomCommand.Parameters.AddWithValue("@roomId", selectedRoom.RoomId);
        //        SqlCommand updateStudentCommand = new SqlCommand(updateStudentQuery, con);
        //        updateStudentCommand.Parameters.AddWithValue("@studentId", studentId);
        //        updateStudentCommand.Parameters.AddWithValue("@roomId", selectedRoom.RoomId);

        //        con.Open();
        //        SqlTransaction transaction = con.BeginTransaction();
        //        try
        //        {
        //            updateRoomCommand.Transaction = transaction;
        //            updateStudentCommand.Transaction = transaction;

        //            int roomsUpdated = updateRoomCommand.ExecuteNonQuery();
        //            int studentsUpdated = updateStudentCommand.ExecuteNonQuery();

        //            if (roomsUpdated > 0 && studentsUpdated > 0)
        //            {
        //                transaction.Commit();
        //                MessageBox.Show("Room allocated successfully.");
        //                LoadRooms(); // Refresh the available rooms list
        //            }
        //            else
        //            {
        //                transaction.Rollback();
        //                MessageBox.Show("Failed to allocate room.");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            MessageBox.Show("An error occurred while allocating the room: " + ex.Message);
        //        }
        //    }
        //}

        //public class Room
        //{
        //    public int RoomId { get; set; }
        //    public string RoomNumber { get; set; }

        //    public Room(int roomId, string roomNumber)
        //    {
        //        RoomId = roomId;
        //        RoomNumber = roomNumber;
        //    }

        //    public override string ToString()
        //    {
        //        return RoomNumber;
        //    }
        //}

        private void RoomsManagement_Load(object sender, EventArgs e)
        {

        }
        //public class Room
        //{
        //    public int RoomId { get; set; }
        //    public string RoomNumber { get; set; }
        //    public string RoomType { get; set; }
        //    public string OccupancyStatus { get; set; }

        //    public Room(int roomId, string roomNumber, string roomType, string occupancyStatus)
        //    {
        //        RoomId = roomId;
        //        RoomNumber = roomNumber;
        //        RoomType = roomType;
        //        OccupancyStatus = occupancyStatus;
        //    }

        //    public override string ToString()
        //    {
        //        return RoomNumber;
        //    }
        //}
        //private void buttoncustom2_Click(object sender, EventArgs e)
        //{
        //    //string searchTerm = txtsrch.Text.Trim();

        //string connectionString = "your_connection_string"; // Replace with your actual connection string

        //using (SqlConnection connection = new SqlConnection(connectionString))
        //{
        //    string query = "SELECT room_id, room_number, room_type, occupancy_status FROM Rooms WHERE room_number LIKE @SearchTerm";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

        //    connection.Open();

        //    SqlDataReader reader = command.ExecuteReader();

        //    listBox1.Items.Clear();

        //    while (reader.Read())
        //    {
        //        int roomId = (int)reader["room_id"];
        //        string roomNumber = (string)reader["room_number"];
        //        string roomType = (string)reader["room_type"];
        //        string occupancyStatus = (string)reader["occupancy_status"];

        //        Room room = new Room(roomId, roomNumber, roomType, occupancyStatus);
        //        listBox1.Items.Add(room);
        //    }

        //    reader.Close();


    }
}



