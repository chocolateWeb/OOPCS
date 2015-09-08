using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6_1b
{
    abstract class Shape
    {
        private double side1, side2;

        public Shape(double a, double b)
        {
            side1 = a;
            side2 = b;
        }

        public double GetSide1
        {
            get
            {
                return side1;
            }
        }

        public double GetSide2
        {
            get
            {
                return side2;
            }
        }

        public abstract double Area();
        public abstract double Perimeter();
    }

    class Triangle : Shape
    {
        private double side3;

        public Triangle(double a, double b, double c) : base(a, b)
        {
            side3 = c;
        }

        public override double Area()
        {
            double s = (base.GetSide1 + base.GetSide2 + side3) / 2;
            double a = Math.Sqrt(s * (s - base.GetSide1) * (s - base.GetSide2) * (s - side3));
            return a;
        }

        public override double Perimeter()
        {
            return base.GetSide1 + base.GetSide2 + side3;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double a, double b) : base(a, b)
        {

        }

        public override double Area()
        {
            return base.GetSide1 * base.GetSide2;
        }

        public override double Perimeter()
        {
            return base.GetSide1 + base.GetSide2 + base.GetSide1 + base.GetSide2;
        }
    }

    class ShapeTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1 of Triangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2 of Triangle: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 3 of Triangle: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            Triangle t = new Triangle(side1, side2, side3);

            Console.WriteLine();
            Console.WriteLine("Area of Triangle: {0}", t.Area());
            Console.WriteLine("Perimeter of Triangle: {0}", t.Perimeter());
            Console.WriteLine();

            Console.Write("Enter side 1 of Rectangle: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side 2 of Rectangle: ");
            side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle r = new Rectangle(side1, side2);

            Console.WriteLine("Area of Rectangle: {0}", r.Area());
            Console.WriteLine("Perimeter of Rectangle: {0}", r.Perimeter());
        }
    }
}
