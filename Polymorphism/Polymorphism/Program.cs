using System;
using System.Security.Cryptography.X509Certificates;

namespace Polymorphism
{

    public abstract class Shape
    {
        public abstract double Area();
    }
    // Abstraction , Inheritance and Polymorphism
    public class Circle : Shape
    {
        private double radius;

        public override double Area()
        {
            Console.WriteLine("Calculating area of circle");
            Console.WriteLine("Enter radius:");
            radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * radius * radius;
            return Area;


        }
    }

    public class Rectangle : Shape
    {
        private double Lenght;
        private double Height;

        public override double Area()
        {
            Console.WriteLine("Calculating area of Rectangle");
            Console.WriteLine("Enter Lenght of Rectangle:");
            Lenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height of Rectangle:");
            Height = Convert.ToDouble(Console.ReadLine());
            double Area = Lenght * Height;
            return Area;


        }
    }

    public class Triangle : Shape
    {
        private double Base;
        private double Height;

        public override double Area()
        {
            Console.WriteLine("Calculating area of Triangle");
            Console.WriteLine("Enter Base of Triangle:");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height of Triangle:");
            Height = Convert.ToDouble(Console.ReadLine());
            double Area = ((Base * Height)/2);
            return Area;


        }
    }

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n==== Shape Area Calculator ===");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Circle c = new Circle();
                        Console.WriteLine("Area of Circle: " + c.Area());
                        break;

                    case 2:
                        Rectangle r = new Rectangle();
                        Console.WriteLine("Area of Rectangle: " + r.Area());
                        break;

                    case 3:
                        Triangle t = new Triangle();
                        Console.WriteLine("Area of Triangle: " + t.Area());
                        break;

                    case 4:
                        Console.WriteLine("Exiting the program.");
                        return;


                    default:
                        Console.WriteLine("Invalid Option.");
                        break;

                }
            }
        }
    }
}