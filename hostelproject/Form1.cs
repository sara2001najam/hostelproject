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

        private void textboxcustom1__Textchanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text changed");
        }

        private void textboxcustom3__Textchanged(object sender, EventArgs e)
        {

        }

        private void textboxcustom1__Textchanged_1(object sender, EventArgs e)
        {

        }

        private void buttoncustom2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttoncustom1_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomeAdmin fs = new HomeAdmin();
            fs.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}