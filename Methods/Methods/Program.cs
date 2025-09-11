//using System;

//namespace Methods
//{
//    class Program
//    {
//        static void Greet(String name)
//        {
//            Console.WriteLine("Hello " + name);
//        }

//        static int numbers(int a, int b)
//        {
//            return a + b;
//        }

//        static void Main(string[] args)
//        {
//            Greet("Murtaza");

//            int result = numbers(5, 10);
//            Console.WriteLine("The sum is: " + result);
//        }
//}
//}
//    TASKS 
// Q1 Make a method IsEven(int num) → returns true if even, false if odd.

//using System;

//namespace Methods
//{
//    class Program
//    {
//        static bool IsEven(int num)
//        {
//            if (num % 2 == 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        static void Main(string[] args)
//        {
//            bool is_number_even = IsEven(5);
//            Console.WriteLine("The number is" +is_number_even);
//        }
//    }
//}


// Q2. Make two different methods 1st CalculateArea(double radius) → returns area of circle by radius.
//      2nd CalculateAreaByDiameter(double diameter) → returns area of circle by diameter.

//using System;

//namespace Methods
//{
//    class Program
//    {
//        static double CalculateArea(double radius)

//        {
//            double pi = 3.1416;
//            double area = pi * (radius * radius);
//            return area;
//        }

//        static double CalculateAreaByDiameter(double diameter)
//        {
//            double pi = 3.1416;
//            double radius = diameter / 2;
//            double area = pi * (radius * radius);
//            return area;

//        }

//        static void Main()
//        {
//            double Area_of_Circle_By_radius = CalculateArea(7);
//            Console.WriteLine("Area of Circle by Radius is :  " + Area_of_Circle_By_radius);

//            double Area_of_Circle_By_diameter = CalculateAreaByDiameter(14);
//            Console.WriteLine("Area of Circle by Diameter is : "+ Area_of_Circle_By_diameter);
//        }
//    }
//}



//  Method Overloading

// Same method name, but different parameters (type or number).


using System;
namespace Methods
{
    class Program
    {
        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double CalculateArea(int diameter)
        {
            int radius = diameter / 2;
            return Math.PI * radius * radius;
        }

        static void Main(string[] args)
        {
            double areabyradius = CalculateArea(7.0);
            Console.WriteLine("Area of Circle by Radius is : " + areabyradius);

            double areabydiameter = CalculateArea(14);
            Console.WriteLine("Area of Circle by Diameter is : " + areabydiameter);
        }
    }
}