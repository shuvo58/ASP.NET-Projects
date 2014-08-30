using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperationApp
{
    public class LoanAccount
    {
        public Customer Customer { get; private set; }
        public string AccountNumber { get; private set; }
        public DateTime CreationDate { get; private set; }
        public double DisburseAmount { get; private set; }
        public double TotalAmountToRefund { get; private set; }
        public int TotalNoOfInstallment { get; private set; }
        public double AmountPerInstallment { get; private set; }
        public double RemainingAmountToRefund { get; private set; }
        public int RemainingNoOfInstallment { get; private set; }

        public LoanAccount(Customer aCustomer, string accNo, DateTime date, double disburseAmount, double amountToRefund, int noOfInstallment)
        {
            this.Customer = aCustomer;
            AccountNumber = accNo;
            CreationDate = date;
            DisburseAmount = disburseAmount;
            TotalAmountToRefund = amountToRefund;
            TotalNoOfInstallment = noOfInstallment;

            AmountPerInstallment = TotalAmountToRefund / TotalNoOfInstallment;

            RemainingAmountToRefund = TotalAmountToRefund;
            RemainingNoOfInstallment = TotalNoOfInstallment;
        }

        public string SetInstallment(int noOfInstallment)
        {
            if (RemainingNoOfInstallment < noOfInstallment)
            {
                return "max no of installment exceed";
            }

            RemainingNoOfInstallment -= noOfInstallment;
            RemainingAmountToRefund -= (AmountPerInstallment*noOfInstallment);
            return "success";
        }
    }
}
