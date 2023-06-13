namespace hostelproject
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label9 = new Label();
            label1 = new Label();
            txtRoomno = new Textboxcustom();
            label2 = new Label();
            checkBox1 = new CheckBox();
            btnAdd = new Buttoncustom();
            label3 = new Label();
            txtRoom = new Textboxcustom();
            label4 = new Label();
            buttoncustom2 = new Buttoncustom();
            checkBox2 = new CheckBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            buttoncustom3 = new Buttoncustom();
            buttoncustom4 = new Buttoncustom();
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
            panel1.Size = new Size(1300, 75);
            panel1.TabIndex = 5;
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
            button2.Location = new Point(1228, 0);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(72, 75);
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
            button1.Size = new Size(124, 75);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.RoyalBlue;
            label9.Location = new Point(68, 112);
            label9.Name = "label9";
            label9.Size = new Size(199, 28);
            label9.TabIndex = 31;
            label9.Text = "ADD NEW ROOM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(57, 171);
            label1.Name = "label1";
            label1.Size = new Size(166, 26);
            label1.TabIndex = 32;
            label1.Text = "Room Number";
            // 
            // txtRoomno
            // 
            txtRoomno.BackColor = SystemColors.Control;
            txtRoomno.BorderColor = Color.DarkBlue;
            txtRoomno.BorderFocusColor = Color.Indigo;
            txtRoomno.BorderRadius = 0;
            txtRoomno.BorderSize = 3;
            txtRoomno.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomno.ForeColor = Color.DimGray;
            txtRoomno.Location = new Point(229, 158);
            txtRoomno.Multiline = false;
            txtRoomno.Name = "txtRoomno";
            txtRoomno.Padding = new Padding(10, 7, 10, 7);
            txtRoomno.PasswordChar = false;
            txtRoomno.PlaceholderColor = Color.White;
            txtRoomno.PlaceholderText = "";
            txtRoomno.Size = new Size(297, 39);
            txtRoomno.TabIndex = 40;
            txtRoomno.Texts = "";
            txtRoomno.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(588, 184);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 41;
            label2.Text = "Available";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(717, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 29);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "Yes";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CornflowerBlue;
            btnAdd.BorderColor = Color.Black;
            btnAdd.BorderRadius = 40;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(860, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 36);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add Room";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += buttoncustom1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(68, 269);
            label3.Name = "label3";
            label3.Size = new Size(324, 28);
            label3.TabIndex = 44;
            label3.Text = "UPDATE OR DELETE ROOM";
            // 
            // txtRoom
            // 
            txtRoom.BackColor = SystemColors.Control;
            txtRoom.BorderColor = Color.DarkBlue;
            txtRoom.BorderFocusColor = Color.Indigo;
            txtRoom.BorderRadius = 0;
            txtRoom.BorderSize = 3;
            txtRoom.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoom.ForeColor = Color.DimGray;
            txtRoom.Location = new Point(229, 321);
            txtRoom.Multiline = false;
            txtRoom.Name = "txtRoom";
            txtRoom.Padding = new Padding(10, 7, 10, 7);
            txtRoom.PasswordChar = false;
            txtRoom.PlaceholderColor = Color.White;
            txtRoom.PlaceholderText = "";
            txtRoom.Size = new Size(297, 39);
            txtRoom.TabIndex = 46;
            txtRoom.Texts = "";
            txtRoom.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(57, 334);
            label4.Name = "label4";
            label4.Size = new Size(166, 26);
            label4.TabIndex = 45;
            label4.Text = "Room Number";
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
            buttoncustom2.Location = new Point(573, 324);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(138, 36);
            buttoncustom2.TabIndex = 47;
            buttoncustom2.Text = "SEARCH";
            buttoncustom2.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(882, 329);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(63, 29);
            checkBox2.TabIndex = 49;
            checkBox2.Text = "Yes";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(743, 329);
            label5.Name = "label5";
            label5.Size = new Size(110, 26);
            label5.TabIndex = 48;
            label5.Text = "Available";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ButtonShadow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 462);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1028, 332);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(564, 419);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 51;
            label6.Text = "ALL ROOMS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(57, 216);
            label7.Name = "label7";
            label7.Size = new Size(133, 26);
            label7.TabIndex = 52;
            label7.Text = "Room Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Double", "Single" });
            comboBox1.Location = new Point(229, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 33);
            comboBox1.TabIndex = 53;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Double", "Single" });
            comboBox2.Location = new Point(229, 374);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(304, 33);
            comboBox2.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(57, 376);
            label8.Name = "label8";
            label8.Size = new Size(133, 26);
            label8.TabIndex = 55;
            label8.Text = "Room Type";
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
            buttoncustom3.Location = new Point(573, 366);
            buttoncustom3.Name = "buttoncustom3";
            buttoncustom3.Size = new Size(138, 36);
            buttoncustom3.TabIndex = 57;
            buttoncustom3.Text = "UPDATE";
            buttoncustom3.UseVisualStyleBackColor = false;
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
            buttoncustom4.Location = new Point(729, 366);
            buttoncustom4.Name = "buttoncustom4";
            buttoncustom4.Size = new Size(138, 36);
            buttoncustom4.TabIndex = 58;
            buttoncustom4.Text = "DELETE";
            buttoncustom4.UseVisualStyleBackColor = false;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 700);
            Controls.Add(buttoncustom4);
            Controls.Add(buttoncustom3);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox2);
            Controls.Add(label5);
            Controls.Add(buttoncustom2);
            Controls.Add(txtRoom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(txtRoomno);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label9;
        private Label label1;
        private Textboxcustom txtRoomno;
        private Label label2;
        private CheckBox checkBox1;
        private Buttoncustom btnAdd;
        private Label label3;
        private Textboxcustom txtRoom;
        private Label label4;
        private Buttoncustom buttoncustom2;
        private CheckBox checkBox2;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label8;
        private Buttoncustom buttoncustom3;
        private Buttoncustom buttoncustom4;
    }
}