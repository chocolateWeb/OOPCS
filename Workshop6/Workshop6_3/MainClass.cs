using System;

namespace Workshop6_3
{
    class Customer : IComparable
    {
        private string name;
        private string address;
        private double balance;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public Customer(string n, string a, double b)
        {
            name = n;
            address = a;
            balance = b;
        }

        public int CompareTo(Object o)
        {
            Customer c = (Customer)o;

            if (this.balance < c.balance)
                return -1;

            else if (this.balance == c.balance)
                return 0;

            else if (this.balance > c.balance)
                return 1;

            else
                return 99;            
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("Tan Ah Kow", "4 Short Street", 2000);
            Customer d = new Customer("Tan Ah Lian", "81 Berry Road", 1500);
            int n = 65;
            int m = 231;
            Console.WriteLine(n < m);
            Console.WriteLine(c.CompareTo(d));
        }
    }
}