using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class AtmForm : Form
    {
        private List<Account> existingAccounts = new List<Account>();

        private Account selectedAccount;

        public bool closingFromBackButton = false;

        //Different states of the ATM used for the functions of the buttons
        public enum AtmState
        {
            SelectAccount,
            EnterPin,
            Transaction,
            WithdrawTransaction,
            DepositTransaction
        }

        private AtmState currentState = AtmState.SelectAccount;

        public AtmForm()
        {
            InitializeComponent();
            LoadAccounts();
        }

        //Show the accounts that exists in the CSV file 
        private void LoadAccounts()
        {
            var fileManager = new AccountFileManager();
            existingAccounts = fileManager.LoadAccountsFromFile();

            accountsListBox.DataSource = existingAccounts;
            accountsListBox.DisplayMember = "AccountName";
        }

        //Change account selection with the up and down buttons
        private void MoveSelection(int direction)
        {
            int newIndex = accountsListBox.SelectedIndex + direction;

            if (newIndex >= 0 && newIndex < accountsListBox.Items.Count)
            {
                accountsListBox.SelectedIndex = newIndex;
            }
        }

        private void atmButtonUp_Click(object sender, EventArgs e)
        {
            MoveSelection(-1);
        }

        private void atmButtonDown_Click(object sender, EventArgs e)
        {
            MoveSelection(1);
        }

        //Enter button is only used in some states of the ATM
        private void atmButtonEnter_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case AtmState.SelectAccount:
                    if (accountsListBox.SelectedIndex != -1)
                    {
                        selectedAccount = existingAccounts[accountsListBox.SelectedIndex];

                        if (!selectedAccount.IsBlocked)
                        {
                            currentState = AtmState.EnterPin;
                            pinCodePanel.Visible = true;
                            startPanel.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("This account is blocked, visit the office to unblock it.");
                        }
                    }
                    break;
                case AtmState.EnterPin:
                    if (!String.IsNullOrWhiteSpace(pinInputLabel.Text))
                    {
                        validatePin();
                    }
                    else
                    {
                        MessageBox.Show("Please enter your PIN.");
                    }
                    break;
                case AtmState.WithdrawTransaction:
                    performWithdrawl();
                    break;
                case AtmState.DepositTransaction:
                    performDeposit();
                    break;
            }
        }

        private void atmButtonClear_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case AtmState.EnterPin:
                    pinInputLabel.Text = "";
                    break;
                case AtmState.WithdrawTransaction:
                    withdrawAmountLabel.Text = "";
                    break;
                case AtmState.DepositTransaction:
                    depositAmountLabel.Text = "";
                    break;
            }
        }

        //Cancel button is used to return to the previous panel in the ATM
        private void atmButtonCancel_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case AtmState.EnterPin:
                    startPanel.Visible = true;
                    pinCodePanel.Visible = false;
                    pinInputLabel.Text = "";
                    currentState = AtmState.SelectAccount;
                    break;
                case AtmState.Transaction:
                    startPanel.Visible = true;
                    transactionPanel.Visible = false;
                    currentState = AtmState.SelectAccount;
                    break;
                case AtmState.WithdrawTransaction:
                    transactionPanel.Visible = true;
                    withdrawPanel.Visible = false;
                    withdrawAmountLabel.Text = "";
                    currentState = AtmState.Transaction;
                    break;
                case AtmState.DepositTransaction:
                    transactionPanel.Visible = true;
                    depositPanel.Visible = false;
                    depositAmountLabel.Text = "";
                    currentState = AtmState.Transaction;
                    break;
            }
        }

        //Validate the users pincode input and compare it to the hashed version in the CSV file
        private void validatePin()
        {
            if (int.TryParse(pinInputLabel.Text, out int inputPin) && selectedAccount.VerifyPinCode(inputPin))
            {
                currentState = AtmState.Transaction;
                transactionPanel.Visible = true;
                pinCodePanel.Visible = false;
                pinInputLabel.Text = "";
                selectedAccount.ResetFailedPinAttempts();

                balanceLabel.Text = $"Balance: {selectedAccount.Balance.ToString()} SEK";
            }
            else
            {
                selectedAccount.FailedPinAttempts();
                pinInputLabel.Text = "";

                if (selectedAccount.IsBlocked)
                {
                    var fileManager = new AccountFileManager();
                    fileManager.SaveAccountsToFile(existingAccounts);

                    MessageBox.Show("Your account has been blocked due to too many failed attempts.");
                    currentState = AtmState.SelectAccount;
                    startPanel.Visible = true;
                    pinCodePanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect PIN, try again.");
                }
                pinInputLabel.Text = "";
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (currentState == AtmState.Transaction)
            {
                currentState = AtmState.WithdrawTransaction;

                withdrawPanel.Visible = true;
                transactionPanel.Visible = false;
            }
        }

        private void performWithdrawl()
        {
            if (decimal.TryParse(withdrawAmountLabel.Text, out decimal withdrawAmount))
            {
                if (withdrawAmount <= selectedAccount.Balance && withdrawAmount > 0)
                {
                    selectedAccount.Balance -= withdrawAmount;

                    var fileManager = new AccountFileManager();
                    fileManager.SaveAccountsToFile(existingAccounts);

                    balanceLabel.Text = $"Current balance: {selectedAccount.Balance.ToString()} SEK";
                    MessageBox.Show($"Withdrawal of {withdrawAmount} SEK was successful.");

                    withdrawAmountLabel.Text = "";
                    transactionPanel.Visible = true;
                    withdrawPanel.Visible = false;

                    currentState = AtmState.Transaction;
                }
                else if (withdrawAmount > selectedAccount.Balance)
                {
                    MessageBox.Show($"You do not have enough money on you account, current balance: {selectedAccount.Balance} SEK");
                    withdrawAmountLabel.Text = "";
                    transactionPanel.Visible = true;
                    withdrawPanel.Visible = false;

                    currentState = AtmState.Transaction;
                }
                else if (withdrawAmount <= 0)
                {
                    MessageBox.Show("Withdrawal failed, enter a positive amount.");
                    withdrawAmountLabel.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
                withdrawAmountLabel.Text = "";
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (currentState == AtmState.Transaction)
            {
                currentState = AtmState.DepositTransaction;

                depositPanel.Visible = true;
                transactionPanel.Visible = false;
            }       
        }

        private void performDeposit()
        {
            if (decimal.TryParse(depositAmountLabel.Text, out decimal depositAmount))
            {
                if (depositAmount > 0)
                {
                    selectedAccount.Balance += depositAmount;

                    var fileManager = new AccountFileManager();
                    fileManager.SaveAccountsToFile(existingAccounts);

                    balanceLabel.Text = $"Current balance: {selectedAccount.Balance.ToString()} SEK";
                    MessageBox.Show($"Deposit of {depositAmount} SEK was successful.");

                    depositAmountLabel.Text = "";
                    transactionPanel.Visible = true;
                    depositPanel.Visible = false;

                    currentState = AtmState.Transaction;
                }
                else
                {
                    MessageBox.Show("Deposit failed, enter a positive amount.");
                    depositAmountLabel.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
                depositAmountLabel.Text = "";
            }
        }

        //The output from the number buttons are decided by the tag of the button
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button numberButton = sender as Button;

            if (numberButton != null && numberButton.Tag is string number)
            {
                if (currentState == AtmState.EnterPin)
                {
                    if (pinInputLabel.Text.Length < 4)
                    {
                        pinInputLabel.Text += number;
                    }
                }
                else if (currentState == AtmState.WithdrawTransaction)
                {
                    withdrawAmountLabel.Text += number;
                }
                else if (currentState == AtmState.DepositTransaction)
                {
                    depositAmountLabel.Text += number;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closingFromBackButton = true;
            this.Close();
        }

        private void AtmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closingFromBackButton && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you want to quit?", "Leave the bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
