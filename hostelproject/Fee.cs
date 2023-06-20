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
    public partial class Fee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Fee()
        {
            InitializeComponent();
        }
        private void populate()
        {
            string query = "SELECT * FROM Fee";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                {
                    con.Open();

                    string feeIdInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the Challan No:", "Update Fee Status", "");

                    int feeId;
                    if (!int.TryParse(feeIdInput, out feeId))
                    {
                        MessageBox.Show("Invalid Fee ID. Please enter a numeric value.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand("UpdateFeeStatusToPaid", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ChallanNo", feeId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fee status updated to paid for Fee ID: " + feeId);
                            populate(); // Refresh the data in the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No fee record found for Fee ID: " + feeId);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle the SQL exception here
                MessageBox.Show("An error occurred while updating the fee status: " + ex.Message);
            }

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncustom3_Click(object sender, EventArgs e)
        {

        }
    }
}
