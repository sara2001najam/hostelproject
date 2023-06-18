﻿using System;
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
    public partial class utilitybills : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");
        public utilitybills()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void populate()
        {
            string query = "SELECT * FROM UtilityBills";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private string[] GenerateUtilityBills()
        {
            string[] bills = new string[7];

            // Generate random utility bill amounts for each day
            bills[0] = GenerateRandomAmount(); // Monday
            bills[1] = GenerateRandomAmount(); // Tuesday
            bills[2] = GenerateRandomAmount(); // Wednesday
            bills[3] = GenerateRandomAmount(); // Thursday
            bills[4] = GenerateRandomAmount(); // Friday
            bills[5] = GenerateRandomAmount(); // Saturday
            bills[6] = GenerateRandomAmount(); // Sunday

            return bills;
        }

        private string GenerateRandomAmount()
        {
            Random random = new Random();
            decimal amount = (decimal)random.Next(50, 200);

            return amount.ToString("10000");
        }

        private void textboxcustom1__Textchanged(object sender, EventArgs e)
        {

        }
        private void buttoncustom4_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                DateTime startDate = new DateTime(2023, 6, 1); // Start date of the month
                DateTime endDate = new DateTime(2023, 6, 30); // End date of the month

                DateTime currentDate = startDate;

                while (currentDate <= endDate)
                {
                    // Generate the utility bills for the current week
                    string[] bills = GenerateUtilityBills();

                    // Create the INSERT statement
                    string query = "INSERT INTO UtilityBills (UtilityType, Amount, DueDate, IsPaid) " +
                                   "VALUES (@UtilityType,  @Amount , @DueDate, @IsPaid)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@UtilityType", "Electricity, Gas, Water"); // Replace with the appropriate utility type
                        command.Parameters.AddWithValue("@Amount", 10000);
                        command.Parameters.AddWithValue("@DueDate", currentDate.AddDays(7));
                        command.Parameters.AddWithValue("@IsPaid", false);

                        // Execute the INSERT statement
                        command.ExecuteNonQuery();
                    }

                    // Move to the next week
                    currentDate = currentDate.AddDays(7);
                }

                MessageBox.Show("Utility bills for the month generated successfully!");
            }
            catch (SqlException ex)
            {
                // Handle the SQL exception here
                MessageBox.Show("An error occurred while generating the utility bills: " + ex.Message);
            }
            finally
            {
                con.Close();
                populate(); // Refresh the data in the DataGridView
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string billIdInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the Bill ID:", "Update Utility Bill Status", "");

                int billId;
                if (!int.TryParse(billIdInput, out billId))
                {
                    MessageBox.Show("Invalid Bill ID. Please enter a numeric value.");
                    return;
                }
                // int weekId = 15; // The week ID for which you want to update the status to paid

                // Update the status of the utility bill
                string updateQuery = "UPDATE UtilityBills SET IsPaid = 1 WHERE BillId = @BillId";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
                {
                    updateCommand.Parameters.AddWithValue("@BillId", billId);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Utility bill status updated to paid for Week ID: " + billId);
                        populate(); // Refresh the data in the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No utility bill found for Week ID: " + billId);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle the SQL exception here
                MessageBox.Show("An error occurred while updating the utility bill status: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
