using System;
using System.IO;

namespace File_IO
{
    class StudentRecordManager
    {
        static string filePath = "student_records.txt";

        public static void Addstudent()
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            string age = Console.ReadLine();

            string record = $"{id},{name},{age}";

            File.AppendAllText(filePath, record + Environment.NewLine);

            Console.WriteLine("Student record added successfully.");


        }

        public static void ViewStudents()
        {
            if (File.Exists(filePath))
            {
                string[] records = File.ReadAllLines(filePath);
                Console.WriteLine("Student Records:");
                foreach (var record in records)
                {
                    var fields = record.Split(',');
                    Console.WriteLine($"ID: {fields[0]}, Name: {fields[1]}, Age: {fields[2]}");
                }
            }
            else
            {
                Console.WriteLine("No student records found.");
            }


        }

        public static void SearchStudent()
        {
            Console.Write("Enter Student ID to search: ");
            string id = Console.ReadLine();
            if (File.Exists(filePath))
            {
                string[] records = File.ReadAllLines(filePath);
                bool found = false;
                foreach (var record in records)
                {
                    var fields = record.Split(',');
                    if (fields[0] == id)
                    {
                        Console.WriteLine($"Student Found - ID: {fields[0]}, Name: {fields[1]}, Age: {fields[2]}");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("No student records found.");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nStudent Record Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Addstudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        SearchStudent();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        }
}