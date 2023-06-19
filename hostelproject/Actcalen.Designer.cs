namespace hostelproject
{
    partial class Actcalen
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
            label14 = new Label();
            panel2 = new Panel();
            btnsent = new Buttoncustom();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(91, 129);
            label14.Name = "label14";
            label14.Size = new Size(208, 29);
            label14.TabIndex = 41;
            label14.Text = "Activity Calender";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(75, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 42;
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
            btnsent.Location = new Point(1300, 559);
            btnsent.Name = "btnsent";
            btnsent.Size = new Size(198, 35);
            btnsent.TabIndex = 71;
            btnsent.Text = "LEAVE";
            btnsent.UseVisualStyleBackColor = false;
            btnsent.Click += btnsent_Click;
            // 
            // Actcalen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 650);
            Controls.Add(btnsent);
            Controls.Add(panel2);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Actcalen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actcalen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private Panel panel2;
        private Buttoncustom btnsent;
    }
}