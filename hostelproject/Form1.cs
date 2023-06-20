using System.Drawing.Text;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

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


        private void txtuser_TextChanged(object sender, EventArgs e)
        {



        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EH07IIP;Initial Catalog=HostelMn;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND pass = @pass";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", txtuser.Text);
                command.Parameters.AddWithValue("@pass", txtpass.Text);
                //int result=command.ExecuteNonQuery();
                //int result = (int)command.ExecuteScalar();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                //}


                //if (AuthenticateUser(txtuser.Text, txtpass.Text))
                //{
                if (txtuser.Text == "admin")
                {
                    this.Hide();
                    HomeAdmin ha = new HomeAdmin();
                    ha.Show();
                }
                else
                {
                    this.Hide();
                    HomeStudent hs = new HomeStudent();
                    hs.Show();
                }
            }
            // }
            //else
            //{
            //    MessageBox.Show("Invalid username or password!");
            //}
        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
        }
    }
}
