using System.Drawing.Text;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hostelproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void validateuser(string username, string password)
        {



        }
       // private bool AuthenticateUser(string username, string password)
        
         //   using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-8U5IBFR5;Initial Catalog=hostel;Integrated Security=True"))
            
              //  string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
              //  SqlCommand command = new SqlCommand(query, connection);
                //command.Parameters.AddWithValue("@username", username);
                //command.Parameters.AddWithValue("@password", password);

                //connection.Open();
                //int result = (int)command.ExecuteScalar();

                //return result > 0;
            //}
        //}
        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            ////validateuser(txtuser.Text, txtpass.Text);
            //if (txtuser.Text == "admin" && txtpass.Text == "123")
            //{
            this.Hide();
            // HomeAdmin hm = new HomeAdmin();
           // hm.Show();
            HomeStudent hs= new HomeStudent();
           hs.Show();
            //}
            //else
            //{
            //    string username = txtuser.Text;
            //    string password = txtpass.Text;

            //    if (AuthenticateUser(username, password))
            //    {
            //        MessageBox.Show("Login successful!");
            //        // Perform any additional actions after successful login
            //        HomeStudent hs = new HomeStudent();
            //        hs.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid username or password!");
            //    }
            //}
           // string username = txtuser.Text;
            ////string password = txtpass.Text;

           // if (AuthenticateUser(txtuser.Text, txtpass.Text))
            //{
              //  if (username == "admin")
                //{
                  //  MessageBox.Show("Welcome, Admin!");
                    // Open Admin Home page
                //}
                //else
                //{
                  //  MessageBox.Show("Welcome, Student!");
                    // Open Student Home page
                //}
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password!");
            //}


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoncustom2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Signup sg = new Signup();
            sg.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}