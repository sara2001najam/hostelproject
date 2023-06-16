namespace hostelproject
{
    partial class Studentinfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studentinfo));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            buttoncustom4 = new Buttoncustom();
            buttoncustom3 = new Buttoncustom();
            buttoncustom2 = new Buttoncustom();
            buttoncustom1 = new Buttoncustom();
            stdemail = new Textboxcustom();
            stdUsn = new Textboxcustom();
            label12 = new Label();
            stdname = new Textboxcustom();
            label1 = new Label();
            stdenrollno = new Textboxcustom();
            label2 = new Label();
            label3 = new Label();
            stdphoneno = new Textboxcustom();
            label4 = new Label();
            label5 = new Label();
            stdaddress = new Textboxcustom();
            label6 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            buttoncustom5 = new Buttoncustom();
            textboxcustom1 = new Textboxcustom();
            txtroomid = new Label();
            label7 = new Label();
            txtfname = new Textboxcustom();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 49);
            panel1.TabIndex = 70;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1278, 0);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(72, 49);
            button2.TabIndex = 15;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(897, 123);
            label8.Name = "label8";
            label8.Size = new Size(180, 28);
            label8.TabIndex = 72;
            label8.Text = "STUDENT LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Highlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(674, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(586, 453);
            dataGridView1.TabIndex = 71;
            // 
            // buttoncustom4
            // 
            buttoncustom4.BackColor = Color.CornflowerBlue;
            buttoncustom4.BorderColor = Color.Black;
            buttoncustom4.BorderRadius = 40;
            buttoncustom4.BorderSize = 0;
            buttoncustom4.FlatAppearance.BorderSize = 0;
            buttoncustom4.FlatStyle = FlatStyle.Flat;
            buttoncustom4.ForeColor = Color.White;
            buttoncustom4.Location = new Point(506, 66);
            buttoncustom4.Name = "buttoncustom4";
            buttoncustom4.Size = new Size(148, 45);
            buttoncustom4.TabIndex = 76;
            buttoncustom4.Text = "SEARCH";
            buttoncustom4.UseVisualStyleBackColor = false;
            // 
            // buttoncustom3
            // 
            buttoncustom3.BackColor = Color.CornflowerBlue;
            buttoncustom3.BorderColor = Color.Black;
            buttoncustom3.BorderRadius = 40;
            buttoncustom3.BorderSize = 0;
            buttoncustom3.FlatAppearance.BorderSize = 0;
            buttoncustom3.FlatStyle = FlatStyle.Flat;
            buttoncustom3.ForeColor = Color.White;
            buttoncustom3.Location = new Point(352, 589);
            buttoncustom3.Name = "buttoncustom3";
            buttoncustom3.Size = new Size(148, 45);
            buttoncustom3.TabIndex = 75;
            buttoncustom3.Text = "DELETE";
            buttoncustom3.UseVisualStyleBackColor = false;
            buttoncustom3.Click += buttoncustom3_Click;
            // 
            // buttoncustom2
            // 
            buttoncustom2.BackColor = Color.CornflowerBlue;
            buttoncustom2.BorderColor = Color.Black;
            buttoncustom2.BorderRadius = 40;
            buttoncustom2.BorderSize = 0;
            buttoncustom2.FlatAppearance.BorderSize = 0;
            buttoncustom2.FlatStyle = FlatStyle.Flat;
            buttoncustom2.ForeColor = Color.White;
            buttoncustom2.Location = new Point(198, 608);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(148, 45);
            buttoncustom2.TabIndex = 74;
            buttoncustom2.Text = "UPDATE";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click;
            // 
            // buttoncustom1
            // 
            buttoncustom1.BackColor = Color.CornflowerBlue;
            buttoncustom1.BorderColor = Color.Black;
            buttoncustom1.BorderRadius = 40;
            buttoncustom1.BorderSize = 0;
            buttoncustom1.FlatAppearance.BorderSize = 0;
            buttoncustom1.FlatStyle = FlatStyle.Flat;
            buttoncustom1.ForeColor = Color.White;
            buttoncustom1.Location = new Point(41, 589);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(148, 45);
            buttoncustom1.TabIndex = 73;
            buttoncustom1.Text = "ADD";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click;
            // 
            // stdemail
            // 
            stdemail.BackColor = SystemColors.Control;
            stdemail.BorderColor = Color.DarkBlue;
            stdemail.BorderFocusColor = Color.Indigo;
            stdemail.BorderRadius = 0;
            stdemail.BorderSize = 3;
            stdemail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            stdemail.ForeColor = Color.DimGray;
            stdemail.Location = new Point(192, 217);
            stdemail.Multiline = false;
            stdemail.Name = "stdemail";
            stdemail.Padding = new Padding(10, 7, 10, 7);
            stdemail.PasswordChar = false;
            stdemail.PlaceholderColor = Color.White;
            stdemail.PlaceholderText = "";
            stdemail.Size = new Size(297, 39);
            stdemail.TabIndex = 79;
            stdemail.Texts = "";
            stdemail.UnderlinedStyle = true;
            // 
            // stdUsn
            // 
            stdUsn.BackColor = SystemColors.Control;
            stdUsn.BorderColor = Color.DarkBlue;
            stdUsn.BorderFocusColor = Color.Indigo;
            stdUsn.BorderRadius = 0;
            stdUsn.BorderSize = 3;
            stdUsn.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            stdUsn.ForeColor = Color.DimGray;
            stdUsn.Location = new Point(192, 72);
            stdUsn.Multiline = false;
            stdUsn.Name = "stdUsn";
            stdUsn.Padding = new Padding(10, 7, 10, 7);
            stdUsn.PasswordChar = false;
            stdUsn.PlaceholderColor = Color.White;
            stdUsn.PlaceholderText = "";
            stdUsn.Size = new Size(297, 39);
            stdUsn.TabIndex = 78;
            stdUsn.Texts = "";
            stdUsn.UnderlinedStyle = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.RoyalBlue;
            label12.Location = new Point(38, 86);
            label12.Name = "label12";
            label12.Size = new Size(114, 25);
            label12.TabIndex = 77;
            label12.Text = "Student ID";
            // 
            // stdname
            // 
            stdname.BackColor = SystemColors.Control;
            stdname.BorderColor = Color.DarkBlue;
            stdname.BorderFocusColor = Color.Indigo;
            stdname.BorderRadius = 0;
            stdname.BorderSize = 3;
            stdname.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            stdname.ForeColor = Color.DimGray;
            stdname.Location = new Point(192, 169);
            stdname.Multiline = false;
            stdname.Name = "stdname";
            stdname.Padding = new Padding(10, 7, 10, 7);
            stdname.PasswordChar = false;
            stdname.PlaceholderColor = Color.White;
            stdname.PlaceholderText = "";
            stdname.Size = new Size(297, 39);
            stdname.TabIndex = 81;
            stdname.Texts = "";
            stdname.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(38, 231);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 80;
            label1.Text = "Email Address";
            // 
            // stdenrollno
            // 
            stdenrollno.BackColor = SystemColors.Control;
            stdenrollno.BorderColor = Color.DarkBlue;
            stdenrollno.BorderFocusColor = Color.Indigo;
            stdenrollno.BorderRadius = 0;
            stdenrollno.BorderSize = 3;
            stdenrollno.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            stdenrollno.ForeColor = Color.DimGray;
            stdenrollno.Location = new Point(203, 308);
            stdenrollno.Multiline = false;
            stdenrollno.Name = "stdenrollno";
            stdenrollno.Padding = new Padding(10, 7, 10, 7);
            stdenrollno.PasswordChar = false;
            stdenrollno.PlaceholderColor = Color.White;
            stdenrollno.PlaceholderText = "";
            stdenrollno.Size = new Size(297, 39);
            stdenrollno.TabIndex = 83;
            stdenrollno.Texts = "";
            stdenrollno.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(37, 180);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 82;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(35, 322);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 84;
            label3.Text = "EnrollmentNo";
            // 
            // stdphoneno
            // 
            stdphoneno.BackColor = SystemColors.Control;
            stdphoneno.BorderColor = Color.DarkBlue;
            stdphoneno.BorderFocusColor = Color.Indigo;
            stdphoneno.BorderRadius = 0;
            stdphoneno.BorderSize = 3;
            stdphoneno.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            stdphoneno.ForeColor = Color.DimGray;
            stdphoneno.Location = new Point(198, 362);
            stdphoneno.Multiline = false;
            stdphoneno.Name = "stdphoneno";
            stdphoneno.Padding = new Padding(10, 7, 10, 7);
            stdphoneno.PasswordChar = false;
            stdphoneno.PlaceholderColor = Color.White;
            stdphoneno.PlaceholderText = "";
            stdphoneno.Size = new Size(297, 39);
            stdphoneno.TabIndex = 86;
            stdphoneno.Texts = "";
            stdphoneno.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(35, 376);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 85;
            label4.Text = "PhoneNo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(35, 476);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 88;
            label5.Text = "Home Address";
            // 
            // stdaddress
            // 
            stdaddress.BackColor = SystemColors.Control;
            stdaddress.BorderColor = Color.DarkBlue;
            stdaddress.BorderFocusColor = Color.Indigo;
            stdaddress.BorderRadius = 0;
            stdaddress.BorderSize = 3;
            stdaddress.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            stdaddress.ForeColor = Color.DimGray;
            stdaddress.Location = new Point(203, 476);
            stdaddress.Multiline = true;
            stdaddress.Name = "stdaddress";
            stdaddress.Padding = new Padding(10, 7, 10, 7);
            stdaddress.PasswordChar = false;
            stdaddress.PlaceholderColor = Color.White;
            stdaddress.PlaceholderText = "";
            stdaddress.Size = new Size(297, 93);
            stdaddress.TabIndex = 89;
            stdaddress.Texts = "";
            stdaddress.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(41, 428);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 90;
            label6.Text = "D.O.B";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(195, 422);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(300, 31);
            dtpDateOfBirth.TabIndex = 91;
            // 
            // buttoncustom5
            // 
            buttoncustom5.BackColor = Color.CornflowerBlue;
            buttoncustom5.BorderColor = Color.Black;
            buttoncustom5.BorderRadius = 40;
            buttoncustom5.BorderSize = 0;
            buttoncustom5.FlatAppearance.BorderSize = 0;
            buttoncustom5.FlatStyle = FlatStyle.Flat;
            buttoncustom5.ForeColor = Color.White;
            buttoncustom5.Location = new Point(506, 608);
            buttoncustom5.Name = "buttoncustom5";
            buttoncustom5.Size = new Size(148, 45);
            buttoncustom5.TabIndex = 92;
            buttoncustom5.Text = "DISPLAY";
            buttoncustom5.UseVisualStyleBackColor = false;
            buttoncustom5.Click += buttoncustom5_Click;
            // 
            // textboxcustom1
            // 
            textboxcustom1.BackColor = SystemColors.Control;
            textboxcustom1.BorderColor = Color.DarkBlue;
            textboxcustom1.BorderFocusColor = Color.Indigo;
            textboxcustom1.BorderRadius = 0;
            textboxcustom1.BorderSize = 3;
            textboxcustom1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textboxcustom1.ForeColor = Color.DimGray;
            textboxcustom1.Location = new Point(192, 123);
            textboxcustom1.Multiline = false;
            textboxcustom1.Name = "textboxcustom1";
            textboxcustom1.Padding = new Padding(10, 7, 10, 7);
            textboxcustom1.PasswordChar = false;
            textboxcustom1.PlaceholderColor = Color.White;
            textboxcustom1.PlaceholderText = "";
            textboxcustom1.Size = new Size(297, 39);
            textboxcustom1.TabIndex = 94;
            textboxcustom1.Texts = "";
            textboxcustom1.UnderlinedStyle = true;
            // 
            // txtroomid
            // 
            txtroomid.AutoSize = true;
            txtroomid.BackColor = Color.Transparent;
            txtroomid.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtroomid.ForeColor = Color.RoyalBlue;
            txtroomid.Location = new Point(41, 137);
            txtroomid.Name = "txtroomid";
            txtroomid.Size = new Size(94, 25);
            txtroomid.TabIndex = 93;
            txtroomid.Text = "Room ID";
            txtroomid.Click += txtroomid_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(35, 276);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 97;
            label7.Text = "Father Name";
            // 
            // txtfname
            // 
            txtfname.BackColor = SystemColors.Control;
            txtfname.BorderColor = Color.DarkBlue;
            txtfname.BorderFocusColor = Color.Indigo;
            txtfname.BorderRadius = 0;
            txtfname.BorderSize = 3;
            txtfname.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtfname.ForeColor = Color.DimGray;
            txtfname.Location = new Point(193, 262);
            txtfname.Multiline = false;
            txtfname.Name = "txtfname";
            txtfname.Padding = new Padding(10, 7, 10, 7);
            txtfname.PasswordChar = false;
            txtfname.PlaceholderColor = Color.White;
            txtfname.PlaceholderText = "";
            txtfname.Size = new Size(297, 39);
            txtfname.TabIndex = 96;
            txtfname.Texts = "";
            txtfname.UnderlinedStyle = true;
            // 
            // Studentinfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 700);
            Controls.Add(label7);
            Controls.Add(txtfname);
            Controls.Add(textboxcustom1);
            Controls.Add(txtroomid);
            Controls.Add(buttoncustom5);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label6);
            Controls.Add(stdaddress);
            Controls.Add(label5);
            Controls.Add(stdphoneno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(stdenrollno);
            Controls.Add(label2);
            Controls.Add(stdname);
            Controls.Add(label1);
            Controls.Add(stdemail);
            Controls.Add(stdUsn);
            Controls.Add(label12);
            Controls.Add(buttoncustom4);
            Controls.Add(buttoncustom3);
            Controls.Add(buttoncustom2);
            Controls.Add(buttoncustom1);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Studentinfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studentinfo";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label8;
        private DataGridView dataGridView1;
        private Buttoncustom buttoncustom4;
        private Buttoncustom buttoncustom3;
        private Buttoncustom buttoncustom2;
        private Buttoncustom buttoncustom1;
        private Textboxcustom stdemail;
        private Textboxcustom stdUsn;
        private Label label12;
        private Textboxcustom stdname;
        private Label label1;
        private Textboxcustom stdenrollno;
        private Label label2;
        private Label label3;
        private Textboxcustom stdphoneno;
        private Label label4;
        private Label label5;
        private Textboxcustom stdaddress;
        private Label label6;
        private DateTimePicker dtpDateOfBirth;
        private Buttoncustom buttoncustom5;
        private Textboxcustom textboxcustom1;
        private Label txtroomid;
        private Label label7;
        private Textboxcustom txtfname;
    }
}