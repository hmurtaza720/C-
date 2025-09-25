using System;

namespace SalesManagement
{
    interface IReportable
    {
        void GenerateReport();
    }

    public abstract class Employee

    {
        private string name;
        private int id;
        protected double baseSalary;

        private static int counter = 1000;
        public Employee()
        {
            id = counter++;
        }   
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public abstract double CalculateSalary();

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    public class TeamLead : Employee, IReportable
    {
        public TeamLead()
        {
            baseSalary = 50000;
        }
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.15);
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }

        public void GenerateReport()
        {
            Console.WriteLine($"{Name} is generating Team sales report.");
        }
    }

    public class LeadCloser : Employee
    {
        public LeadCloser()
        {
            baseSalary = 35000;
        }
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.3);
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is Closing the Sale.");
        }
    }

    public class LeadInitiator : Employee
    {
        public LeadInitiator()
        {
            baseSalary = 30000;
        }
        public override double CalculateSalary()
        {
            return BaseSalary + (BaseSalary * 0.3);
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is Creating Sales Lead.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("\n=== Sales Management System ===");
                Console.WriteLine("1. Create TeamLead");
                Console.WriteLine("2. Create Lead Closer");
                Console.WriteLine("3. Create Lead Initiator");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                Employee emp = null;

                switch (choice)
                {
                    case 1:
                        emp = new TeamLead();
                        break;
                    case 2:
                        emp = new LeadCloser();
                        break;
                    case 3:
                        emp = new LeadInitiator();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                Console.Write("Enter Employee Name: ");
                emp.Name = Console.ReadLine();



                emp.Work();
                Console.Write($"Employee ID: {emp.Id}");
                Console.WriteLine($"\nSalary of {emp.Name} is {emp.BaseSalary}: \nAfter Commission on a Sale {emp.CalculateSalary()}");

                if (emp is TeamLead manager)
                {
                    manager.GenerateReport();
                }
            }
        }
    }
}
