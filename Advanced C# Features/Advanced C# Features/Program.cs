//using System;

//namespace StaticClass
//{
//    public static class Calculate
//    {
//        public static double Area()
//        {
//            Console.WriteLine("Calculating area of circle");
//            Console.Write("Enter Radius: ");
//            double radius = Convert.ToDouble(Console.ReadLine());
//            double area = Math.PI * radius * radius;
//            Console.WriteLine($"Area of circle with radius {radius} is {area}");
//            return area;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Calculate.Area();
//        }
//    }
//}




    using System;
    namespace Partialclass
    {
        public partial class Student

        {
            public string? Fname { get; set; }
            public string? Lname { get; set; }
            public int age { get; set; }

        }

        public partial class Student
        {
            public void printdetails()
            {
                Console.WriteLine($"Student details {Fname} {Lname} ,\n Age : {age}");
            }
        }

         internal class Program
        {
        static void Main(string[] args)
        {

                Student Student = new Student { Fname = "Ali", Lname = "Hassan", age = 22 };
            
                Student.printdetails();
            }
        }
    }
