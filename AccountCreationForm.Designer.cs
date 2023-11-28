namespace Bank
{
    partial class AccountCreationForm
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
            backButton = new Button();
            userNameTextBox = new TextBox();
            accountNameTextBox = new TextBox();
            pinCodeTextbox = new TextBox();
            createAccountButton = new Button();
            userLabel = new Label();
            accountLabel = new Label();
            pinCodelabel = new Label();
            viewAccountsButton = new Button();
            createLabel = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Highlight;
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(581, 488);
            backButton.Margin = new Padding(2);
            backButton.Name = "backButton";
            backButton.Size = new Size(122, 56);
            backButton.TabIndex = 6;
            backButton.TabStop = false;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = SystemColors.ControlLightLight;
            userNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTextBox.Location = new Point(266, 191);
            userNameTextBox.Margin = new Padding(2);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(188, 31);
            userNameTextBox.TabIndex = 1;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.BackColor = SystemColors.ControlLightLight;
            accountNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            accountNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            accountNameTextBox.Location = new Point(266, 272);
            accountNameTextBox.Margin = new Padding(2);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(188, 31);
            accountNameTextBox.TabIndex = 2;
            // 
            // pinCodeTextbox
            // 
            pinCodeTextbox.BackColor = SystemColors.ControlLightLight;
            pinCodeTextbox.BorderStyle = BorderStyle.FixedSingle;
            pinCodeTextbox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pinCodeTextbox.Location = new Point(266, 361);
            pinCodeTextbox.Margin = new Padding(2);
            pinCodeTextbox.MaxLength = 4;
            pinCodeTextbox.Name = "pinCodeTextbox";
            pinCodeTextbox.Size = new Size(188, 31);
            pinCodeTextbox.TabIndex = 3;
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = SystemColors.Highlight;
            createAccountButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            createAccountButton.ForeColor = SystemColors.ControlLightLight;
            createAccountButton.Location = new Point(296, 425);
            createAccountButton.Margin = new Padding(2);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(122, 56);
            createAccountButton.TabIndex = 4;
            createAccountButton.Text = "Create";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userLabel.ForeColor = SystemColors.WindowText;
            userLabel.Location = new Point(266, 162);
            userLabel.Margin = new Padding(2, 0, 2, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(129, 25);
            userLabel.TabIndex = 12;
            userLabel.Text = "Your full name:";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            accountLabel.ForeColor = SystemColors.WindowText;
            accountLabel.Location = new Point(266, 245);
            accountLabel.Margin = new Padding(2, 0, 2, 0);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(152, 25);
            accountLabel.TabIndex = 13;
            accountLabel.Text = "Name of account:";
            // 
            // pinCodelabel
            // 
            pinCodelabel.AutoSize = true;
            pinCodelabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pinCodelabel.ForeColor = SystemColors.WindowText;
            pinCodelabel.Location = new Point(266, 334);
            pinCodelabel.Margin = new Padding(2, 0, 2, 0);
            pinCodelabel.Name = "pinCodelabel";
            pinCodelabel.Size = new Size(100, 25);
            pinCodelabel.TabIndex = 15;
            pinCodelabel.Text = "4 digit PIN:";
            // 
            // viewAccountsButton
            // 
            viewAccountsButton.BackColor = SystemColors.Highlight;
            viewAccountsButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            viewAccountsButton.ForeColor = SystemColors.ControlLightLight;
            viewAccountsButton.Location = new Point(12, 488);
            viewAccountsButton.Margin = new Padding(2);
            viewAccountsButton.Name = "viewAccountsButton";
            viewAccountsButton.Size = new Size(126, 56);
            viewAccountsButton.TabIndex = 16;
            viewAccountsButton.TabStop = false;
            viewAccountsButton.Text = "Accounts";
            viewAccountsButton.UseVisualStyleBackColor = false;
            viewAccountsButton.Click += viewAccountsButton_Click;
            // 
            // createLabel
            // 
            createLabel.AutoSize = true;
            createLabel.BackColor = SystemColors.ControlLight;
            createLabel.BorderStyle = BorderStyle.Fixed3D;
            createLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            createLabel.ForeColor = SystemColors.WindowText;
            createLabel.Location = new Point(90, 35);
            createLabel.Margin = new Padding(2, 0, 2, 0);
            createLabel.Name = "createLabel";
            createLabel.Size = new Size(535, 92);
            createLabel.TabIndex = 17;
            createLabel.Text = "                        Let us open an account.\r\nFill in all your information below and press \"Create\".\r\n                   You can create multiple accounts.\r\n";
            // 
            // AccountCreationForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(715, 555);
            Controls.Add(createLabel);
            Controls.Add(viewAccountsButton);
            Controls.Add(pinCodelabel);
            Controls.Add(accountLabel);
            Controls.Add(userLabel);
            Controls.Add(createAccountButton);
            Controls.Add(pinCodeTextbox);
            Controls.Add(accountNameTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "AccountCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            FormClosing += AccountCreationForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backButton;
        private TextBox userNameTextBox;
        private TextBox accountNameTextBox;
        private TextBox pinCodeTextbox;
        private Button createAccountButton;
        private Label userLabel;
        private Label accountLabel;
        private Label pinCodelabel;
        private Button viewAccountsButton;
        private Label createLabel;
    }
}