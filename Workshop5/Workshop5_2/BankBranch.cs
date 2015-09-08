using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Workshop5_2
{
    public class BankBranch
    {
        private string BranchName, BranchManager;
        private ArrayList BankAccts;

        public BankBranch(string bn, string bm)
        {
            BranchName = bn;
            BranchManager = bm;
            BankAccts = new ArrayList();            
        }

        public void AddAccount(SavingsAccount a)
        {
            BankAccts.Add(a);
        }

        public void AddAccount(CurrentAccount a)
        {
            BankAccts.Add(a);
        }

        public void AddAccount(OverDraftAccount a)
        {
            BankAccts.Add(a);
        }

        public void PrintCustomers()
        {
            int counter = 1;
            Console.WriteLine("Customers:");
            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                Console.WriteLine(counter + ". " + b.GetCustomer.GetName);
                counter++;
            }

            Console.WriteLine();
        }

        public void PrintAll()
        {
            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                Console.WriteLine(b.Show());
            }
        }

        public void Deposit(double amt, string acctNum)
        {
            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Deposit(amt);
            }
        }

        public void Withdraw(double amt, string acctNum)
        {
            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Withdraw(amt);
            }
        }

        public void TransferTo(double amt, string fromAcctNum, string toAcctNum)
        {
            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                if (b.AccountNumber.Equals(fromAcctNum))
                    b.Withdraw(amt);
                if (b.AccountNumber.Equals(toAcctNum))
                    b.Deposit(amt);
            }
        }

        public void CreditInterest()
        {
            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                b.CreditInterest();
            }
        }

        public double TotalDeposits()
        {
            double totalDeposits = 0;

            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                totalDeposits += b.Deposits;
            }       

            return totalDeposits;
        }

        public double TotalInterestPaid()
        {
            double totalInterestPaid = 0;

            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                totalInterestPaid += b.InterestPaid;
            }
            
            return Math.Abs(totalInterestPaid);
        }

        public double TotalInterestEarned()
        {
            double totalInterestEarned = 0;

            foreach (Object obj in BankAccts)
            {
                BankAccount b = (BankAccount)obj;
                totalInterestEarned += b.InterestEarned;
            }

            return totalInterestEarned;
        }
    }
}
