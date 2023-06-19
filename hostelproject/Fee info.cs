using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostelproject
{
    public partial class Fee_info : Form
    {
        public Fee_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            txtResult.Text += "\n\n";

            txtResult.Text += "\t***********************************************\n";
            txtResult.Text += "\t*************    FEE CHALLAN    ***************\n";
            txtResult.Text += "\t***********************************************\n\n";


            txtResult.Text += "\tDate: " + DateTime.Now + "\n\n";

            txtResult.Text += "\tPaymentID: " + txtPaymentId.Texts + "\n\n";
            txtResult.Text += "\tStudentName: " + txtStudentName.Texts + "\n\n";
            txtResult.Text += "\tEnrollment: " + txtEnrollment.Texts + "\n\n";
            txtResult.Text += "\tRoomNumber: " + txtRoomNumber.Texts + "\n\n";

            txtResult.Text += "\tAmount: 250000\n\n";

            txtResult.Text += "\t***********************************************";






        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft sans serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
