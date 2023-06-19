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
using System.Xml.Linq;

namespace hostelproject
{
    public partial class Studentinfo : Form
    {
        private function fn = new function();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Studentinfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    string name = stdname.Texts;
                    string email = stdemail.Texts;
                    string enrollno = stdenrollno.Texts;
                    string phone = stdphoneno.Texts;
                    string address = stdaddress.Texts;
                    int room_id = int.Parse(txtroomid.Text);
                    DateTime dateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
                    string fathername = txtfname.Texts;

                    SqlCommand command = new SqlCommand("InsertStudent", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@enrollno", enrollno);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@room_id", room_id);
                    command.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                    command.Parameters.AddWithValue("@father_name", fathername);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Student data inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //fn.getdata();
            //populate();
        }

        public void populate()
        {
            con.Open();
            string query = "select * from Student";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void buttoncustom5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    connection.Open();

                    string email = stdemail.Text;
                    string phone = stdphoneno.Text;

                    string address = stdaddress.Text;
                    int room_id = int.Parse(txtroomid.Text);



                    SqlCommand command = new SqlCommand("UpdateStudent", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    //command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@room_id", room_id);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student data updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No student record found with the provided email and phone number.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();

        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int studentId = int.Parse(stdUsn.Text);

                    SqlCommand command = new SqlCommand("DeleteStudent", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@student_id", studentId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student data deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No student record found with the provided student ID.");
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

        private void txtroomid_Click(object sender, EventArgs e)
        {

        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}


