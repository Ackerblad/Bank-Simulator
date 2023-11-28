namespace Bank
{
    public partial class FormBank : Form
    {
        public FormBank()
        {
            InitializeComponent();
        }

        private void officeButton_Click(object sender, EventArgs e)
        {
            OfficeForm officeForm = new OfficeForm();
            officeForm.FormClosed += (s, args) => this.Show();
            officeForm.Show();
            this.Hide();
        }

        private void atmButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("accounts.csv") || new FileInfo("accounts.csv").Length == 0)
            {
                MessageBox.Show("You do not have a bank account yet, visit the office to open one!");
                return;
            }
            else
            {
                AtmForm atmForm = new AtmForm();
                atmForm.FormClosed += (s, args) => this.Show();
                atmForm.Show();
                this.Hide();
            }    
        }

        private void FormBank_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
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