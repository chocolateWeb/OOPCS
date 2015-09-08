using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6_1c
{
    interface IShape
    {       
        double Area();
        double Perimeter();
    }

    class Triangle : IShape
    {
        private double side1, side2, side3;

        public Triangle(double a, double b, double c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
        }

        public double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            double a = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            return a;
        }

        public double Perimeter()
        {
            return side1 + side2 + side3;
        }
    }

    class Rectangle : IShape
    {
        private double side1, side2;

        public Rectangle(double a, double b)
        {
            side1 = a;
            side2 = b;
        }

        public double Area()
        {
            return side1 * side2;
        }

        public double Perimeter()
        {
            return side1 + side2 + side1 + side2;
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
