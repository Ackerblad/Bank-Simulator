using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Xml.Linq;

namespace Bank
{
    public class AccountFileManager
    {
        private const string FilePath = "accounts.csv";

        //Create the CSV file if it dosen't exist and save the new account to the file 
        public void SaveAccountsToFile(List<Account> accounts)
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    File.Create(FilePath).Close();
                }

                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    foreach (var account in accounts)
                    {
                        var line = $"{account.UserName}, {account.AccountName}, {account.Balance}, {account.PinCode}, {account.GetAccountStatus()}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show($"An error occurred while writing to the file: {e.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred: {e.Message}");
            }
        }

        //Read the accounts in the existing CSV file
        public List<Account> LoadAccountsFromFile()
        {
            var accounts = new List<Account>();

            try
            {
                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(",");

                            if (parts.Length == 5)
                            {
                                var account = Account.CreateAccountWithHashedPin(
                                    parts[0].Trim(),
                                    parts[1].Trim(),
                                    decimal.Parse(parts[2].Trim()),
                                    parts[3].Trim()
                                );
                                account.SetAccountStatus(parts[4].Trim());
                                accounts.Add(account);
                            }
                        }
                    }
                } 
            }
            catch (IOException e)
            {
                MessageBox.Show($"An error occurred while reading the file: {e.Message}");
            }
            catch (FormatException e)
            {
                MessageBox.Show($"A format error occurred: {e.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred: {e.Message}");
            }
            return accounts;
        }
    }
}
