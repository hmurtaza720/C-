//using System;

//namespace Loops
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("For Loop: 0 - 4 ");
//            for (int i = 0; i <= 4; i++)
//            {
//                Console.WriteLine("i : " + i);
//            }
//        }
//    }
//}



//using System;

//namespace loops
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("For While Loop :");
//            int j = 5;
//                        while (j > 0)
//            {
//                Console.WriteLine("j : " + j);
//                j--;

//            }
//        }
//    }
//}



//using System;
//namespace loops
//{
//    class program
//    {
//        static void Main()
//        {
//            Console.WriteLine("do while Loop :");
//            int k = 0;
//            do
//            {
//                Console.WriteLine("k : " + k);
//                k++;

//            }
//            while (k < 6);
//        }

//    }
//}


//using System;

//namespace Multiplication_Table
//{
//    class program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter a number :");
//            int num = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Multiplication Table of number :" + num);

//            for (int i = 1; i < 11; i++)
//            {

//                Console.WriteLine(num + " * " + i + " = " + (i * num));

//            }
//            Console.ReadLine();
//        }
//    }
//}


//using System;
//namespace Sum_Nnumbers
//{
//    class program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter a Number : ");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int sum = 0;
//            int i = 1;

//            while (i <= num)
//            {
//                sum = sum + i;

//                i++;
//            }
//            Console.WriteLine("Sum of Numbers 1 to " + num + " is : " + sum);
//            Console.ReadLine();
//        }
//    }
//}


using System;

namespace Reverse_String
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word ");
            string word = Console.ReadLine();
            String Reverse = "";


            for (int i = word.Length - 1; i >=0; i--)  
            {
                Reverse = Reverse + word[i];
            }

            Console.WriteLine("Reversed Word = " + Reverse);
            Console.ReadLine();
        }
    }
}