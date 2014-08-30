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
    public partial class CreateLoanUI : Form
    {
        BankingSystem bankingSystem;

        public CreateLoanUI(BankingSystem bankingSystem)
        {
            InitializeComponent();
            this.bankingSystem = bankingSystem;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer(nameTextBox.Text, nidTextBox.Text, emailTextBox.Text);

            double disburseAmount = Convert.ToDouble(disburseAmountTextBox.Text);
            double amountToRefund = Convert.ToDouble(refundAmountTextBox.Text);
            int noOfInstallment = Convert.ToInt16(noOfInstallmentsTextBox.Text);
            LoanAccount accountInfo = new LoanAccount(newCustomer, accNoTextBox.Text, DateTime.Now, disburseAmount, amountToRefund, noOfInstallment);

            string msg = bankingSystem.AddCustomerLoanAccount(newCustomer, accountInfo);
            MessageBox.Show(msg);
        }
    }
}
