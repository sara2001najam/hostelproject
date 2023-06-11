namespace hostelproject
{
    partial class utilitybills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utilitybills));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            textboxcustom1 = new Textboxcustom();
            buttoncustom4 = new Buttoncustom();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
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
            panel1.Size = new Size(1300, 86);
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
            button2.Location = new Point(1228, 0);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(72, 86);
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
            button1.Size = new Size(124, 86);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Underline, GraphicsUnit.Point);
            button3.ForeColor = Color.RoyalBlue;
            button3.Location = new Point(774, 222);
            button3.Name = "button3";
            button3.Size = new Size(173, 55);
            button3.TabIndex = 25;
            button3.Text = "Add Utility Bills+";
            button3.UseVisualStyleBackColor = true;
            // 
            // textboxcustom1
            // 
            textboxcustom1.BackColor = SystemColors.Window;
            textboxcustom1.BorderColor = Color.DarkBlue;
            textboxcustom1.BorderFocusColor = Color.Indigo;
            textboxcustom1.BorderRadius = 15;
            textboxcustom1.BorderSize = 3;
            textboxcustom1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            textboxcustom1.ForeColor = Color.DimGray;
            textboxcustom1.Location = new Point(700, 283);
            textboxcustom1.Multiline = false;
            textboxcustom1.Name = "textboxcustom1";
            textboxcustom1.Padding = new Padding(10, 7, 10, 7);
            textboxcustom1.PasswordChar = false;
            textboxcustom1.PlaceholderColor = Color.White;
            textboxcustom1.PlaceholderText = "Search Utility bills";
            textboxcustom1.Size = new Size(390, 39);
            textboxcustom1.TabIndex = 26;
            textboxcustom1.Texts = "";
            textboxcustom1.UnderlinedStyle = false;
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
            buttoncustom4.Location = new Point(1106, 272);
            buttoncustom4.Name = "buttoncustom4";
            buttoncustom4.Size = new Size(172, 50);
            buttoncustom4.TabIndex = 27;
            buttoncustom4.Text = "Search";
            buttoncustom4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1205, 389);
            dataGridView1.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(953, 242);
            label2.Name = "label2";
            label2.Size = new Size(154, 18);
            label2.TabIndex = 29;
            label2.Text = "Bill added sucessfully*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(38, 195);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 30;
            label3.Text = "Utility Bills";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(38, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 41;
            // 
            // utilitybills
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 722);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(buttoncustom4);
            Controls.Add(textboxcustom1);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "utilitybills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "utilitybills";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Textboxcustom textboxcustom1;
        private Buttoncustom buttoncustom4;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Panel panel2;
    }
}