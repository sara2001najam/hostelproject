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
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True");

        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btssignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SIGN UP SUCCESSFULL");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fs = new Form1();
            fs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textboxcustom3__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom4__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom5__Textchanged(object sender, EventArgs e)
        {

        }

        private void txtuser__Textchanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            string fullName = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtpass.Text;
            string confirmPassword = txtcpass.Text;

            try
            {
                //using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
                //{
                    con.Open();
                    //if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                    //{
                    //    MessageBox.Show("Please fill in all the fields.");

                    //}
                    //else if (password != confirmPassword)
                    //{
                    //    MessageBox.Show("Password and confirm password do not match.");
                        
                    //}                   
                    string query = "INSERT INTO Signup (FullName, Email, Password) VALUES (@FullName, @Email, @Password)";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Signup successful!");
                  
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
      
    }
}


