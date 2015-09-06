using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_2
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string acctNum, Customer c, double b) : base(acctNum, c, b, 0.25)
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
            return "Current Account: " + " " + base.Show() + " " + base.InterestRate + "%\n";
        }
    }

}
