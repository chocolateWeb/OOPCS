using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Workshop5_2
{   
    class BankTest
    {
        public static void Main(string[] args)
        {
            BankBranch b = new BankBranch("Ang Mo Kio", "Chan Peng Chuan");

            Customer tan = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer kim = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            Customer lee = new Customer("Lee Pek Cheong", "90, River Walk", "XXX10", new DateTime(1999, 9, 9));

            b.AddAccount(new SavingsAccount("001-001-001", tan, 2000));
            b.AddAccount(new CurrentAccount("001-001-002", kim, 5000));
            b.AddAccount(new OverDraftAccount("001-001-003", lee, 100));            

            b.PrintCustomers();                       

            Console.WriteLine("Total Deposits: {0}", b.TotalDeposits());
            Console.WriteLine("Total Interest Earned: {0}", b.TotalInterestEarned());
            Console.WriteLine("Total Interest Paid: {0}", b.TotalInterestPaid());

            b.PrintAll();

            b.Deposit(100, "001-001-001");
            b.PrintAll();

            Console.WriteLine("Total Deposits: {0}", b.TotalDeposits());
            Console.WriteLine("Total Interest Earned: {0}", b.TotalInterestEarned());
            Console.WriteLine("Total Interest Paid: {0}", b.TotalInterestPaid());

            b.Withdraw(1000, "001-001-002");
            b.PrintAll();

            Console.WriteLine("Total Deposits: {0}", b.TotalDeposits());
            Console.WriteLine("Total Interest Earned: {0}", b.TotalInterestEarned());
            Console.WriteLine("Total Interest Paid: {0}", b.TotalInterestPaid());

            b.TransferTo(1000, "001-001-003", "001-001-002");
            b.PrintAll();

            Console.WriteLine("Total Deposits: {0}", b.TotalDeposits());
            Console.WriteLine("Total Interest Earned: {0}", b.TotalInterestEarned());
            Console.WriteLine("Total Interest Paid: {0}", b.TotalInterestPaid());

            b.CreditInterest();
            b.PrintAll();

            Console.WriteLine("Total Deposits: {0}", b.TotalDeposits());
            Console.WriteLine("Total Interest Earned: {0}", b.TotalInterestEarned());
            Console.WriteLine("Total Interest Paid: {0}", b.TotalInterestPaid());
        }
    }
}
