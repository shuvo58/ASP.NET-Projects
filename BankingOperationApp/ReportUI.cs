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
    public partial class ReportUI : Form
    {
        BankingSystem bankingSystem;
        private Customer customer;

        public ReportUI(BankingSystem bankingSystem)
        {
            InitializeComponent();
            this.bankingSystem = bankingSystem;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            customer = GetCustomerFromNationalId(nationalIdTextBox.Text);
            if (customer == null)
            {
                return;
            }

            double totalBalance = 0;
            foreach (BankAccount bAccount in customer.BankAccounts)
            {
                totalBalance += bAccount.Balance;
            }
            totalBalanceTextBox.Text = totalBalance.ToString();

            double remainingLoanAmount = 0;
            foreach (LoanAccount lAccount in customer.LoanAccounts)
            {
                remainingLoanAmount += lAccount.RemainingAmountToRefund;
            }
            remainingLoanAmountTextBox.Text = remainingLoanAmount.ToString();

            bankAccComboBox.DataSource = null;
            bankAccComboBox.DataSource = customer.BankAccounts;
            bankAccComboBox.DisplayMember = "AccountNumber";

            loanAccComboBox.DataSource = null;
            loanAccComboBox.DataSource = customer.LoanAccounts;
            loanAccComboBox.DisplayMember = "AccountNumber";
        }

        private void bankAccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer == null)
            {
                return;
            }

            if (customer.BankAccounts.Count > 0)
            {
                balanceTextBox.Text = customer.BankAccounts[bankAccComboBox.SelectedIndex].Balance.ToString();
            }
        }

        private void loanAccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer == null)
            {
                return;
            }

            if (customer.LoanAccounts.Count > 0)
            {
                remainingLoanAmountTextBox.Text = customer.LoanAccounts[loanAccComboBox.SelectedIndex].RemainingAmountToRefund.ToString();
            }            
        }

        private Customer GetCustomerFromNationalId(string nid)
        {
            foreach (Customer customer in bankingSystem.Customers)
            {
                if (customer.NationalId == nid)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}