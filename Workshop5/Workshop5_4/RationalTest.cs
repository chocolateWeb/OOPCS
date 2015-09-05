using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5_4
{
    public class Rational
    {
        private int numerator, denominator;

        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        public static Rational operator +(Rational num1, Rational num2)
        {
            int commonDenom = num1.denominator * num2.GetDenominator();
            int numer1 = num1.numerator * num2.GetDenominator();
            int numer2 = num2.GetNumerator() * num1.denominator;
            int sum = numer1 + numer2;
            Rational result = new Rational(sum, commonDenom);
            return result;
        }

        public static Rational operator -(Rational num1, Rational num2)
        {
            int commonDenom = num1.denominator * num2.GetDenominator();
            int numer1 = num1.numerator * num2.GetDenominator();
            int numer2 = num2.GetNumerator() * num1.denominator;
            int difference = numer1 - numer2;
            Rational result = new Rational(difference, commonDenom);
            return result;
        }

        public static Rational operator *(Rational num1, Rational num2)
        {
            int numer = num1.numerator * num2.GetNumerator();
            int denom = num1.denominator * num2.GetDenominator();
            Rational result = new Rational(numer, denom);
            return result;
        }

        public static Rational operator /(Rational num1, Rational num2)
        {
            int numer = num2.GetDenominator();
            int denom = num2.GetNumerator();

            Rational r = new Rational(numer, denom);
            Rational result = num1 * r;
            return result;
        }

        public string StrVal()
        {
            string result;

            if (numerator == 0)
                result = "0";
            else
            {
                if (denominator == 1)
                    result = numerator.ToString();
                else
                    result = numerator + "/" + denominator;
            }
            return result;
        }

        public Rational(int numer, int denom)
        {
            if (denom == 0)    // set denominator to 1 if
                denom = 1;      // argument is zero
            if (denom < 0)
            {   // make numerator "store" the sign
                numer = numer * -1;
                denom = denom * -1;
            }
            numerator = numer;
            denominator = denom;
            Reduce();          // calling a private method
        }

        private void Reduce()
        {
            if (numerator != 0)
            {
                int common = HCF(Math.Abs(numerator), denominator);
                numerator = numerator / common;
                denominator = denominator / common;
            }
        }

        private int HCF(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }
            return num1;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public class RationalTest
        {
            public static void Main(string[] args)
            {
                Rational a = new Rational(3, 4);
                Rational b = new Rational(4, 5);

                Rational c = a + b;
                Console.WriteLine(c.StrVal());
                Console.WriteLine(c.ToString());

                c = b - a;
                Console.WriteLine(c.StrVal());
                Console.WriteLine(c.ToString());
            }
        }
    }
}
