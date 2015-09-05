using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_2
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
}
