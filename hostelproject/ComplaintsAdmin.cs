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
    public partial class ComplaintsAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public ComplaintsAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void populate()
        {
            con.Open();
            string query = "select * from Complaint";
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

        private void btnDis_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            try
            {
                string enrollmentNumber = Microsoft.VisualBasic.Interaction.InputBox("Enter Enrollment Number:", "Update Complaint Status");

                if (!string.IsNullOrEmpty(enrollmentNumber))
                {
                    string query = "EXEC [UpdateComplaintStatus] @enrollno, @status";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@enrollno", enrollmentNumber);
                        command.Parameters.AddWithValue("@status", "Complete");
                        con.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Complaint status updated successfully!");
                        lbll.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("Enrollment number cannot be empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }


            populate(); // Assuming this function retrieves and displays the updated complaints data

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbll.Visible=false;

        }
    }
}
