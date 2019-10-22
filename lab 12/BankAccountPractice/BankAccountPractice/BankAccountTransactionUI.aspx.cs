using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankAccountPractice
{
    public partial class BankAccountTransactionUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createButton_Click(object sender, EventArgs e)
        {
            BankAccount account = new BankAccount();
            account.AccountNumber = accountNumberTextBox.Text;
            account.CustomerName = customerNameTextBox.Text;

            ViewState["Account"] = account;

            messageLabel.Text = "Account created successfully";
            createButton.Enabled = false;
        } 

        protected void depositButton_Click(object sender, EventArgs e)
        {
            BankAccount account = (BankAccount) ViewState["Account"];
            double amount = Convert.ToDouble(amountTextBox.Text);
            string message = account.Deposit(amount);
            messageLabel.Text = message;
        }

        protected void withdrawButton_Click(object sender, EventArgs e)
        {
            BankAccount account = (BankAccount)ViewState["Account"];
            double amount = Convert.ToDouble(amountTextBox.Text);
            string message = account.Withdraw(amount);
            messageLabel.Text = message;
        }

        protected void reportButton_Click(object sender, EventArgs e)
        {
            BankAccount account = (BankAccount)ViewState["Account"];
            string report = account.ShowReport();
            messageLabel.Text = report;
        }
    }
}