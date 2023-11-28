namespace Bank
{
    partial class AtmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtmForm));
            startPanel = new Panel();
            welcomeLabel = new Label();
            accountsListBox = new ListBox();
            pinCodePanel = new Panel();
            pinInputLabel = new Label();
            pinCodeLabel = new Label();
            transactionPanel = new Panel();
            balanceLabel = new Label();
            depositChoiceLabel = new Label();
            withdrawChoiceLabel = new Label();
            transactionLabel = new Label();
            atmButtonDown = new Button();
            atmButtonUp = new Button();
            atmButtonClear = new Button();
            atmButtonEnter = new Button();
            backButton = new Button();
            withdrawButton = new Button();
            depositButton = new Button();
            atmPanelKeys2 = new Panel();
            atmButtonCancel = new Button();
            withdrawPanel = new Panel();
            withdrawAmountLabel = new Label();
            withdrawLabel = new Label();
            depositPanel = new Panel();
            depositAmountLabel = new Label();
            depositLabel = new Label();
            atmButton7 = new Button();
            atmButton6 = new Button();
            atmButton4 = new Button();
            atmButton8 = new Button();
            atmButton5 = new Button();
            atmButton0 = new Button();
            atmButton2 = new Button();
            atmButton3 = new Button();
            atmButton9 = new Button();
            atmButton1 = new Button();
            atmPanelKeys1 = new Panel();
            atmPanelKeys4 = new Panel();
            atmPanelKeys3 = new Panel();
            startPanel.SuspendLayout();
            pinCodePanel.SuspendLayout();
            transactionPanel.SuspendLayout();
            atmPanelKeys2.SuspendLayout();
            withdrawPanel.SuspendLayout();
            depositPanel.SuspendLayout();
            atmPanelKeys1.SuspendLayout();
            atmPanelKeys4.SuspendLayout();
            atmPanelKeys3.SuspendLayout();
            SuspendLayout();
            // 
            // startPanel
            // 
            startPanel.BackColor = SystemColors.InactiveCaption;
            startPanel.BorderStyle = BorderStyle.Fixed3D;
            startPanel.Controls.Add(welcomeLabel);
            startPanel.Controls.Add(accountsListBox);
            startPanel.Location = new Point(216, 25);
            startPanel.Margin = new Padding(2);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(666, 246);
            startPanel.TabIndex = 10;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.FromArgb(64, 64, 64);
            welcomeLabel.Location = new Point(108, 19);
            welcomeLabel.Margin = new Padding(2, 0, 2, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(466, 70);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "                      Welcome! \r\nChoose an account from the list below.\r\n";
            // 
            // accountsListBox
            // 
            accountsListBox.BackColor = SystemColors.InactiveCaption;
            accountsListBox.BorderStyle = BorderStyle.None;
            accountsListBox.Enabled = false;
            accountsListBox.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            accountsListBox.ForeColor = Color.FromArgb(64, 64, 64);
            accountsListBox.FormattingEnabled = true;
            accountsListBox.ItemHeight = 35;
            accountsListBox.Location = new Point(108, 105);
            accountsListBox.Margin = new Padding(2);
            accountsListBox.Name = "accountsListBox";
            accountsListBox.Size = new Size(466, 105);
            accountsListBox.TabIndex = 0;
            accountsListBox.TabStop = false;
            // 
            // pinCodePanel
            // 
            pinCodePanel.BackColor = SystemColors.InactiveCaption;
            pinCodePanel.BorderStyle = BorderStyle.Fixed3D;
            pinCodePanel.Controls.Add(pinInputLabel);
            pinCodePanel.Controls.Add(pinCodeLabel);
            pinCodePanel.Location = new Point(216, 25);
            pinCodePanel.Margin = new Padding(2);
            pinCodePanel.Name = "pinCodePanel";
            pinCodePanel.Size = new Size(666, 246);
            pinCodePanel.TabIndex = 11;
            pinCodePanel.Visible = false;
            // 
            // pinInputLabel
            // 
            pinInputLabel.AutoSize = true;
            pinInputLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            pinInputLabel.ForeColor = Color.FromArgb(64, 64, 64);
            pinInputLabel.Location = new Point(264, 104);
            pinInputLabel.Margin = new Padding(2, 0, 2, 0);
            pinInputLabel.Name = "pinInputLabel";
            pinInputLabel.Size = new Size(0, 35);
            pinInputLabel.TabIndex = 2;
            // 
            // pinCodeLabel
            // 
            pinCodeLabel.AutoSize = true;
            pinCodeLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            pinCodeLabel.ForeColor = Color.FromArgb(64, 64, 64);
            pinCodeLabel.Location = new Point(248, 28);
            pinCodeLabel.Margin = new Padding(2, 0, 2, 0);
            pinCodeLabel.Name = "pinCodeLabel";
            pinCodeLabel.Size = new Size(124, 35);
            pinCodeLabel.TabIndex = 1;
            pinCodeLabel.Text = "Enter PIN";
            // 
            // transactionPanel
            // 
            transactionPanel.BackColor = SystemColors.InactiveCaption;
            transactionPanel.BorderStyle = BorderStyle.Fixed3D;
            transactionPanel.Controls.Add(balanceLabel);
            transactionPanel.Controls.Add(depositChoiceLabel);
            transactionPanel.Controls.Add(withdrawChoiceLabel);
            transactionPanel.Controls.Add(transactionLabel);
            transactionPanel.Location = new Point(216, 25);
            transactionPanel.Margin = new Padding(2);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.Size = new Size(666, 246);
            transactionPanel.TabIndex = 12;
            transactionPanel.Visible = false;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.BackColor = SystemColors.InactiveCaption;
            balanceLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            balanceLabel.ForeColor = Color.FromArgb(64, 64, 64);
            balanceLabel.Location = new Point(219, 121);
            balanceLabel.Margin = new Padding(2, 0, 2, 0);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(0, 29);
            balanceLabel.TabIndex = 5;
            // 
            // depositChoiceLabel
            // 
            depositChoiceLabel.AutoSize = true;
            depositChoiceLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            depositChoiceLabel.ForeColor = Color.FromArgb(64, 64, 64);
            depositChoiceLabel.Location = new Point(11, 168);
            depositChoiceLabel.Margin = new Padding(2, 0, 2, 0);
            depositChoiceLabel.Name = "depositChoiceLabel";
            depositChoiceLabel.Size = new Size(105, 35);
            depositChoiceLabel.TabIndex = 3;
            depositChoiceLabel.Text = "Deposit";
            // 
            // withdrawChoiceLabel
            // 
            withdrawChoiceLabel.AutoSize = true;
            withdrawChoiceLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            withdrawChoiceLabel.ForeColor = Color.FromArgb(64, 64, 64);
            withdrawChoiceLabel.Location = new Point(11, 76);
            withdrawChoiceLabel.Margin = new Padding(2, 0, 2, 0);
            withdrawChoiceLabel.Name = "withdrawChoiceLabel";
            withdrawChoiceLabel.Size = new Size(131, 35);
            withdrawChoiceLabel.TabIndex = 2;
            withdrawChoiceLabel.Text = "Withdraw";
            // 
            // transactionLabel
            // 
            transactionLabel.AutoSize = true;
            transactionLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            transactionLabel.ForeColor = Color.FromArgb(64, 64, 64);
            transactionLabel.Location = new Point(219, 28);
            transactionLabel.Margin = new Padding(2, 0, 2, 0);
            transactionLabel.Name = "transactionLabel";
            transactionLabel.Size = new Size(225, 35);
            transactionLabel.TabIndex = 1;
            transactionLabel.Text = "Select Transaction";
            // 
            // atmButtonDown
            // 
            atmButtonDown.FlatStyle = FlatStyle.Flat;
            atmButtonDown.Image = (Image)resources.GetObject("atmButtonDown.Image");
            atmButtonDown.Location = new Point(12, 148);
            atmButtonDown.Margin = new Padding(2);
            atmButtonDown.Name = "atmButtonDown";
            atmButtonDown.Size = new Size(98, 80);
            atmButtonDown.TabIndex = 14;
            atmButtonDown.TabStop = false;
            atmButtonDown.Tag = "atmButtonDown";
            atmButtonDown.UseVisualStyleBackColor = true;
            atmButtonDown.Click += atmButtonDown_Click;
            // 
            // atmButtonUp
            // 
            atmButtonUp.FlatStyle = FlatStyle.Flat;
            atmButtonUp.Image = (Image)resources.GetObject("atmButtonUp.Image");
            atmButtonUp.Location = new Point(12, 55);
            atmButtonUp.Margin = new Padding(2);
            atmButtonUp.Name = "atmButtonUp";
            atmButtonUp.Size = new Size(98, 80);
            atmButtonUp.TabIndex = 13;
            atmButtonUp.TabStop = false;
            atmButtonUp.Tag = "atmButtonUp";
            atmButtonUp.UseVisualStyleBackColor = true;
            atmButtonUp.Click += atmButtonUp_Click;
            // 
            // atmButtonClear
            // 
            atmButtonClear.FlatStyle = FlatStyle.Flat;
            atmButtonClear.Image = (Image)resources.GetObject("atmButtonClear.Image");
            atmButtonClear.Location = new Point(11, 111);
            atmButtonClear.Margin = new Padding(2);
            atmButtonClear.Name = "atmButtonClear";
            atmButtonClear.Size = new Size(199, 79);
            atmButtonClear.TabIndex = 12;
            atmButtonClear.TabStop = false;
            atmButtonClear.Tag = "clear";
            atmButtonClear.UseVisualStyleBackColor = true;
            atmButtonClear.Click += atmButtonClear_Click;
            // 
            // atmButtonEnter
            // 
            atmButtonEnter.FlatStyle = FlatStyle.Flat;
            atmButtonEnter.Image = (Image)resources.GetObject("atmButtonEnter.Image");
            atmButtonEnter.Location = new Point(11, 211);
            atmButtonEnter.Margin = new Padding(2);
            atmButtonEnter.Name = "atmButtonEnter";
            atmButtonEnter.Size = new Size(199, 79);
            atmButtonEnter.TabIndex = 10;
            atmButtonEnter.TabStop = false;
            atmButtonEnter.Tag = "enter";
            atmButtonEnter.UseVisualStyleBackColor = true;
            atmButtonEnter.Click += atmButtonEnter_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Highlight;
            backButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(972, 646);
            backButton.Margin = new Padding(2);
            backButton.Name = "backButton";
            backButton.Size = new Size(122, 56);
            backButton.TabIndex = 12;
            backButton.TabStop = false;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.Image = (Image)resources.GetObject("withdrawButton.Image");
            withdrawButton.Location = new Point(12, 55);
            withdrawButton.Margin = new Padding(2);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(98, 80);
            withdrawButton.TabIndex = 16;
            withdrawButton.TabStop = false;
            withdrawButton.Tag = "withdrawButton";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Image = (Image)resources.GetObject("depositButton.Image");
            depositButton.Location = new Point(12, 148);
            depositButton.Margin = new Padding(2);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(98, 80);
            depositButton.TabIndex = 17;
            depositButton.TabStop = false;
            depositButton.Tag = "depositButton";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // atmPanelKeys2
            // 
            atmPanelKeys2.BackColor = SystemColors.ActiveBorder;
            atmPanelKeys2.BorderStyle = BorderStyle.Fixed3D;
            atmPanelKeys2.Controls.Add(atmButtonCancel);
            atmPanelKeys2.Controls.Add(atmButtonClear);
            atmPanelKeys2.Controls.Add(atmButtonEnter);
            atmPanelKeys2.Location = new Point(631, 278);
            atmPanelKeys2.Margin = new Padding(2);
            atmPanelKeys2.Name = "atmPanelKeys2";
            atmPanelKeys2.Size = new Size(225, 306);
            atmPanelKeys2.TabIndex = 12;
            // 
            // atmButtonCancel
            // 
            atmButtonCancel.FlatStyle = FlatStyle.Flat;
            atmButtonCancel.Image = (Image)resources.GetObject("atmButtonCancel.Image");
            atmButtonCancel.Location = new Point(11, 10);
            atmButtonCancel.Margin = new Padding(2);
            atmButtonCancel.Name = "atmButtonCancel";
            atmButtonCancel.Size = new Size(199, 79);
            atmButtonCancel.TabIndex = 13;
            atmButtonCancel.TabStop = false;
            atmButtonCancel.Tag = "cancel";
            atmButtonCancel.UseVisualStyleBackColor = true;
            atmButtonCancel.Click += atmButtonCancel_Click;
            // 
            // withdrawPanel
            // 
            withdrawPanel.BackColor = SystemColors.InactiveCaption;
            withdrawPanel.BorderStyle = BorderStyle.Fixed3D;
            withdrawPanel.Controls.Add(withdrawAmountLabel);
            withdrawPanel.Controls.Add(withdrawLabel);
            withdrawPanel.Location = new Point(216, 25);
            withdrawPanel.Margin = new Padding(2);
            withdrawPanel.Name = "withdrawPanel";
            withdrawPanel.Size = new Size(666, 246);
            withdrawPanel.TabIndex = 13;
            withdrawPanel.Visible = false;
            // 
            // withdrawAmountLabel
            // 
            withdrawAmountLabel.AutoSize = true;
            withdrawAmountLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            withdrawAmountLabel.ForeColor = Color.FromArgb(64, 64, 64);
            withdrawAmountLabel.Location = new Point(248, 104);
            withdrawAmountLabel.Margin = new Padding(2, 0, 2, 0);
            withdrawAmountLabel.Name = "withdrawAmountLabel";
            withdrawAmountLabel.Size = new Size(0, 35);
            withdrawAmountLabel.TabIndex = 6;
            // 
            // withdrawLabel
            // 
            withdrawLabel.AutoSize = true;
            withdrawLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            withdrawLabel.ForeColor = Color.FromArgb(64, 64, 64);
            withdrawLabel.Location = new Point(178, 28);
            withdrawLabel.Margin = new Padding(2, 0, 2, 0);
            withdrawLabel.Name = "withdrawLabel";
            withdrawLabel.Size = new Size(325, 35);
            withdrawLabel.TabIndex = 1;
            withdrawLabel.Text = "Enter amount to withdraw";
            // 
            // depositPanel
            // 
            depositPanel.BackColor = SystemColors.InactiveCaption;
            depositPanel.BorderStyle = BorderStyle.Fixed3D;
            depositPanel.Controls.Add(depositAmountLabel);
            depositPanel.Controls.Add(depositLabel);
            depositPanel.Location = new Point(216, 25);
            depositPanel.Margin = new Padding(2);
            depositPanel.Name = "depositPanel";
            depositPanel.Size = new Size(666, 246);
            depositPanel.TabIndex = 14;
            depositPanel.Visible = false;
            // 
            // depositAmountLabel
            // 
            depositAmountLabel.AutoSize = true;
            depositAmountLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            depositAmountLabel.ForeColor = Color.FromArgb(64, 64, 64);
            depositAmountLabel.Location = new Point(254, 104);
            depositAmountLabel.Margin = new Padding(2, 0, 2, 0);
            depositAmountLabel.Name = "depositAmountLabel";
            depositAmountLabel.Size = new Size(0, 35);
            depositAmountLabel.TabIndex = 6;
            // 
            // depositLabel
            // 
            depositLabel.AutoSize = true;
            depositLabel.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            depositLabel.ForeColor = Color.FromArgb(64, 64, 64);
            depositLabel.Location = new Point(182, 32);
            depositLabel.Margin = new Padding(2, 0, 2, 0);
            depositLabel.Name = "depositLabel";
            depositLabel.Size = new Size(300, 35);
            depositLabel.TabIndex = 1;
            depositLabel.Text = "Enter amount to deposit";
            // 
            // atmButton7
            // 
            atmButton7.FlatStyle = FlatStyle.Flat;
            atmButton7.Image = (Image)resources.GetObject("atmButton7.Image");
            atmButton7.Location = new Point(15, 211);
            atmButton7.Margin = new Padding(2);
            atmButton7.Name = "atmButton7";
            atmButton7.Size = new Size(98, 80);
            atmButton7.TabIndex = 6;
            atmButton7.TabStop = false;
            atmButton7.Tag = "7";
            atmButton7.UseVisualStyleBackColor = true;
            atmButton7.Click += numberButton_Click;
            // 
            // atmButton6
            // 
            atmButton6.FlatStyle = FlatStyle.Flat;
            atmButton6.Image = (Image)resources.GetObject("atmButton6.Image");
            atmButton6.Location = new Point(245, 110);
            atmButton6.Margin = new Padding(2);
            atmButton6.Name = "atmButton6";
            atmButton6.Size = new Size(98, 80);
            atmButton6.TabIndex = 5;
            atmButton6.TabStop = false;
            atmButton6.Tag = "6";
            atmButton6.UseVisualStyleBackColor = true;
            atmButton6.Click += numberButton_Click;
            // 
            // atmButton4
            // 
            atmButton4.FlatStyle = FlatStyle.Flat;
            atmButton4.Image = (Image)resources.GetObject("atmButton4.Image");
            atmButton4.Location = new Point(15, 110);
            atmButton4.Margin = new Padding(2);
            atmButton4.Name = "atmButton4";
            atmButton4.Size = new Size(98, 80);
            atmButton4.TabIndex = 3;
            atmButton4.TabStop = false;
            atmButton4.Tag = "4";
            atmButton4.UseVisualStyleBackColor = true;
            atmButton4.Click += numberButton_Click;
            // 
            // atmButton8
            // 
            atmButton8.FlatStyle = FlatStyle.Flat;
            atmButton8.Image = (Image)resources.GetObject("atmButton8.Image");
            atmButton8.Location = new Point(132, 211);
            atmButton8.Margin = new Padding(2);
            atmButton8.Name = "atmButton8";
            atmButton8.Size = new Size(98, 80);
            atmButton8.TabIndex = 7;
            atmButton8.TabStop = false;
            atmButton8.Tag = "8";
            atmButton8.UseVisualStyleBackColor = true;
            atmButton8.Click += numberButton_Click;
            // 
            // atmButton5
            // 
            atmButton5.FlatStyle = FlatStyle.Flat;
            atmButton5.Image = (Image)resources.GetObject("atmButton5.Image");
            atmButton5.Location = new Point(132, 110);
            atmButton5.Margin = new Padding(2);
            atmButton5.Name = "atmButton5";
            atmButton5.Size = new Size(98, 80);
            atmButton5.TabIndex = 4;
            atmButton5.TabStop = false;
            atmButton5.Tag = "5";
            atmButton5.UseVisualStyleBackColor = true;
            atmButton5.Click += numberButton_Click;
            // 
            // atmButton0
            // 
            atmButton0.FlatStyle = FlatStyle.Flat;
            atmButton0.Image = (Image)resources.GetObject("atmButton0.Image");
            atmButton0.Location = new Point(132, 308);
            atmButton0.Margin = new Padding(2);
            atmButton0.Name = "atmButton0";
            atmButton0.Size = new Size(98, 80);
            atmButton0.TabIndex = 9;
            atmButton0.TabStop = false;
            atmButton0.Tag = "0";
            atmButton0.UseVisualStyleBackColor = true;
            atmButton0.Click += numberButton_Click;
            // 
            // atmButton2
            // 
            atmButton2.FlatStyle = FlatStyle.Flat;
            atmButton2.Image = (Image)resources.GetObject("atmButton2.Image");
            atmButton2.Location = new Point(132, 9);
            atmButton2.Margin = new Padding(2);
            atmButton2.Name = "atmButton2";
            atmButton2.Size = new Size(98, 80);
            atmButton2.TabIndex = 1;
            atmButton2.TabStop = false;
            atmButton2.Tag = "2";
            atmButton2.UseVisualStyleBackColor = true;
            atmButton2.Click += numberButton_Click;
            // 
            // atmButton3
            // 
            atmButton3.FlatStyle = FlatStyle.Flat;
            atmButton3.Image = (Image)resources.GetObject("atmButton3.Image");
            atmButton3.Location = new Point(245, 9);
            atmButton3.Margin = new Padding(2);
            atmButton3.Name = "atmButton3";
            atmButton3.Size = new Size(98, 80);
            atmButton3.TabIndex = 2;
            atmButton3.TabStop = false;
            atmButton3.Tag = "3";
            atmButton3.UseVisualStyleBackColor = true;
            atmButton3.Click += numberButton_Click;
            // 
            // atmButton9
            // 
            atmButton9.FlatStyle = FlatStyle.Flat;
            atmButton9.Image = (Image)resources.GetObject("atmButton9.Image");
            atmButton9.Location = new Point(245, 211);
            atmButton9.Margin = new Padding(2);
            atmButton9.Name = "atmButton9";
            atmButton9.Size = new Size(98, 80);
            atmButton9.TabIndex = 8;
            atmButton9.TabStop = false;
            atmButton9.Tag = "9";
            atmButton9.UseVisualStyleBackColor = true;
            atmButton9.Click += numberButton_Click;
            // 
            // atmButton1
            // 
            atmButton1.BackColor = SystemColors.ControlLightLight;
            atmButton1.FlatStyle = FlatStyle.Flat;
            atmButton1.Image = (Image)resources.GetObject("atmButton1.Image");
            atmButton1.Location = new Point(15, 9);
            atmButton1.Margin = new Padding(2);
            atmButton1.Name = "atmButton1";
            atmButton1.Size = new Size(98, 80);
            atmButton1.TabIndex = 0;
            atmButton1.TabStop = false;
            atmButton1.Tag = "1";
            atmButton1.UseVisualStyleBackColor = false;
            atmButton1.Click += numberButton_Click;
            // 
            // atmPanelKeys1
            // 
            atmPanelKeys1.BackColor = SystemColors.ActiveBorder;
            atmPanelKeys1.BackgroundImageLayout = ImageLayout.None;
            atmPanelKeys1.BorderStyle = BorderStyle.Fixed3D;
            atmPanelKeys1.Controls.Add(atmButton1);
            atmPanelKeys1.Controls.Add(atmButton9);
            atmPanelKeys1.Controls.Add(atmButton3);
            atmPanelKeys1.Controls.Add(atmButton2);
            atmPanelKeys1.Controls.Add(atmButton0);
            atmPanelKeys1.Controls.Add(atmButton5);
            atmPanelKeys1.Controls.Add(atmButton8);
            atmPanelKeys1.Controls.Add(atmButton4);
            atmPanelKeys1.Controls.Add(atmButton6);
            atmPanelKeys1.Controls.Add(atmButton7);
            atmPanelKeys1.Location = new Point(245, 278);
            atmPanelKeys1.Margin = new Padding(2);
            atmPanelKeys1.Name = "atmPanelKeys1";
            atmPanelKeys1.Size = new Size(366, 404);
            atmPanelKeys1.TabIndex = 11;
            // 
            // atmPanelKeys4
            // 
            atmPanelKeys4.BackColor = SystemColors.ActiveBorder;
            atmPanelKeys4.BorderStyle = BorderStyle.Fixed3D;
            atmPanelKeys4.Controls.Add(atmButtonUp);
            atmPanelKeys4.Controls.Add(atmButtonDown);
            atmPanelKeys4.Location = new Point(889, 25);
            atmPanelKeys4.Margin = new Padding(2);
            atmPanelKeys4.Name = "atmPanelKeys4";
            atmPanelKeys4.Size = new Size(126, 246);
            atmPanelKeys4.TabIndex = 18;
            // 
            // atmPanelKeys3
            // 
            atmPanelKeys3.BackColor = SystemColors.ActiveBorder;
            atmPanelKeys3.BorderStyle = BorderStyle.Fixed3D;
            atmPanelKeys3.Controls.Add(withdrawButton);
            atmPanelKeys3.Controls.Add(depositButton);
            atmPanelKeys3.Location = new Point(82, 25);
            atmPanelKeys3.Margin = new Padding(2);
            atmPanelKeys3.Name = "atmPanelKeys3";
            atmPanelKeys3.Size = new Size(126, 246);
            atmPanelKeys3.TabIndex = 19;
            // 
            // AtmForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Silver;
            ClientSize = new Size(1108, 714);
            Controls.Add(depositPanel);
            Controls.Add(withdrawPanel);
            Controls.Add(atmPanelKeys3);
            Controls.Add(atmPanelKeys4);
            Controls.Add(transactionPanel);
            Controls.Add(pinCodePanel);
            Controls.Add(atmPanelKeys2);
            Controls.Add(backButton);
            Controls.Add(atmPanelKeys1);
            Controls.Add(startPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "AtmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATM";
            FormClosing += AtmForm_FormClosing;
            startPanel.ResumeLayout(false);
            startPanel.PerformLayout();
            pinCodePanel.ResumeLayout(false);
            pinCodePanel.PerformLayout();
            transactionPanel.ResumeLayout(false);
            transactionPanel.PerformLayout();
            atmPanelKeys2.ResumeLayout(false);
            withdrawPanel.ResumeLayout(false);
            withdrawPanel.PerformLayout();
            depositPanel.ResumeLayout(false);
            depositPanel.PerformLayout();
            atmPanelKeys1.ResumeLayout(false);
            atmPanelKeys4.ResumeLayout(false);
            atmPanelKeys3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel startPanel;
        private Button atmButtonClear;
        private Button atmButtonEnter;
        private Button atmButtonDown;
        private Button atmButtonUp;
        private Button backButton;
        private ListBox accountsListBox;
        private Label welcomeLabel;
        private Panel pinCodePanel;
        private Label pinCodeLabel;
        private Panel transactionPanel;
        private Label transactionLabel;
        private Button withdrawButton;
        private Button depositButton;
        private Panel atmPanelKeys2;
        private Label depositChoiceLabel;
        private Label withdrawChoiceLabel;
        private Panel withdrawPanel;
        private Label withdrawLabel;
        private Panel depositPanel;
        private Label depositLabel;
        private Button atmButtonCancel;
        private Label balanceLabel;
        private Label withdrawAmountLabel;
        private Label pinInputLabel;
        private Label depositAmountLabel;
        private Button atmButton7;
        private Button atmButton6;
        private Button atmButton4;
        private Button atmButton8;
        private Button atmButton5;
        private Button atmButton0;
        private Button atmButton2;
        private Button atmButton3;
        private Button atmButton9;
        private Button atmButton1;
        private Panel atmPanelKeys1;
        private Panel atmPanelKeys4;
        private Panel atmPanelKeys3;
    }
}