namespace hostelproject
{
    partial class Feechallan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feechallan));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            textboxcustom6 = new Textboxcustom();
            buttoncustom4 = new Buttoncustom();
            label2 = new Label();
            button3 = new Button();
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
            panel1.Size = new Size(1350, 88);
            panel1.TabIndex = 3;
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
            button2.Location = new Point(1252, 0);
            button2.Name = "button2";
            button2.Size = new Size(98, 88);
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
            button1.Size = new Size(124, 88);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.RoyalBlue;
            label10.Location = new Point(61, 217);
            label10.Name = "label10";
            label10.Size = new Size(231, 26);
            label10.TabIndex = 31;
            label10.Text = "Enter Enrollment no.";
            // 
            // textboxcustom6
            // 
            textboxcustom6.BackColor = SystemColors.Control;
            textboxcustom6.BorderColor = Color.DarkBlue;
            textboxcustom6.BorderFocusColor = Color.Indigo;
            textboxcustom6.BorderRadius = 0;
            textboxcustom6.BorderSize = 3;
            textboxcustom6.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textboxcustom6.ForeColor = Color.DimGray;
            textboxcustom6.Location = new Point(286, 204);
            textboxcustom6.Multiline = false;
            textboxcustom6.Name = "textboxcustom6";
            textboxcustom6.Padding = new Padding(10, 7, 10, 7);
            textboxcustom6.PasswordChar = false;
            textboxcustom6.PlaceholderColor = Color.White;
            textboxcustom6.PlaceholderText = "";
            textboxcustom6.Size = new Size(297, 39);
            textboxcustom6.TabIndex = 39;
            textboxcustom6.Texts = "";
            textboxcustom6.UnderlinedStyle = true;
            // 
            // buttoncustom4
            // 
            buttoncustom4.BackColor = Color.CornflowerBlue;
            buttoncustom4.BorderColor = Color.Black;
            buttoncustom4.BorderRadius = 40;
            buttoncustom4.BorderSize = 0;
            buttoncustom4.FlatAppearance.BorderSize = 0;
            buttoncustom4.FlatStyle = FlatStyle.Flat;
            buttoncustom4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom4.ForeColor = Color.White;
            buttoncustom4.Location = new Point(634, 201);
            buttoncustom4.Name = "buttoncustom4";
            buttoncustom4.Size = new Size(225, 60);
            buttoncustom4.TabIndex = 64;
            buttoncustom4.Text = "Search for fee challan";
            buttoncustom4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(372, 258);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 65;
            label2.Text = "Fee Challan not available*";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Underline, GraphicsUnit.Point);
            button3.ForeColor = Color.RoyalBlue;
            button3.Location = new Point(885, 227);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 66;
            button3.Text = "View PDF";
            button3.UseVisualStyleBackColor = true;
            // 
            // Feechallan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 700);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(buttoncustom4);
            Controls.Add(textboxcustom6);
            Controls.Add(label10);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Feechallan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feechallan";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label10;
        private Textboxcustom textboxcustom6;
        private Buttoncustom buttoncustom4;
        private Label label2;
        private Button button3;
    }
}