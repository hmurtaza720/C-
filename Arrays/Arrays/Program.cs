using System;

namespace Arrays
{
     class Program
    {
        static void Main(string[] args)
        {
            //int[] num = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Number in the array : " + num[0]);
            //Console.WriteLine("Number in the array : " + num[2]);


            //string word = "Apple";
            //Console.Write(word[0]);
            //Console.Write(word[4]);

            // Reverse a string using array

            //Console.WriteLine("Enter a String ");
            //string input = Console.ReadLine();

            //char[] characters = input.ToCharArray();

            //Array.Reverse(characters);

            //String reversedString = new string(characters);

            //Console.WriteLine("Reversed String is : " + reversedString);


            int[] numbers = { 5, 8, 2, 10, 3, 7 };
            int max = numbers[0];
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                else if (number < min)
                {
                    min = number;
                }

            }
            Console.WriteLine("Maximum Number is : " + max);
            Console.WriteLine("Minimum Number is : " + min);
        }
    }
}
