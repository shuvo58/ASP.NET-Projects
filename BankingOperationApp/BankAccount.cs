using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperationApp
{
    public class BankAccount
    {
        public Customer Customer { get; private set; }
        public string AccountNumber { get; private set; }
        public DateTime CreationDate { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(Customer aCustomer, string accNo, DateTime date)
        {
            this.Customer = aCustomer;
            AccountNumber = accNo;
            CreationDate = date;
            Balance = 0;
        }

        public string Deposite(double amount)
        {
            Balance += amount;
            return "success";
        }

        public string Withdraw(double amount)
        {
            if (Balance < amount)
            {
                return "insufcient balance";
            }

            Balance -= amount;
            return "success";
        }
    }
}
