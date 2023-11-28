namespace Bank
{
    partial class FormBank
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
            officeButton = new Button();
            atmButton = new Button();
            welcomeLabel = new Label();
            SuspendLayout();
            // 
            // officeButton
            // 
            officeButton.BackColor = SystemColors.Highlight;
            officeButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            officeButton.ForeColor = SystemColors.ControlLightLight;
            officeButton.Location = new Point(54, 167);
            officeButton.Name = "officeButton";
            officeButton.Size = new Size(106, 54);
            officeButton.TabIndex = 0;
            officeButton.TabStop = false;
            officeButton.Text = "Office";
            officeButton.UseVisualStyleBackColor = false;
            officeButton.Click += officeButton_Click;
            // 
            // atmButton
            // 
            atmButton.BackColor = SystemColors.Highlight;
            atmButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            atmButton.ForeColor = SystemColors.ControlLightLight;
            atmButton.Location = new Point(378, 167);
            atmButton.Name = "atmButton";
            atmButton.Size = new Size(106, 54);
            atmButton.TabIndex = 1;
            atmButton.TabStop = false;
            atmButton.Text = "ATM";
            atmButton.UseVisualStyleBackColor = false;
            atmButton.Click += atmButton_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = SystemColors.ControlLight;
            welcomeLabel.BorderStyle = BorderStyle.Fixed3D;
            welcomeLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.ForeColor = SystemColors.WindowText;
            welcomeLabel.Location = new Point(54, 30);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(430, 92);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "                        Welcome! \r\nGo to the office to manage your account. \r\nGo to the ATM to make a transaction.\r\n";
            // 
            // FormBank
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            ClientSize = new Size(537, 273);
            Controls.Add(welcomeLabel);
            Controls.Add(atmButton);
            Controls.Add(officeButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(563, 333);
            MinimumSize = new Size(563, 333);
            Name = "FormBank";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bank";
            FormClosing += FormBank_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button officeButton;
        private Button atmButton;
        private Label welcomeLabel;
    }
}