using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperationApp
{
    public class BankingSystem
    {
        public List<Customer> Customers { get; private set; }

        public BankingSystem()
        {
            Customers = new List<Customer>();
        }

        public string AddCustomerBankAccount(Customer newCustomer, BankAccount accountInfo)
        {
            string msg = "";
            foreach (Customer customer in Customers)
            {
                if (customer.NationalId == newCustomer.NationalId)
                {
                    return customer.CreateNewBankAcount(accountInfo);
                }
            }

            foreach (Customer customer in Customers)
            {
                foreach (BankAccount account in customer.BankAccounts)
                {
                    if (account.AccountNumber == accountInfo.AccountNumber)
                    {
                        return "bank account with same AcountNumber exists";
                    }
                }

            }

            newCustomer.CreateNewBankAcount(accountInfo);
            Customers.Add(newCustomer);
            return "new customer and account created";
        }

        public string AddCustomerLoanAccount(Customer newCustomer, LoanAccount accountInfo)
        {
            string msg = "";
            foreach (Customer customer in Customers)
            {
                if (customer.NationalId == newCustomer.NationalId)
                {
                    return customer.CreateNewLoanAcount(accountInfo);
                }
            }

            foreach (Customer customer in Customers)
            {
                foreach (LoanAccount account in customer.LoanAccounts)
                {
                    if (account.AccountNumber == accountInfo.AccountNumber)
                    {
                        return "loan account with same AcountNumber exists";
                    }
                }

            }

            newCustomer.CreateNewLoanAcount(accountInfo);
            Customers.Add(newCustomer);
            return "new customer and account created";
        }
    }
}
