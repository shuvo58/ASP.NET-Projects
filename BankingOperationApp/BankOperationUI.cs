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
    public partial class BankOperationUI : Form
    {
        BankingSystem bankingSystem;

        public BankOperationUI()
        {
            InitializeComponent();
            bankingSystem = new BankingSystem();
        }

        private void createBankAccButton_Click(object sender, EventArgs e)
        {
            CreateAccountUI creatBankAccount = new CreateAccountUI(bankingSystem);
            creatBankAccount.ShowDialog();
        }

        private void createLoanAccButton_Click(object sender, EventArgs e)
        {
            CreateLoanUI createLoan = new CreateLoanUI(bankingSystem);
            createLoan.ShowDialog();
        }

        private void transcInAccButton_Click(object sender, EventArgs e)
        {
            AccountInTransactionUI transaction = new AccountInTransactionUI(bankingSystem);
            transaction.ShowDialog();
        }

        private void refundInstallmentButton_Click(object sender, EventArgs e)
        {
            LoanInstallmentPaymentUI loan = new LoanInstallmentPaymentUI(bankingSystem);
            loan.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportUI report = new ReportUI(bankingSystem);
            report.ShowDialog();
        }
    }
}
