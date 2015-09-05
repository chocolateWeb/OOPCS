using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public class BankAccount : Account
    {
        private double interestRate;

        public BankAccount(string acctNum, Customer c, double b, double i) : base(acctNum, c, b)
        {
            interestRate = i;
        }

        public double InterestRate
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

        public new void Withdraw(double amt)
        {
            if (amt < base.Balance)
            {
                base.Balance -= -amt;
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
            base.Balance += CalculateInterest();
        }
    }
}
