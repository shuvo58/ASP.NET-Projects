using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperationApp
{
    public class Customer
    {
        public string Name { get; private set; }
        public string NationalId { get; private set; }
        public string Email { get; private set; }
        public List<BankAccount> BankAccounts { get; private set; }
        public List<LoanAccount> LoanAccounts { get; private set; }

        public const int MAX_NO_OF_BANK_ACC = 5;
        public const int MAX_NO_OF_LOAN_ACC = 2;
        public const int MAX_REMAINING_REFUND = 10000000;

        public Customer(string name, string nid, string email)
        {
            Name = name;
            NationalId = nid;
            Email = email;

            BankAccounts = new List<BankAccount>();
            LoanAccounts = new List<LoanAccount>();
        }

        public string CreateNewBankAcount(BankAccount newAccount)
        {
            if (BankAccounts.Count >= MAX_NO_OF_BANK_ACC)
            {
                return "max no of bank acount";
            }

            if (GetTotalRemainingRefund() > MAX_REMAINING_REFUND)
            {
                return "max loan limit exceed";
            }

            if (HasSameBankAccountNumber(newAccount))
            {
                return "bank account with same AcountNumber exists";
            }

            BankAccount anotherAccount = HasBankAccount(newAccount);
            if (anotherAccount == null)
            {
                BankAccounts.Add(newAccount);
                return "new account created with new information";
            }

            newAccount.Customer.Name = anotherAccount.Customer.Name;
            newAccount.Customer.Email = anotherAccount.Customer.Email;
            BankAccounts.Add(newAccount);
            return "new account created with old information";
        }

        public string CreateNewLoanAcount(LoanAccount newAccount)
        {
            if (LoanAccounts.Count >= MAX_NO_OF_LOAN_ACC)
            {
                return "max no of loan acount";
            }
            if (HasSameLoanAccountNumber(newAccount))
            {
                return "loan account with same AcountNumber exists";
            }

            LoanAccount anotherAccount = HasLoanAccount(newAccount);
            if (anotherAccount == null)
            {
                LoanAccounts.Add(newAccount);
                return "new account created with new information";
            }

            newAccount.Customer.Name = anotherAccount.Customer.Name;
            newAccount.Customer.Email = anotherAccount.Customer.Email;
            LoanAccounts.Add(newAccount);
            return "new account created with old information";
        }

        public double GetTotalBalance()
        {
            double totalBalance = 0;
            foreach (BankAccount account in BankAccounts)
            {
                totalBalance += account.Balance;
            }
            return totalBalance;
        }

        public double GetTotalRemainingRefund()
        {
            double totalRefund = 0;
            foreach (LoanAccount account in LoanAccounts)
            {
                totalRefund += account.RemainingAmountToRefund;
            }
            return totalRefund;
        }

        private bool HasSameBankAccountNumber(BankAccount account)
        {
            foreach (BankAccount bankAccount in BankAccounts)
            {
                if (bankAccount.AccountNumber == account.AccountNumber)
                {
                    return true;
                }
            }
            return false;
        }

        private BankAccount HasBankAccount(BankAccount account)
        {
            foreach (BankAccount bankAccount in BankAccounts)
            {
                if (bankAccount.Customer.NationalId == account.Customer.NationalId)
                {
                    return bankAccount;
                }
            }
            return null;
        }

        private bool HasSameLoanAccountNumber(LoanAccount account)
        {
            foreach (LoanAccount loanAccount in LoanAccounts)
            {
                if (loanAccount.AccountNumber == account.AccountNumber)
                {
                    return true;
                }
            }
            return false;
        }

        private LoanAccount HasLoanAccount(LoanAccount account)
        {
            foreach (LoanAccount loanAccount in LoanAccounts)
            {
                if (loanAccount.Customer.NationalId == account.Customer.NationalId)
                {
                    return loanAccount;
                }
            }
            return null;
        }
    }
}
