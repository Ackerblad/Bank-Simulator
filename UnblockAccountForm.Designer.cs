namespace Bank
{
    partial class unblockAccountForm
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
            blockedAccountsListBox = new ListBox();
            backButton = new Button();
            unblockAccountButton = new Button();
            unblockLabel = new Label();
            newPinTextBox = new TextBox();
            pinCodeLabel = new Label();
            SuspendLayout();
            // 
            // blockedAccountsListBox
            // 
            blockedAccountsListBox.BackColor = SystemColors.ControlLightLight;
            blockedAccountsListBox.FormattingEnabled = true;
            blockedAccountsListBox.ItemHeight = 25;
            blockedAccountsListBox.Location = new Point(289, 147);
            blockedAccountsListBox.Name = "blockedAccountsListBox";
            blockedAccountsListBox.Size = new Size(279, 279);
            blockedAccountsListBox.TabIndex = 1;
            blockedAccountsListBox.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Highlight;
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(666, 436);
            backButton.Name = "backButton";
            backButton.Size = new Size(122, 56);
            backButton.TabIndex = 15;
            backButton.TabStop = false;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // unblockAccountButton
            // 
            unblockAccountButton.BackColor = SystemColors.Highlight;
            unblockAccountButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            unblockAccountButton.ForeColor = SystemColors.ControlLightLight;
            unblockAccountButton.Location = new Point(117, 276);
            unblockAccountButton.Name = "unblockAccountButton";
            unblockAccountButton.Size = new Size(140, 46);
            unblockAccountButton.TabIndex = 2;
            unblockAccountButton.TabStop = false;
            unblockAccountButton.Text = "Unblock";
            unblockAccountButton.UseVisualStyleBackColor = false;
            unblockAccountButton.Click += unblockAccountButton_Click;
            // 
            // unblockLabel
            // 
            unblockLabel.AutoSize = true;
            unblockLabel.BackColor = SystemColors.ControlLight;
            unblockLabel.BorderStyle = BorderStyle.Fixed3D;
            unblockLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            unblockLabel.ForeColor = SystemColors.WindowText;
            unblockLabel.Location = new Point(207, 23);
            unblockLabel.Name = "unblockLabel";
            unblockLabel.Size = new Size(415, 92);
            unblockLabel.TabIndex = 17;
            unblockLabel.Text = "      Here are your blocked accounts.\r\nSelect the account you want to unblock.\r\nEnter a new PIN and press \"Unblock\".";
            // 
            // newPinTextBox
            // 
            newPinTextBox.Location = new Point(117, 218);
            newPinTextBox.MaxLength = 4;
            newPinTextBox.Name = "newPinTextBox";
            newPinTextBox.Size = new Size(140, 31);
            newPinTextBox.TabIndex = 1;
            newPinTextBox.TabStop = false;
            // 
            // pinCodeLabel
            // 
            pinCodeLabel.AutoSize = true;
            pinCodeLabel.Location = new Point(117, 190);
            pinCodeLabel.Name = "pinCodeLabel";
            pinCodeLabel.Size = new Size(140, 25);
            pinCodeLabel.TabIndex = 18;
            pinCodeLabel.Text = "New 4 digit PIN:";
            // 
            // unblockAccountForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 504);
            Controls.Add(pinCodeLabel);
            Controls.Add(newPinTextBox);
            Controls.Add(unblockLabel);
            Controls.Add(unblockAccountButton);
            Controls.Add(backButton);
            Controls.Add(blockedAccountsListBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "unblockAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unblock Account";
            FormClosing += UnblockAccountForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox blockedAccountsListBox;
        private Button backButton;
        private Button unblockAccountButton;
        private Label unblockLabel;
        private TextBox newPinTextBox;
        private Label pinCodeLabel;
    }
}