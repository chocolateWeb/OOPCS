using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_2
{
    public class Account
    {
        private string accountNumber;
        private double balance, deposits = 0;

        private Customer customer;

        public Account(string acctNum, Customer c, double b)
        {
            accountNumber = acctNum;
            customer = c;
            balance = b;
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public double Deposits
        {
            get
            {
                return deposits;
            }
        }

        public Customer GetCustomer
        {
            get
            {
                return customer;
            }
        }

        public virtual double Balance
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

        public virtual void Withdraw(double amount)
        {
            balance -= amount;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            deposits += amount;
        }

        public virtual void TransferTo(double amount, Account another)
        {
            Withdraw(amount);
            another.Deposit(amount);
        }

        public virtual string Show()
        {
            return "Your Bank Account Details" + "\n" + "-------------------------------------------------------------" + "\n" + accountNumber + "\t" + customer.GetName + "\t" + "Age:" + customer.GetAge() + "\t" + balance + "\n";
        }
    }
}
