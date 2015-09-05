using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_3
{
    public class Customer
    {
        private string name;
        private string address;
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

        public Customer(string n, string a)
        {
            name = n;
            address = a;
        }

        public string ToString(Object obj)
        {
            return obj.ToString();
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("Tan Ah Kow", "4 Short Street");
            int n = 65;
            Console.WriteLine(n);
            Console.WriteLine(c);
            //Console.WriteLine(n.ToString(n));
            Console.WriteLine(c.ToString(c));
        }
    }

}
