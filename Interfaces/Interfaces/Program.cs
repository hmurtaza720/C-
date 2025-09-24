using System;

namespace interfaces
{

    interface IDriveable
    {
        void Drive();
    }

    interface IFlyable
    {
        void Fly();
    }

    interface Isailable
    {
        void Sail();
    }


    class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }
    class Plane : IDriveable, IFlyable
    {
        public void Drive()
        {
            Console.WriteLine("The plane is taxiing on the runway.");
        }
        public void Fly()
        {
            Console.WriteLine("The plane is flying.");
        }
    }

    class Sailboat : Isailable
    {
        public void Sail()
        {
            Console.WriteLine("The sailboat is sailing.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("=== CHOOSE OPTIONS === ");
                Console.WriteLine("Enter '1' to create a Car ");
                Console.WriteLine("Enter '2' to create a Airplane ");
                Console.WriteLine("Enter '3' to create a Boat ");
                Console.WriteLine("Enter '4' To Exit  ");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Car myCar = new Car();
                        myCar.Drive();
                        break;
                    case 2:
                        Plane myPlane = new Plane();
                        myPlane.Drive();
                        myPlane.Fly();
                        break;
                    case 3:
                        Sailboat mySailboat = new Sailboat();
                        mySailboat.Sail();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
        }
    }
}



