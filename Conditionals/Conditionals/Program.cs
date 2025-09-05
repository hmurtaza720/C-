//using System;
//using System.Diagnostics.Eventing.Reader;

//namespace Conditionals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your marks( 0 - 100 )");
//            int marks = Convert.ToInt32(Console.ReadLine());

//            if (marks >= 90)
//            {
//                Console.WriteLine("Grade A+");
//            }

//            else if (marks >= 80)
//            {
//                Console.WriteLine("Grade A");
//            }

//            else if (marks >= 70)
//            {
//                Console.WriteLine("Grade B");
//            }

//            else if (marks >= 60)
//            {
//                Console.WriteLine("Grade c");
//            }

//            else
//            {
//                Console.WriteLine("Fail");
//            }
//            Console.ReadLine();

//        }
//    }
//}



// CASE STATEMENT



//using System;

//namespace Switch
//{
//    class program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Menu: ");
//            Console.WriteLine("1. pizza");
//            Console.WriteLine("2. Burger");
//            Console.WriteLine("3. Pasta");
//            Console.WriteLine("Choose 1,2,3");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("You ordered a pizza");
//                    break;

//                case 2:
//                    Console.WriteLine("You ordered a Burger");
//                    break;
//                case 3:
//                    Console.WriteLine("You ordered a Pasta");
//                    break;
//                default:
//                    Console.WriteLine("Invalid choice");
//                    break;
//            }



//        }
//    }
//}


//Practice Problems

// 1. Even or Odd Number

//using System;
//namespace EvenOdd
//{
//    class program
//    {

//        static void Main()
//        {
//            Console.WriteLine("Enter a number: ");
//            int number = Convert.ToInt32(Console.ReadLine());

//            int remainder = number % 2;
//            if (remainder == 0)
//            {
//                Console.WriteLine("The number is even");
//            }
//            else
//            {
//                Console.WriteLine("The number is odd");
//            }
//        }
//    }
//}

// 2. Voting Eligibility

//using System;
//namespace Voting_Eligibility
//{
//    class program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter your age: ");
//            int age = Convert.ToInt32(Console.ReadLine());
//            if (age >= 18)
//            {
//                Console.WriteLine("You are eligible to vote");
//            }
//            else
//            {
//                Console.WriteLine("You are not eligible to vote");
//            }
//        }
//    }
//}


//Calculator(switch)

using System;
namespace Calculator
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation: ");
            char op = Convert.ToChar(Console.ReadLine());

            {
                switch (op)
                {
                    case '+':
                        Console.WriteLine("Addition: " + (num1 + num2));
                        break;


                    case '-':
                        Console.WriteLine("Subtraction: " + (num1 - num2));
                        break;


                    case '*':
                        Console.WriteLine("Multiplication: " + (num1 * num2));
                        break;


                    case '/':
                        Console.WriteLine("Division: " + (num1 / num2));
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

        }
        }
    }

