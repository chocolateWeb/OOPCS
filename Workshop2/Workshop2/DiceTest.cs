using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    public class Dice
    {
        private int faceUp;

        public Dice()
        {
            Throw();
        }

        public int GetFaceUp
        {
            get
            {
                return faceUp;
            }
        }

        public void Throw()
        {
            Random r = new Random();
            faceUp = r.Next(1, 7);
        }

        public string StrFaceUp()
        {
            if (faceUp == 1)
                return "ONE";
            else if (faceUp == 2)
                return "TWO";
            else if (faceUp == 3)
                return "THREE";
            else if (faceUp == 4)
                return "FOUR";
            else if (faceUp == 5)
                return "FIVE";
            else if (faceUp == 6)
                return "SIX";
            else
                return "NULL";
        }

        public double Probability(int n)
        {
            double count = 0;

            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                {
                    if (i + j == n)
                        count++;
                }

            return count / 36;
        }
    }

    public class DiceTest
    {
        public static void Main(string[] args)
        {
            int throwCount = 0, count = 0;

            Dice d1 = new Dice();
            Dice d2 = new Dice();

            Console.Write("Enter number to obtain (<=12): ");
            int num = Convert.ToInt32(Console.ReadLine());


            do
            {
                d1.Throw();
                d2.Throw();
                
                if(d1.GetFaceUp + d2.GetFaceUp == num)
                    throwCount++;

                count++;               
            } while (count < 100000);

            Console.WriteLine("Occurence of {0} is: \t{1:0.000}", num, (double)throwCount/count);
            Console.WriteLine("Probability of {0} is: \t{1:0.000}", num, d1.Probability(num));
        }
    }
}
