using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Workshop6_2
{
    interface IInvestment
    {
        int Age();
        string Description
        {
            get;
        }
        double EstimatedValue
        {
            get;
        }
        double Profit();

    }
    class Coin : IInvestment
    {
        private string description;
        private double cost, estimatedValue;
        private DateTime acquired;

        public Coin(string d, double c, double e,  int year, int month, int day)
        {
            description = d;
            cost = c;
            estimatedValue = e;
            acquired = new DateTime(year, month, day);
        }
        

        public int Age()
        {
            DateTime now = DateTime.Now;
            return now.Year - acquired.Year;
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public double EstimatedValue
        {
            get
            {
                return estimatedValue;
            }
        }

        public double Profit()
        {
            if (estimatedValue > cost)
                return estimatedValue - cost;
            else
                return cost - estimatedValue;
        }
    }

    class Gold : IInvestment
    {
        private string description;
        private double cost, estimatedValue;
        private DateTime acquired;

        public Gold(string d, double c, double e, int year, int month, int day)
        {
            description = d;
            cost = c;
            estimatedValue = e;
            acquired = new DateTime(year, month, day);
        }        

        public int Age()
        {
            DateTime now = DateTime.Now;
            return now.Year - acquired.Year;
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public double EstimatedValue
        {
            get
            {
                return estimatedValue;
            }
        }

        public double Profit()
        {
            if (estimatedValue > cost)
                return estimatedValue - cost;
            else
                return cost - estimatedValue;
        }
    }

    class Antique : IInvestment
    {
        private string description;
        private double cost, estimatedValue;
        private DateTime acquired;

        public Antique(string d, double c, double e, int year, int month, int day)
        {
            description = d;
            cost = c;
            estimatedValue = e;
            acquired = new DateTime(year, month, day);
        }

        public int Age()
        {
            DateTime now = DateTime.Now;
            return now.Year - acquired.Year;
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public double EstimatedValue
        {
            get
            {
                return estimatedValue;
            }
        }

        public double Profit()
        {           
          return estimatedValue - cost;
        }
    }

    class Investments
    {
        List<IInvestment> inv = new List<IInvestment>();

        public void Add(IInvestment i)
        {
            inv.Add(i);
        }

        public double TotalProfits()
        {
            double totalProfit = 0;

            foreach(Object obj in inv)
            {
                IInvestment i = (IInvestment) obj;
                totalProfit += i.Profit();
            }

            return totalProfit;
        }

        public double TotalValue()
        {
            double totalValue = 0;

            foreach (Object obj in inv)
            {
                IInvestment i = (IInvestment)obj;
                totalValue += i.EstimatedValue;
            }

            return totalValue;
        }

        public void Print()
        {
            int i = 1;
            foreach (Object obj in inv)
            {
                IInvestment inv = (IInvestment)obj;
                Console.Write("{0}", i + ". ");
                Console.WriteLine(inv.Description + "\t" +inv.Age() + " Years");
                i++;
            }
        }
    }

    class InvestmentTest
    {
        static void Main(string[] args)
        {
            Coin c = new Coin("Singapore Coin $1", 100.00, 150.00, 1965, 1, 1);
            Gold g = new Gold("Gold chain 100gm", 200.00, 100.00, 1980, 1, 1);
            Antique a = new Antique("China Porcelain Vase", 300.00, 100.00, 1900, 1, 1);

            Investments i = new Investments();
            i.Add(c);
            i.Add(g);
            i.Add(a);

            i.Print();

            Console.WriteLine("Total Value: {0:c}", i.TotalValue());
            Console.WriteLine("Total Profits: {0:c}", i.TotalProfits());
        }
    }
}
