using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace hostelproject
{
    public partial class HostelStaff : Form
    {
        private function fn = new function();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public HostelStaff()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            // txtxStaffId.Texts = "abc";
            ////  int StaffId = int.Parse(txtxStaffId.Texts);
            // Use the number variable here

            string name = txtname.Texts;
            string email = txtemail.Texts;
            string phone = txtphone.Texts;
            string address = txtAddress.Texts;
            string position = cmbposition.SelectedItem.ToString();
            string status = cmbstatus.SelectedItem.ToString();

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("InsertStaff", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // command.Parameters.AddWithValue("@staff_id", StaffId);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@status", status);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Staff data inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //fn.getdata();
            populate();
        }

        public void populate()
        {
            con.Open();
            string query = "select * from Staff";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    int staffid = int.Parse(txtid.Texts);// Replace with the actual staff ID you want to update
                    string email = txtemail.Texts;
                    string phone = txtphone.Texts;
                    string position = cmbposition.SelectedItem.ToString();
                    string address = txtAddress.Texts;
                    string status = cmbstatus.SelectedItem.ToString();

                    SqlCommand command = new SqlCommand("UpdateStaff", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@staff_id", staffid);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@position", position);
                    // command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@address", address);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Staff data updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //fn.getdata();
            populate();
        }

        private void buttoncustom4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    con.Open();

                    int? staffId = int.TryParse(txtid.Text, out int id) ? id : (int?)null;
                    string name = txtname.Text;

                    SqlCommand command = new SqlCommand("SearchStaff", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@staff_id", staffId);
                    command.Parameters.AddWithValue("@name", name);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Display the search results by binding the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No staff records found with the provided ID or name.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int? staffId = int.TryParse(txtid.Texts, out int id) ? id : (int?)null;
                    string name = txtname.Texts;

                    SqlCommand command = new SqlCommand("DeleteStaff", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@staff_id", staffId);
                    command.Parameters.AddWithValue("@name", name);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Staff data deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No staff record found with the provided ID or name.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            //fn.getdata();
            populate();
        }

        private void buttoncustom5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void HostelStaff_Load(object sender, EventArgs e)
        {

        }
    }

}

