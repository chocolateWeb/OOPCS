using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public class Account
    {
        private string accountNumber;
        private double balance;

        private Customer customer;

        public Account(string acctNum, Customer c, double b)
        {
            accountNumber = acctNum;
            customer = c;
            balance = b;
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void TransferTo(double amount, Account another)
        {
            Withdraw(amount);
            another.Deposit(amount);
        }

        public string Show()
        {
            return "Your Bank Account Details" + "\n" + "-------------------------------------------------------------" + "\n" + accountNumber + "\t" + customer.GetName + "\t" + "Age:" + customer.GetAge() + "\t" + balance + "\n";
        }
    }
}
