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
        private ArrayList SavingsAccounts, CurrentAccounts, OverDraftAccounts;

        public BankBranch(string bn, string bm)
        {
            BranchName = bn;
            BranchManager = bm;
            SavingsAccounts = new ArrayList();
            CurrentAccounts = new ArrayList();
            OverDraftAccounts = new ArrayList();
        }        

        public void PrintAll()
        {
            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                Console.WriteLine(b.Show());
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                Console.WriteLine(b.Show());
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                Console.WriteLine(b.Show());
            }
        }

        public void Deposit(double amt, string acctNum)
        {
            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Deposit(amt);
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Deposit(amt);
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Deposit(amt);
            }
        }

        public void Withdraw(double amt, string acctNum)
        {
            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Withdraw(amt);
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Withdraw(amt);
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                if (b.AccountNumber.Equals(acctNum))
                    b.Withdraw(amt);
            }
        }

        public void TransferTo(double amt, string fromAcctNum, string toAcctNum)
        {
            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                if (b.AccountNumber.Equals(fromAcctNum))
                    b.Withdraw(amt);
                if (b.AccountNumber.Equals(toAcctNum))
                    b.Deposit(amt);
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                if (b.AccountNumber.Equals(fromAcctNum))
                    b.Withdraw(amt);
                if (b.AccountNumber.Equals(toAcctNum))
                    b.Deposit(amt);
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                if (b.AccountNumber.Equals(fromAcctNum))
                    b.Withdraw(amt);
                if (b.AccountNumber.Equals(toAcctNum))
                    b.Deposit(amt);
            }

        }

        public void CreditInterest()
        {
            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                b.CreditInterest();
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                b.CreditInterest();
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                b.CreditInterest();
            }
        }

        public void AddAccount(SavingsAccount a)
        {
            SavingsAccounts.Add(a);
        }

        public void AddAccount(CurrentAccount a)
        {
            CurrentAccounts.Add(a);
        }

        public void AddAccount(OverDraftAccount a)
        {
            OverDraftAccounts.Add(a);
        }

        public void PrintCustomers()
        {
            Console.WriteLine("Customers");
            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                Console.WriteLine(b.GetCustomer.GetName);
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                Console.WriteLine(b.GetCustomer.GetName);
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                Console.WriteLine(b.GetCustomer.GetName);
            }
        }        

        public double TotalDeposits()
        {
            double totalDeposits = 0;

            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                totalDeposits += b.Deposits;
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                totalDeposits += b.Deposits;
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                totalDeposits += b.Deposits;
            }            

            return totalDeposits;
        }

        public double TotalInterestPaid()
        {
            double totalInterestPaid = 0;

            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                totalInterestPaid += b.InterestPaid;
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                totalInterestPaid += b.InterestPaid;
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                totalInterestPaid += b.InterestPaid;
            }
            
            return totalInterestPaid;
        }

        public double TotalInterestEarned()
        {
            double totalInterestEarned = 0;

            foreach (Object obj in SavingsAccounts)
            {
                SavingsAccount b = (SavingsAccount)obj;
                totalInterestEarned += b.InterestEarned;
            }

            foreach (Object obj in CurrentAccounts)
            {
                CurrentAccount b = (CurrentAccount)obj;
                totalInterestEarned += b.InterestEarned;
            }

            foreach (Object obj in OverDraftAccounts)
            {
                OverDraftAccount b = (OverDraftAccount)obj;
                totalInterestEarned += b.InterestEarned;
            }

            return totalInterestEarned;
        }
    }
}
