// Menu-Driven Calculator
//User enters a number (choice).
//Based on that choice → program calls a method (like addition, reverse string, etc.).
//Runs inside a loop until user chooses Exit (0).


using System;

namespace Menu_Driven_Calculator

{
    internal class Program

    {
        static void Adition()
        {
            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("Addition is: " + result);

        }

        static void Subtraction()
        {
            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 - num2;
            Console.WriteLine("Subtraction is: " + result);

        }

        static void Multiplication()
        {
            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2;
            Console.WriteLine("Multiplication is: " + result);

        }

        static void Division()
        {
            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                Double result = num1 / num2;
                Console.WriteLine("Divison is: " + result);
            }
        }

        static void Modulus()
        {
            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            double result = num1 % num2;
            Console.WriteLine("Modulus is: " + result);

        }

        static void Power()
        {
            Console.WriteLine("Enter Base number");
            double baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent number");
            double exponent = Convert.ToInt32(Console.ReadLine());
            double result = Math.Pow(baseNum, exponent);
            Console.WriteLine("Result is " + result);

        }


        static void ReverseString()
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            String reversedString = new string(charArray);

            Console.WriteLine("Reversed string: " + reversedString);
        }

        static void CheckEvenOdd()
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is Even number");
            }
            else
            {
                Console.WriteLine(num + " is Odd number");
            }

        }

        static void Main(string[] args)
        {

            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("========Menu========");
                Console.WriteLine("1.Addition ");
                Console.WriteLine("2.Subtraction ");
                Console.WriteLine("3.Multiplication ");
                Console.WriteLine("4.Division ");
                Console.WriteLine("5.Modulus ");
                Console.WriteLine("6.Power ");
                Console.WriteLine("7.Reverse a String ");
                Console.WriteLine("8.Even or Odd ");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your Choice ");

                choice = Convert.ToInt32(Console.ReadLine());




                switch (choice)
                {
                    case 1:
                        Adition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        Modulus();
                        break;
                    case 6:
                        Power();
                        break;
                    case 7:
                        ReverseString();
                        break;
                    case 8:
                        CheckEvenOdd();
                        break;
                    case 9:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}

