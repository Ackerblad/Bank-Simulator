using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank;

namespace Bank
{
    public partial class OfficeForm : Form
    {
        private bool closingFromBackButton = false;

        public OfficeForm()
        {
            InitializeComponent();
        }

        private void openAccountButton_Click(object sender, EventArgs e)
        {
            using (AccountCreationForm accountCreationForm = new AccountCreationForm())
            {
                this.Hide();
                accountCreationForm.ShowDialog();
                this.Show();
            }
        }

        private void unblockAccountButton_Click(object sender, EventArgs e)
        {
            var fileManager = new AccountFileManager();
            var accounts = fileManager.LoadAccountsFromFile();

            if (accounts.Any(account => account.IsBlocked))
            {
                using (unblockAccountForm unblockAccountForm = new unblockAccountForm())
                {
                    this.Hide();
                    unblockAccountForm.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("You do not have any blocked accounts.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closingFromBackButton = true;
            this.Close();
        }

        private void OfficeForm_FormClosing(object sender, FormClosingEventArgs e)
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
