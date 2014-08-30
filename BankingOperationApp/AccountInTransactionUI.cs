using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingOperationApp
{
    public partial class AccountInTransactionUI : Form
    {
        BankingSystem bankingSystem;
        public const int MAX_BALANCE = 10000000;

        public AccountInTransactionUI(BankingSystem bankingSystem)
        {
            InitializeComponent();
            this.bankingSystem = bankingSystem;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            BankAccount account = GetAccountFromAccountNumber(accNoTextBox.Text);
            if (account != null)
            {
                balanceTextBox.Text = account.Balance.ToString();
                nameTextBox.Text = account.Customer.Name;
                nidTextBox.Text = account.Customer.NationalId;
            }

            if (account == null)
            {
                return;
            }

            string msg = "";
            double amount = Convert.ToDouble(amountTextBox.Text);
            if (depositRadioButton.Checked)
            {
                if ((account.Balance + amount) > MAX_BALANCE)
                {
                    msg = "max balance will exceed";
                }
                else
                {
                    account.Deposite(amount);   
                }
            }
            else if (withdrawRadioButton.Checked)
            {
                msg = account.Withdraw(amount);
            }

            if (msg != "")
                MessageBox.Show(msg);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            BankAccount account = GetAccountFromAccountNumber(accNoTextBox.Text);
            if (account == null)
            {
                return;
            }

            balanceTextBox.Text = account.Balance.ToString();
            nameTextBox.Text = account.Customer.Name;
            nidTextBox.Text = account.Customer.NationalId;
        }

        private BankAccount GetAccountFromAccountNumber(string accNo)
        {
            foreach (Customer customer in bankingSystem.Customers)
            {
                foreach (BankAccount account in customer.BankAccounts)
                {
                    if (account.AccountNumber == accNoTextBox.Text)
                    {
                        return account;
                    }
                }
            }
            return null;
        }
    }
}
