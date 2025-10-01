using System;

class NegativeMarksException : Exception
{
    public NegativeMarksException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter student marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0)
                throw new NegativeMarksException("Marks cannot be negative!");

            Console.WriteLine($"Marks entered: {marks}");
        }
        catch (NegativeMarksException ex)
        {
            Console.WriteLine(" Custom Error: " + ex.Message);
        }
    }
}
