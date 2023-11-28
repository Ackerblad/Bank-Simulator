namespace Bank
{
    partial class ViewAccountForm
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
            viewAccountsListBox = new ListBox();
            deleteAccountButton = new Button();
            backButton = new Button();
            viewLabel = new Label();
            SuspendLayout();
            // 
            // viewAccountsListBox
            // 
            viewAccountsListBox.BackColor = SystemColors.ControlLightLight;
            viewAccountsListBox.FormattingEnabled = true;
            viewAccountsListBox.ItemHeight = 25;
            viewAccountsListBox.Location = new Point(226, 127);
            viewAccountsListBox.Name = "viewAccountsListBox";
            viewAccountsListBox.Size = new Size(384, 279);
            viewAccountsListBox.TabIndex = 1;
            viewAccountsListBox.TabStop = false;
            // 
            // deleteAccountButton
            // 
            deleteAccountButton.BackColor = SystemColors.Highlight;
            deleteAccountButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            deleteAccountButton.ForeColor = SystemColors.ControlLightLight;
            deleteAccountButton.Location = new Point(87, 230);
            deleteAccountButton.Name = "deleteAccountButton";
            deleteAccountButton.Size = new Size(122, 56);
            deleteAccountButton.TabIndex = 12;
            deleteAccountButton.TabStop = false;
            deleteAccountButton.Text = "Delete";
            deleteAccountButton.UseVisualStyleBackColor = false;
            deleteAccountButton.Click += deleteAccountButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Highlight;
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(666, 400);
            backButton.Name = "backButton";
            backButton.Size = new Size(122, 56);
            backButton.TabIndex = 14;
            backButton.TabStop = false;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // viewLabel
            // 
            viewLabel.AutoSize = true;
            viewLabel.BackColor = SystemColors.ControlLight;
            viewLabel.BorderStyle = BorderStyle.Fixed3D;
            viewLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            viewLabel.ForeColor = SystemColors.WindowText;
            viewLabel.Location = new Point(112, 27);
            viewLabel.Name = "viewLabel";
            viewLabel.Size = new Size(584, 62);
            viewLabel.TabIndex = 15;
            viewLabel.Text = "                      Here are all of your accounts.\r\nRemove an account by highlighting it and press \"Delete\".";
            // 
            // ViewAccountForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 468);
            Controls.Add(viewLabel);
            Controls.Add(backButton);
            Controls.Add(deleteAccountButton);
            Controls.Add(viewAccountsListBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ViewAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account Overview";
            FormClosing += ViewAccountForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox viewAccountsListBox;
        private Button deleteAccountButton;
        private Button backButton;
        private Label viewLabel;
    }
}