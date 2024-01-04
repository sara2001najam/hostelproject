namespace Chatcleint
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
            txtRemoteIP = new TextBox();
            txtMSG = new TextBox();
            txtInMSG = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label14 = new Label();
            buttoncustom1 = new hostelproject.Buttoncustom();
            buttoncustom2 = new hostelproject.Buttoncustom();
            SuspendLayout();
            // 
            // txtRemoteIP
            // 
            txtRemoteIP.Location = new Point(313, 44);
            txtRemoteIP.Name = "txtRemoteIP";
            txtRemoteIP.Size = new Size(486, 31);
            txtRemoteIP.TabIndex = 58;
            txtRemoteIP.Text = "127.0.0.1";
            // 
            // txtMSG
            // 
            txtMSG.Location = new Point(140, 451);
            txtMSG.Name = "txtMSG";
            txtMSG.Size = new Size(836, 31);
            txtMSG.TabIndex = 57;
            // 
            // txtInMSG
            // 
            txtInMSG.ForeColor = Color.RoyalBlue;
            txtInMSG.Location = new Point(140, 107);
            txtInMSG.Multiline = true;
            txtInMSG.Name = "txtInMSG";
            txtInMSG.Size = new Size(838, 325);
            txtInMSG.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(149, 44);
            label1.Name = "label1";
            label1.Size = new Size(135, 29);
            label1.TabIndex = 55;
            label1.Text = "Remote IP";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(-14, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 1);
            panel2.TabIndex = 54;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.RoyalBlue;
            label14.Location = new Point(-14, -43);
            label14.Name = "label14";
            label14.Size = new Size(192, 29);
            label14.TabIndex = 53;
            label14.Text = "CHAT SERVER";
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
            buttoncustom1.Location = new Point(832, 40);
            buttoncustom1.Name = "buttoncustom1";
            buttoncustom1.Size = new Size(146, 39);
            buttoncustom1.TabIndex = 59;
            buttoncustom1.Text = "connect";
            buttoncustom1.UseVisualStyleBackColor = false;
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
            buttoncustom2.Location = new Point(1001, 443);
            buttoncustom2.Name = "buttoncustom2";
            buttoncustom2.Size = new Size(146, 39);
            buttoncustom2.TabIndex = 60;
            buttoncustom2.Text = "send";
            buttoncustom2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 594);
            Controls.Add(buttoncustom2);
            Controls.Add(buttoncustom1);
            Controls.Add(txtRemoteIP);
            Controls.Add(txtMSG);
            Controls.Add(txtInMSG);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label14);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRemoteIP;
        private TextBox txtMSG;
        private TextBox txtInMSG;
        private Label label1;
        private Panel panel2;
        private Label label14;
        private hostelproject.Buttoncustom buttoncustom1;
        private hostelproject.Buttoncustom buttoncustom2;
    }
}