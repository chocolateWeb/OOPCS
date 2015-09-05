using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Workshop5_1
{   
    class BankTest
    {
        public static void Main(string[] args)
        {
            Customer tan = new Customer("Tan Ah Kow", "20, Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer kim = new Customer("Kim Lee Keng", "2, Rich View", "XXX9F", new DateTime(1993, 4, 25));
            Customer lee = new Customer("Lee Pek Cheong", "90, River Walk", "XXX10", new DateTime(1999, 9, 9));

            SavingsAccount sa = new SavingsAccount("001-001-001", tan, 2000);
            CurrentAccount ca = new CurrentAccount("001-001-002", kim, 5000);
            OverDraftAccount oa = new OverDraftAccount("001-001-003", lee, 100);

            Console.WriteLine(sa.Show());
            Console.WriteLine(ca.Show());
            Console.WriteLine(oa.Show());

            sa.Deposit(100);
            Console.WriteLine(sa.Show());

            ca.Withdraw(200);
            Console.WriteLine(ca.Show());

            oa.TransferTo(300, sa);
            Console.WriteLine(oa.Show());
            Console.WriteLine(sa.Show());

            sa.CreditInterest();
            ca.CreditInterest();
            oa.CreditInterest();

            Console.WriteLine(sa.Show());
            Console.WriteLine(ca.Show());
            Console.WriteLine(oa.Show());
        }
    }
}
