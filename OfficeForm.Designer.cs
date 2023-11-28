namespace Bank
{
    partial class OfficeForm
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
            openAccountButton = new Button();
            backButton = new Button();
            officeLabel = new Label();
            unblockAccountButton = new Button();
            SuspendLayout();
            // 
            // openAccountButton
            // 
            openAccountButton.BackColor = SystemColors.Highlight;
            openAccountButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            openAccountButton.ForeColor = SystemColors.ControlLightLight;
            openAccountButton.Location = new Point(193, 130);
            openAccountButton.Name = "openAccountButton";
            openAccountButton.Size = new Size(192, 60);
            openAccountButton.TabIndex = 4;
            openAccountButton.TabStop = false;
            openAccountButton.Text = "Open Account";
            openAccountButton.UseVisualStyleBackColor = false;
            openAccountButton.Click += openAccountButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Highlight;
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(476, 276);
            backButton.Name = "backButton";
            backButton.Size = new Size(122, 56);
            backButton.TabIndex = 5;
            backButton.TabStop = false;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // officeLabel
            // 
            officeLabel.AutoSize = true;
            officeLabel.BackColor = SystemColors.ControlLight;
            officeLabel.BorderStyle = BorderStyle.Fixed3D;
            officeLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            officeLabel.ForeColor = SystemColors.WindowText;
            officeLabel.Location = new Point(157, 30);
            officeLabel.Name = "officeLabel";
            officeLabel.Size = new Size(270, 66);
            officeLabel.TabIndex = 16;
            officeLabel.Text = "Welcome to the office! \r\nHow can we help you?\r\n";
            // 
            // unblockAccountButton
            // 
            unblockAccountButton.BackColor = SystemColors.Highlight;
            unblockAccountButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            unblockAccountButton.ForeColor = SystemColors.ControlLightLight;
            unblockAccountButton.Location = new Point(193, 205);
            unblockAccountButton.Name = "unblockAccountButton";
            unblockAccountButton.Size = new Size(192, 60);
            unblockAccountButton.TabIndex = 17;
            unblockAccountButton.TabStop = false;
            unblockAccountButton.Text = "Unblock Account";
            unblockAccountButton.UseVisualStyleBackColor = false;
            unblockAccountButton.Click += unblockAccountButton_Click;
            // 
            // OfficeForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(610, 344);
            Controls.Add(unblockAccountButton);
            Controls.Add(officeLabel);
            Controls.Add(backButton);
            Controls.Add(openAccountButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "OfficeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Office";
            FormClosing += OfficeForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button openAccountButton;
        private Button backButton;
        private Label officeLabel;
        private Button unblockAccountButton;
    }
}