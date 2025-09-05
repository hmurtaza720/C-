using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: " + (num1 + num2));
            Console.WriteLine("Subtraction: " + (num1 - num2));
            Console.WriteLine("Multiplication: " + (num1 * num2));
            Console.WriteLine("Division: " + (num1 / num2));
            Console.WriteLine("Modulus: " + (num1 % num2));

            Console.WriteLine("Are both numbers equal " + (num1 == num2));
            Console.WriteLine("Is Num1 Greater than Num2 " + (num1 > num2));

            bool bothpositive = (num1 > 0) && (num2 > 0);
            Console.WriteLine("Are both numbers positive " + bothpositive);

            string input = null;
            string result = input ?? "Default";
            Console.WriteLine("Result is: " + result);

            string comparison = (num1 > num2) ? "Num1 is greater" : "Num2 is greater";
            Console.WriteLine(comparison);

        }

    }

}