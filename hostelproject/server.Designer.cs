namespace Client
{
    partial class server
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
            connectButton = new Button();
            portLabel = new Label();
            localaddrLabel = new Label();
            portTextBox = new TextBox();
            logLabel = new Label();
            logTextBox = new TextBox();
            sendLabel = new Label();
            sendTextBox = new TextBox();
            clearButton = new Button();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            keyLabel = new Label();
            keyTextBox = new TextBox();
            addrTextBox = new TextBox();
            versionLabel = new Label();
            checkBox = new CheckBox();
            SuspendLayout();
            // 
            // connectButton
            // 
            connectButton.Location = new Point(462, 105);
            connectButton.Margin = new Padding(4);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(116, 28);
            connectButton.TabIndex = 28;
            connectButton.TabStop = false;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += ConnectButton_Click;
            // 
            // portLabel
            // 
            portLabel.AutoSize = true;
            portLabel.Location = new Point(654, 18);
            portLabel.Margin = new Padding(8, 4, 4, 4);
            portLabel.Name = "portLabel";
            portLabel.Size = new Size(48, 25);
            portLabel.TabIndex = 27;
            portLabel.Text = "Port:";
            // 
            // localaddrLabel
            // 
            localaddrLabel.AutoSize = true;
            localaddrLabel.Location = new Point(213, 18);
            localaddrLabel.Margin = new Padding(8, 4, 4, 4);
            localaddrLabel.Name = "localaddrLabel";
            localaddrLabel.Size = new Size(81, 25);
            localaddrLabel.TabIndex = 26;
            localaddrLabel.Text = "Address:";
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(714, 15);
            portTextBox.Margin = new Padding(4);
            portTextBox.MaxLength = 10;
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(132, 31);
            portTextBox.TabIndex = 25;
            portTextBox.TabStop = false;
            portTextBox.Text = "9000";
            portTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // logLabel
            // 
            logLabel.AutoSize = true;
            logLabel.Location = new Point(134, 126);
            logLabel.Margin = new Padding(8, 4, 4, 4);
            logLabel.Name = "logLabel";
            logLabel.Size = new Size(42, 25);
            logLabel.TabIndex = 31;
            logLabel.Text = "Log";
            // 
            // logTextBox
            // 
            logTextBox.BackColor = SystemColors.Window;
            logTextBox.Location = new Point(134, 159);
            logTextBox.Margin = new Padding(4);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(568, 301);
            logTextBox.TabIndex = 30;
            logTextBox.TabStop = false;
            // 
            // sendLabel
            // 
            sendLabel.AutoSize = true;
            sendLabel.Location = new Point(57, 480);
            sendLabel.Margin = new Padding(8, 4, 4, 4);
            sendLabel.Name = "sendLabel";
            sendLabel.Size = new Size(52, 25);
            sendLabel.TabIndex = 33;
            sendLabel.Text = "Send";
            // 
            // sendTextBox
            // 
            sendTextBox.Location = new Point(134, 480);
            sendTextBox.Margin = new Padding(4);
            sendTextBox.Name = "sendTextBox";
            sendTextBox.ScrollBars = ScrollBars.Vertical;
            sendTextBox.Size = new Size(568, 31);
            sendTextBox.TabIndex = 32;
            sendTextBox.TabStop = false;
            sendTextBox.KeyDown += SendTextBox_KeyDown;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(586, 105);
            clearButton.Margin = new Padding(4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(116, 28);
            clearButton.TabIndex = 34;
            clearButton.TabStop = false;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(213, 63);
            usernameLabel.Margin = new Padding(8, 4, 4, 4);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(95, 25);
            usernameLabel.TabIndex = 36;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(316, 60);
            usernameTextBox.Margin = new Padding(4);
            usernameTextBox.MaxLength = 50;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(132, 31);
            usernameTextBox.TabIndex = 35;
            usernameTextBox.TabStop = false;
            usernameTextBox.Text = "Client";
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(658, 60);
            keyLabel.Margin = new Padding(8, 4, 4, 4);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(44, 25);
            keyLabel.TabIndex = 38;
            keyLabel.Text = "Key:";
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(714, 54);
            keyTextBox.Margin = new Padding(4);
            keyTextBox.MaxLength = 200;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(132, 31);
            keyTextBox.TabIndex = 37;
            keyTextBox.TabStop = false;
            keyTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // addrTextBox
            // 
            addrTextBox.Location = new Point(316, 18);
            addrTextBox.Margin = new Padding(4);
            addrTextBox.MaxLength = 200;
            addrTextBox.Name = "addrTextBox";
            addrTextBox.RightToLeft = RightToLeft.Yes;
            addrTextBox.Size = new Size(132, 31);
            addrTextBox.TabIndex = 39;
            addrTextBox.TabStop = false;
            addrTextBox.Text = "127.0.0.1";
            addrTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new Point(714, 480);
            versionLabel.Margin = new Padding(8, 4, 4, 4);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(45, 25);
            versionLabel.TabIndex = 40;
            versionLabel.Text = "v1.5";
            // 
            // checkBox
            // 
            checkBox.Cursor = Cursors.Hand;
            checkBox.Location = new Point(714, 93);
            checkBox.Margin = new Padding(4);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(117, 35);
            checkBox.TabIndex = 41;
            checkBox.Text = "Hide key";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // Clienttt
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1578, 594);
            Controls.Add(checkBox);
            Controls.Add(versionLabel);
            Controls.Add(addrTextBox);
            Controls.Add(keyLabel);
            Controls.Add(keyTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(clearButton);
            Controls.Add(sendLabel);
            Controls.Add(sendTextBox);
            Controls.Add(logLabel);
            Controls.Add(logTextBox);
            Controls.Add(connectButton);
            Controls.Add(portLabel);
            Controls.Add(localaddrLabel);
            Controls.Add(portTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Clienttt";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            FormClosing += Client_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectButton;
        private Label portLabel;
        private Label localaddrLabel;
        private TextBox portTextBox;
        private Label logLabel;
        private TextBox logTextBox;
        private Label sendLabel;
        private TextBox sendTextBox;
        private Button clearButton;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label keyLabel;
        private TextBox keyTextBox;
        private TextBox addrTextBox;
        private Label versionLabel;
        private CheckBox checkBox;
    }
}

