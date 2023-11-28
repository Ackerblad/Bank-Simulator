using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        public string UserName { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public string PinCode { get; private set; }
        public int FailedAttempts { get; private set; } 
        public bool IsBlocked { get; private set; } 

        public Account(string userName, string accountName, decimal balance,int pinCode)
        {
            UserName = userName;
            AccountName = accountName;
            Balance = balance;
            PinCode = HashPinCode(pinCode);
        }

        //This constructor is used to create an account object from the CSV file where the pincode already is hashed
        public static Account CreateAccountWithHashedPin(string userName, string accountName, decimal balance, string hashedPinCode)
        {
            var account = new Account(userName, accountName, balance, 0)
            {
                UserName = userName,
                AccountName = accountName,
                Balance = balance,
                PinCode = hashedPinCode
            };
            return account;
        }

        //Hashing the pincode provides security
        private static string HashPinCode(int pinCode)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pinCode.ToString()));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hash;
            }
        }

        //Compare the user pincode input in the ATM with the hashed pincode 
        public bool VerifyPinCode( int pinCode)
        {
            return HashPinCode(pinCode) == this.PinCode;
        }

        //Keep track of how many times the user has entered the wrong pincode in the ATM
        public void FailedPinAttempts()
        {
            FailedAttempts++;

            if (FailedAttempts >= 3)
            {
                IsBlocked = true;
            }
        }

        public void ResetFailedPinAttempts()
        {
            FailedAttempts = 0;
        }

        //Update and hash the new pincode when the user unblock an account
        public void UpdatePinCode(int newPinCode)
        {
            this.PinCode = HashPinCode(newPinCode);
        }

        public void UnblockAccount()
        {
            IsBlocked = false;
            ResetFailedPinAttempts();
        }

        public string GetAccountStatus()
        {
            return IsBlocked ? "Blocked" : "Active";
        }

        public void SetAccountStatus(string status)
        {
            IsBlocked = status == "Blocked";
        }
    }
}
