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
            button3 = new Button();
            buttoncustom4 = new Buttoncustom();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            panel2 = new Panel();
            buttoncustom1 = new Buttoncustom();
            buttoncustom2 = new Buttoncustom();
            btnsent = new Buttoncustom();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Underline, GraphicsUnit.Point);
            button3.ForeColor = Color.RoyalBlue;
            button3.Location = new Point(467, 517);
            button3.Name = "button3";
            button3.Size = new Size(190, 55);
            button3.TabIndex = 25;
            button3.Text = "Update Utility Bills+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            buttoncustom4.Location = new Point(294, 529);
            buttoncustom4.Name = "buttoncustom4";
            buttoncustom4.Size = new Size(156, 33);
            buttoncustom4.TabIndex = 27;
            buttoncustom4.Text = "Get";
            buttoncustom4.UseVisualStyleBackColor = false;
            buttoncustom4.Click += buttoncustom4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1082, 285);
            dataGridView1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(38, 120);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 30;
            label3.Text = "Utility Bills";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(38, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 41;
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
            buttoncustom1.Location = new Point(673, 529);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(156, 33);
            buttoncustom1.TabIndex = 42;
            buttoncustom1.Text = "Display";
            buttoncustom1.UseVisualStyleBackColor = false;
            buttoncustom1.Click += buttoncustom1_Click;
            // 
            // buttoncustom2
            // 
            buttoncustom2.BackColor = Color.CornflowerBlue;
            buttoncustom2.BorderColor = Color.Black;
            buttoncustom2.BorderRadius = 40;
            buttoncustom2.BorderSize = 0;
            buttoncustom2.FlatAppearance.BorderSize = 0;
            buttoncustom2.FlatStyle = FlatStyle.Flat;
            buttoncustom2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttoncustom2.ForeColor = Color.White;
            buttoncustom2.Location = new Point(902, 529);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(156, 33);
            buttoncustom2.TabIndex = 43;
            buttoncustom2.Text = "Delete";
            buttoncustom2.UseVisualStyleBackColor = false;
            buttoncustom2.Click += buttoncustom2_Click;
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
            btnsent.Location = new Point(765, 584);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(198, 35);
            btnsent.TabIndex = 71;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // utilitybills
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(btnsent);
            Controls.Add(buttoncustom2);
            Controls.Add(buttoncustom1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(buttoncustom4);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "utilitybills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "utilitybills";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Buttoncustom buttoncustom4;
        private DataGridView dataGridView1;
        private Label label3;
        private Panel panel2;
        private Buttoncustom buttoncustom1;
        private Buttoncustom buttoncustom2;
        private Buttoncustom btnsent;
    }
}