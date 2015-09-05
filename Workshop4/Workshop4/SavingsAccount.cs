using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string acctNum, Customer c, double b) : base(acctNum, c, b, 0.01)
        {
        }

        public new double Balance
        {
            get
            {
                return base.Balance;
            }

            set
            {
                if (value > 0)
                    base.Balance = value;
            }
        }

        public new string Show()
        {
            return "Savings Account: " + " " + base.Show() + " " + base.InterestRate + "%\n";
        }
    }
}
