using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class unblockAccountForm : Form
    {
        private List<Account> existingAccounts = new List<Account>();

        private bool closingFromBackButton = false;

        public unblockAccountForm()
        {
            InitializeComponent();
            LoadAccounts();
        }

        //Show the blocked accounts that exists in the CSV file 
        private void LoadAccounts()
        {
            var fileManager = new AccountFileManager();

            existingAccounts = fileManager.LoadAccountsFromFile();

            var blockedAccounts = existingAccounts.Where(a => a.IsBlocked).Select(a => $"{a.AccountName} - {a.GetAccountStatus()}").ToList();

            blockedAccountsListBox.DataSource = blockedAccounts;
        }

        //Unblock the account and update the pincode in the CSV file
        private void unblockAccountButton_Click(object sender, EventArgs e)
        {
            if (blockedAccountsListBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(newPinTextBox.Text) || newPinTextBox.Text.Length != 4)
            {
                MessageBox.Show("Please select an account and enter a new PIN.");
                newPinTextBox.Text = "";
            }
            else
            {
                try
                {
                    var selectedAccountDetails = blockedAccountsListBox.SelectedItem.ToString();
                    var accountName = selectedAccountDetails.Split('-')[0].Trim();

                    var accountToUnblock = existingAccounts.FirstOrDefault(a => a.AccountName == accountName && a.IsBlocked);

                    if (accountToUnblock != null)
                    {
                        accountToUnblock.UnblockAccount();
                        accountToUnblock.UpdatePinCode(Convert.ToInt32(newPinTextBox.Text));

                        var fileManager = new AccountFileManager();
                        fileManager.SaveAccountsToFile(existingAccounts);

                        LoadAccounts();
                        MessageBox.Show("Account unblocked and new PIN set.");
                        newPinTextBox.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error unblocking account: {ex.Message}");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closingFromBackButton = true;
            this.Close();
        }

        private void UnblockAccountForm_FormClosing(object sender, FormClosingEventArgs e)
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
