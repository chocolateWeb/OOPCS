using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3_1
{
    public class Account
    {
        private string accountNumber, accountHolderName;
        private double balance;

        public Account(string acctNum, string acctHolderName, double b)
        {
            accountNumber = acctNum;
            accountHolderName = acctHolderName;
            balance = b;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void TransferTo(double amount, Account another)
        {
            balance = balance - amount;
            another.Deposit(amount);
        }

        public string Show()
        {
            return "Your Bank Account Details" + "\n" + "-----------------------------------------------" + "\n" + accountNumber + "\t" + accountHolderName + "\t" + balance + "\n";
        }
    }


    public class BankTest
    {
        public static void Main(string[] args)
        {
            Account a = new Account("001-001-001", "Tan Ah Kow", 2000);
            Account b = new Account("001-001-002", "Kim Keng Lee", 5000);

            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());

            a.Deposit(100);
            Console.WriteLine(a.Show());

            a.Withdraw(200);
            Console.WriteLine(a.Show());

            a.TransferTo(300, b);
            Console.WriteLine(a.Show());
            Console.WriteLine(b.Show());
        }
    }
}
