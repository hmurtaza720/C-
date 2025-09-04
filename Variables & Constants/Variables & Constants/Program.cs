using System;

namespace Variables_Constants
{
    class program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;

            int radius = 5;
            var diameter = radius *2;
            double area = pi * radius * radius;

            Console.WriteLine("Radius: "+ radius);
            Console.WriteLine("Diameter: "+ diameter);
            Console.WriteLine("Area: "+ area);
            Console.ReadLine();
        }
    }
}