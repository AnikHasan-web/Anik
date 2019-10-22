using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAccountPractice
{
    [Serializable]
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        public string Deposit(double amount)
        {
            if (amount < 0)
            {
                return "Invalid amount";
            }
            Balance += amount;
            return "Deposit successful";
        }

        public string Withdraw(double amount)
        {
            if (amount < 0)
            {
                return "Invalid amount";
            }
            if (amount > Balance)
            {
                return "Insufficient balance";
            }
            Balance -= amount;
            return "Withdraw successful";
        }

        public string ShowReport()
        {
            return CustomerName + ", your account number is: " + AccountNumber + " and it's balance: " + Balance +
                   " taka";
        }
    }
}