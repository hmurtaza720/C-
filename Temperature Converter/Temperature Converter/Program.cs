using System;
namespace Temperature_Converter
{
   class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double cel = Convert.ToDouble(Console.ReadLine());
            double f = (cel * 9 / 5) + 32;
            Console.WriteLine("C : " + cel + " F : " + f);

            Console.WriteLine("Enter temperature in Fahrenheit:");
            double fa = Convert.ToDouble(Console.ReadLine());
            double c = (fa - 32) * 5 / 9;
            Console.WriteLine("F : " + fa + " C : " + c);

            Console.ReadLine();

        }
    }
}