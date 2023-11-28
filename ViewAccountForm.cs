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
    public partial class ViewAccountForm : Form
    {
        private List<Account> existingAccounts = new List<Account>();

        private bool closingFromBackButton = false;

        public ViewAccountForm()
        {
            InitializeComponent();
            LoadAccounts();
        }

        //Show the accounts that exists in the CSV file
        private void LoadAccounts()
        {
            var fileManager = new AccountFileManager();

            existingAccounts = fileManager.LoadAccountsFromFile();

            viewAccountsListBox.DataSource = existingAccounts.Select(a => $"{a.AccountName} - {a.Balance} SEK - {a.GetAccountStatus()}").ToList();
        }

        //Find the selected account and delete it from the CSV file
        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (viewAccountsListBox.SelectedIndex != -1)
            {
                var accountName = existingAccounts[viewAccountsListBox.SelectedIndex].AccountName;
                var selectedAccount = existingAccounts.FirstOrDefault(a => a.AccountName == accountName);

                if (selectedAccount != null)
                {
                    if (selectedAccount.Balance > 0)
                    {
                        MessageBox.Show($"You have {selectedAccount.Balance} SEK on this account. Please go to the ATM and withdraw all funds before deleting.");
                        return;
                    }

                    var confirmResult = MessageBox.Show($"Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            existingAccounts.RemoveAt(viewAccountsListBox.SelectedIndex);

                            var fileManager = new AccountFileManager();

                            fileManager.SaveAccountsToFile(existingAccounts);
                            LoadAccounts();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting account: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an account to delete.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closingFromBackButton = true;
            this.Close();
        }

        private void ViewAccountForm_FormClosing(object sender, FormClosingEventArgs e)
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
