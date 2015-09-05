using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3_2
{
    public class Customer
    {
        private string name, address, passportNumber;
        private DateTime dateOfBirth;

        public Customer(string n, string a, string pNum, DateTime dt)
        {
            name = n;
            address = a;
            passportNumber = pNum;
            dateOfBirth = dt;
        }

        public string GetName
        {
            get
            {
                return name;
            }
        }

        public int GetAge()
        {
            DateTime localDate = DateTime.Now;
            int year = localDate.Year - dateOfBirth.Year;
            return year;
        }

    }

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
            return "Your Bank Account Details" + "\n" + "-----------------------------------------------" + "\n" + accountNumber + "\t" + customer.GetName + "\t" + "Age:" + customer.GetAge() + "\t" + balance + "\n";
        }
    }
    public class CustomerTest
    {
        public static void Main(string[] args)
        {
            Customer y = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer z = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));

            Account a = new Account("001-001-001", y, 2000);
            Account b = new Account("001-001-002", z, 5000);

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
