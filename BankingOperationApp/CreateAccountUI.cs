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
    public partial class CreateAccountUI : Form
    {
        BankingSystem bankingSystem;

        public CreateAccountUI(BankingSystem bankingSystem)
        {
            InitializeComponent();
            this.bankingSystem = bankingSystem;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer(nameTextBox.Text, nidTextBox.Text, emailTextBox.Text);
            BankAccount accountInfo = new BankAccount(newCustomer, accNoTextBox.Text, DateTime.Now);

            string msg = bankingSystem.AddCustomerBankAccount(newCustomer, accountInfo);
            MessageBox.Show(msg);
        }
    }
}
