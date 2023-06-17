namespace hostelproject
{
    partial class Complaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complaints));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            lben = new Label();
            txtenroll = new Textboxcustom();
            label2 = new Label();
            txtDescription = new Textboxcustom();
            panel4 = new Panel();
            buttoncustom1 = new Buttoncustom();
            lbl = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            btnsent = new Buttoncustom();
            txtTitle = new Textboxcustom();
            label1 = new Label();
            panel1.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 77);
            panel1.TabIndex = 4;
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
            button2.Name = "button2";
            button2.Size = new Size(72, 77);
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
            button1.Name = "button1";
            button1.Size = new Size(124, 77);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // lben
            // 
            lben.AutoSize = true;
            lben.BackColor = Color.Transparent;
            lben.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lben.ForeColor = Color.RoyalBlue;
            lben.Location = new Point(54, 153);
            lben.Name = "lben";
            lben.Size = new Size(248, 26);
            lben.TabIndex = 30;
            lben.Text = "Enter Enrollmentno/ID";
            // 
            // txtenroll
            // 
            txtenroll.BackColor = SystemColors.Control;
            txtenroll.BorderColor = Color.DarkBlue;
            txtenroll.BorderFocusColor = Color.Indigo;
            txtenroll.BorderRadius = 0;
            txtenroll.BorderSize = 3;
            txtenroll.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtenroll.ForeColor = Color.DimGray;
            txtenroll.Location = new Point(299, 140);
            txtenroll.Multiline = false;
            txtenroll.Name = "txtenroll";
            txtenroll.Padding = new Padding(10, 7, 10, 7);
            txtenroll.PasswordChar = false;
            txtenroll.PlaceholderColor = Color.White;
            txtenroll.PlaceholderText = "";
            txtenroll.Size = new Size(297, 39);
            txtenroll.TabIndex = 39;
            txtenroll.Texts = "";
            txtenroll.UnderlinedStyle = true;
            txtenroll._Textchanged += textboxcustom6__Textchanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(54, 237);
            label2.Name = "label2";
            label2.Size = new Size(134, 26);
            label2.TabIndex = 40;
            label2.Text = "Complaint: ";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.Window;
            txtDescription.BorderColor = Color.DarkBlue;
            txtDescription.BorderFocusColor = Color.Indigo;
            txtDescription.BorderRadius = 15;
            txtDescription.BorderSize = 2;
            txtDescription.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = Color.DimGray;
            txtDescription.Location = new Point(54, 280);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Padding = new Padding(10, 7, 10, 7);
            txtDescription.PasswordChar = false;
            txtDescription.PlaceholderColor = Color.White;
            txtDescription.PlaceholderText = "";
            txtDescription.Size = new Size(523, 298);
            txtDescription.TabIndex = 41;
            txtDescription.Texts = "";
            txtDescription.UnderlinedStyle = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(698, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 650);
            panel4.TabIndex = 42;
            // 
            // buttoncustom1
            // 
            buttoncustom1.BackColor = Color.CornflowerBlue;
            buttoncustom1.BorderColor = Color.Black;
            buttoncustom1.BorderRadius = 40;
            buttoncustom1.BorderSize = 0;
            buttoncustom1.FlatAppearance.BorderSize = 0;
            buttoncustom1.FlatStyle = FlatStyle.Flat;
            buttoncustom1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom1.ForeColor = Color.White;
            buttoncustom1.Location = new Point(363, 712);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(225, 60);
            buttoncustom1.TabIndex = 43;
            buttoncustom1.Text = "Submit";
            buttoncustom1.UseVisualStyleBackColor = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.Red;
            lbl.Location = new Point(54, 590);
            lbl.Name = "lbl";
            lbl.Size = new Size(269, 20);
            lbl.TabIndex = 66;
            lbl.Text = "Your complaint has been submitted.*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(743, 280);
            label4.Name = "label4";
            label4.Size = new Size(675, 156);
            label4.TabIndex = 67;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(743, 214);
            label5.Name = "label5";
            label5.Size = new Size(135, 29);
            label5.TabIndex = 68;
            label5.Text = "Contact us";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(743, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 69;
            // 
            // btnsent
            // 
            btnsent.BackColor = Color.CornflowerBlue;
            btnsent.BorderColor = Color.Black;
            btnsent.BorderRadius = 40;
            btnsent.BorderSize = 0;
            btnsent.FlatAppearance.BorderSize = 0;
            btnsent.FlatStyle = FlatStyle.Flat;
            btnsent.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnsent.ForeColor = Color.White;
            btnsent.Location = new Point(398, 619);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(198, 35);
            btnsent.TabIndex = 70;
            btnsent.Text = "SEND";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Control;
            txtTitle.BorderColor = Color.DarkBlue;
            txtTitle.BorderFocusColor = Color.Indigo;
            txtTitle.BorderRadius = 0;
            txtTitle.BorderSize = 3;
            txtTitle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.DimGray;
            txtTitle.Location = new Point(299, 183);
            txtTitle.Multiline = false;
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(10, 7, 10, 7);
            txtTitle.PasswordChar = false;
            txtTitle.PlaceholderColor = Color.White;
            txtTitle.PlaceholderText = "";
            txtTitle.Size = new Size(297, 39);
            txtTitle.TabIndex = 72;
            txtTitle.Texts = "";
            txtTitle.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(54, 196);
            label1.Name = "label1";
            label1.Size = new Size(200, 26);
            label1.TabIndex = 71;
            label1.Text = "Enter Title/reason";
            // 
            // Complaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1350, 700);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(btnsent);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl);
            Controls.Add(buttoncustom1);
            Controls.Add(panel4);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtenroll);
            Controls.Add(lben);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Complaints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complaints";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label lben;
        private Textboxcustom txtenroll;
        private Label label2;
        private Textboxcustom txtDescription;
        private Panel panel4;
        private Buttoncustom buttoncustom1;
        private Label lbl;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Buttoncustom btnsent;
        private Textboxcustom txtTitle;
        private Label label1;
    }
}