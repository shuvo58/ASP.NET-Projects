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
    public partial class LoanInstallmentPaymentUI : Form
    {
        BankingSystem bankingSystem;
        public LoanInstallmentPaymentUI(BankingSystem bankingSystem)
        {
            InitializeComponent();
            this.bankingSystem = bankingSystem;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            LoanAccount account = GetAccountFromAccountNumber(accNoTextBox.Text);
            if (account == null)
            {
                return;
            }

            totalAmountToPaidBackTextBox.Text = account.TotalAmountToRefund.ToString();
            totalNoOfInstallmentTextBox.Text = account.TotalNoOfInstallment.ToString();
            remainingAmountToPaidBackTextBox.Text = account.RemainingAmountToRefund.ToString();
            remainingNoOfInstallmentTextBox.Text = account.RemainingNoOfInstallment.ToString();
            nameTextBox.Text = account.Customer.Name;
            nidTextBox.Text = account.Customer.NationalId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            LoanAccount account = GetAccountFromAccountNumber(accNoTextBox.Text);
            if (account == null)
            {
                return;
            }

            int noOfInstallment = Convert.ToInt16(refundNoOfInstallmentTextBox.Text);
            string msg = account.SetInstallment(noOfInstallment);
            MessageBox.Show(msg);
        }

        private LoanAccount GetAccountFromAccountNumber(string accNo)
        {
            foreach (Customer customer in bankingSystem.Customers)
            {
                foreach (LoanAccount account in customer.LoanAccounts)
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
