using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_2
{
    public class BankAccount : Account
    {
        private double interestRate, interestPaid = 0, interestEarned = 0;

        public BankAccount(string acctNum, Customer c, double b, double i) : base(acctNum, c, b)
        {
            interestRate = i;
        }

        public double InterestPaid
        {
            get
            {
                return interestPaid;
            }
        }

        public double InterestEarned
        {
            get
            {
                return interestEarned;
            }
        }
        
        public virtual double InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                interestRate = value;
            }
        }

        public override void Withdraw(double amt)
        {
            if (amt < base.Balance)
            {
                base.Balance -= amt;
            }
        }

        public void TransferTo(double amount, BankAccount another)
        {
            Withdraw(amount);
            another.Deposit(amount);
        }

        public double CalculateInterest()
        {
            return (interestRate / 100) * base.Balance;
        }

        public void CreditInterest()
        {
            if(base.Balance > 0)
                interestEarned += CalculateInterest();
            else
                interestPaid += CalculateInterest();

            base.Balance += CalculateInterest();
        }
    }
}
