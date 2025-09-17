//using System;

//class Car
//{
//    public string model;
//    public string color;
//    public int speed;

//    public Car(string m, string c, int s)
//    {
//         model = m;
//         color = c;
//         speed = s;

//    }

//    public void Drive()
//    {
//        Console.WriteLine( color + " " + model + " is driving at " + speed + " .");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter car 1 model :");
//        string m1 = Console.ReadLine();
//        Console.WriteLine("Enter car 1 Color :");
//        string c1 = Console.ReadLine();
//        Console.WriteLine("Enter car 1 speed:");
//        int s1 = Convert.ToInt32(Console.ReadLine());
//        Car car1 = new Car(m1, c1, s1);

//        Console.WriteLine("Enter car 2 model :");
//        string m2 = Console.ReadLine();
//        Console.WriteLine("Enter car 2 Color :");
//        string c2 = Console.ReadLine();
//        Console.WriteLine("Enter car 2 speed:");
//        int s2 = Convert.ToInt32(Console.ReadLine());
//        Car car2 = new Car(m2, c2, s2);

//        Console.WriteLine("\n--- Car Details ---");
//        car1.Drive();
//        car2.Drive();



//    }
//}   




// USING PROPERTIES

using System;
using System.Runtime.InteropServices.Marshalling;

class Car
{
   
    private string model;
    private string color;
    private int speed;

   
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public int Speed
    {
        get { return speed; }
        set
        {
            if (value >= 0)  
                speed = value;
            else
                speed = 0;
        }
    }

   
    public Car(string m, string c, int s)
    {
        Model = m;   
        Color = c;
        Speed = s;
    }

    public void Drive()
    {
        Console.WriteLine(Color + " " + Model + " is driving at " + Speed + " km/h.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter car 1 model :");
        string m1 = Console.ReadLine();
        Console.WriteLine("Enter car 1 Color :");
        string c1 = Console.ReadLine();
        Console.WriteLine("Enter car 1 speed:");
        int s1 = Convert.ToInt32(Console.ReadLine());
        Car car1 = new Car(m1, c1, s1);

        Console.WriteLine("Enter car 2 model :");
        string m2 = Console.ReadLine();
        Console.WriteLine("Enter car 2 Color :");
        string c2 = Console.ReadLine();
        Console.WriteLine("Enter car 2 speed:");
        int s2 = Convert.ToInt32(Console.ReadLine());
        Car car2 = new Car(m2, c2, s2);

        Console.WriteLine("\n--- Car Details ---");
        car1.Drive();
        car2.Drive();



    }
}



