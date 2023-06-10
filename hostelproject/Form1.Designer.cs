namespace hostelproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gradientPanel1 = new GradientPanel();
            textboxcustom1 = new Textboxcustom();
            txtpass = new TextBox();
            txtuser = new TextBox();
            panel4 = new Panel();
            button2 = new Button();
            buttoncustom2 = new Buttoncustom();
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            buttoncustom1 = new Buttoncustom();
            panel1 = new Panel();
            label1 = new Label();
            gradientPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Colorbottom = Color.RoyalBlue;
            gradientPanel1.Colortop = Color.RoyalBlue;
            gradientPanel1.Controls.Add(textboxcustom1);
            gradientPanel1.Controls.Add(txtpass);
            gradientPanel1.Controls.Add(txtuser);
            gradientPanel1.Controls.Add(panel4);
            gradientPanel1.Controls.Add(buttoncustom2);
            gradientPanel1.Controls.Add(panel3);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(panel2);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(buttoncustom1);
            gradientPanel1.Controls.Add(panel1);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(581, 992);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // textboxcustom1
            // 
            textboxcustom1.BackColor = SystemColors.Window;
            textboxcustom1.BorderColor = Color.MediumSlateBlue;
            textboxcustom1.BorderFocusColor = Color.Indigo;
            textboxcustom1.BorderRadius = 0;
            textboxcustom1.BorderSize = 2;
            textboxcustom1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textboxcustom1.ForeColor = Color.DimGray;
            textboxcustom1.Location = new Point(92, 375);
            textboxcustom1.Multiline = false;
            textboxcustom1.Name = "textboxcustom1";
            textboxcustom1.Padding = new Padding(10, 7, 10, 7);
            textboxcustom1.PasswordChar = false;
            textboxcustom1.PlaceholderColor = Color.White;
            textboxcustom1.PlaceholderText = "";
            textboxcustom1.Size = new Size(390, 39);
            textboxcustom1.TabIndex = 17;
            textboxcustom1.Texts = "";
            textboxcustom1.UnderlinedStyle = false;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(208, 492);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(150, 31);
            txtpass.TabIndex = 16;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(208, 429);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(150, 31);
            txtuser.TabIndex = 15;
            txtuser.UseSystemPasswordChar = true;
            txtuser.TextChanged += txtuser_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(581, 67);
            panel4.TabIndex = 13;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(509, 0);
            button2.Name = "button2";
            button2.Size = new Size(72, 67);
            button2.TabIndex = 14;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // buttoncustom2
            // 
            buttoncustom2.BackColor = Color.CornflowerBlue;
            buttoncustom2.BorderColor = Color.Black;
            buttoncustom2.BorderRadius = 40;
            buttoncustom2.BorderSize = 0;
            buttoncustom2.FlatAppearance.BorderSize = 0;
            buttoncustom2.FlatStyle = FlatStyle.Flat;
            buttoncustom2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncustom2.ForeColor = Color.White;
            buttoncustom2.Location = new Point(77, 684);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(419, 40);
            buttoncustom2.TabIndex = 12;
            buttoncustom2.Text = "Sign up";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(307, 655);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(168, 946);
            button1.Name = "button1";
            button1.Size = new Size(109, 34);
            button1.TabIndex = 10;
            button1.Text = "Get Help";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(14, 939);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 1);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(273, 645);
            label3.Name = "label3";
            label3.Size = new Size(34, 21);
            label3.TabIndex = 8;
            label3.Text = "OR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 952);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 6;
            label2.Text = "Trouble Logging in?";
            // 
            // buttoncustom1
            // 
            buttoncustom1.BackColor = Color.CornflowerBlue;
            buttoncustom1.BorderColor = Color.Black;
            buttoncustom1.BorderRadius = 40;
            buttoncustom1.BorderSize = 0;
            buttoncustom1.FlatAppearance.BorderSize = 0;
            buttoncustom1.FlatStyle = FlatStyle.Flat;
            buttoncustom1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncustom1.ForeColor = Color.White;
            buttoncustom1.Location = new Point(77, 576);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(419, 40);
            buttoncustom1.TabIndex = 5;
            buttoncustom1.Text = "Login";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(34, 655);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 274);
            label1.Name = "label1";
            label1.Size = new Size(523, 51);
            label1.TabIndex = 0;
            label1.Text = "Bahria University Hostel ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(581, 992);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label label1;
        private Panel panel1;
        private Buttoncustom buttoncustom1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Buttoncustom buttoncustom2;
        private Panel panel4;
        private Button button2;
        private TextBox txtpass;
        private TextBox txtuser;
        private Textboxcustom textboxcustom1;
    }
}