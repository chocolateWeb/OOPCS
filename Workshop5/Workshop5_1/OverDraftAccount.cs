using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_1
{
    public class OverDraftAccount : BankAccount
    {
        public OverDraftAccount(string acctNum, Customer c, double b) : base(acctNum, c, b, 0.25)
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
                base.Balance = value;
                if (base.Balance < 0)
                {
                    base.InterestRate = 6;

                }
            }
        }

        public override void Withdraw(double amt)
        {            
            base.Balance -= amt;
            if (base.Balance < 0)
                base.InterestRate = 6;
        }       

        public override string Show()
        {
            return "Overdraft Account: " + " " + base.Show() + " " + base.InterestRate + "%\n";
        }
    }
}
