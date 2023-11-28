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
    public partial class AccountCreationForm : Form
    {
        private bool closingFromBackButton = false;

        public AccountCreationForm()
        {
            InitializeComponent();
        }

        //Collecting the user inputs to create an account that is then saved to the CSV file
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox == null || accountNameTextBox == null || pinCodeTextbox == null)
            {
                MessageBox.Show("One or more fields are missing.");
                return;
            }

            string userName = userNameTextBox.Text;
            string accountName = accountNameTextBox.Text;
            string pinCodeText = pinCodeTextbox.Text;
            int pin;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(accountName) || !int.TryParse(pinCodeText, out pin) || pinCodeText.Length != 4)
            {
                MessageBox.Show("Please fill in all the fields correctly.");
            }
            else
            {
                Account newAccount = new Account(userName, accountName, 0, pin);

                AccountFileManager fileManager = new AccountFileManager();
                List<Account> accounts = fileManager.LoadAccountsFromFile();
                accounts.Add(newAccount);
                fileManager.SaveAccountsToFile(accounts);

                MessageBox.Show("Account successfully created!");
                userNameTextBox.Text = "";
                accountNameTextBox.Text = "";
                pinCodeTextbox.Text = "";
                return;
            }
        }

        private void viewAccountsButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("accounts.csv") || new FileInfo("accounts.csv").Length == 0)
            {
                MessageBox.Show("You do not have any accounts, go and create one!");
                return;
            }
            else
            {
                using (ViewAccountForm viewAccountForm = new ViewAccountForm())
                {
                    this.Hide();
                    viewAccountForm.ShowDialog();
                    this.Show();
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closingFromBackButton = true;
            this.Close();
        }

        private void AccountCreationForm_FormClosing(object sender, FormClosingEventArgs e)
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
