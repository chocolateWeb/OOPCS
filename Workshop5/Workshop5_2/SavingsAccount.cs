using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_2
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string acctNum, Customer c, double b) : base(acctNum, c, b, 0.01)
        {
        }

        public override double Balance
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

        public override string Show()
        {
            return "Savings Account: " + " " + base.Show() + " " + base.InterestRate + "%\n";
        }
    }
}
