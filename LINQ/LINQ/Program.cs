using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
         static void Main()
        {
            var students = new List<(string Name, int Marks, string Department)>()
            {
                ("Ali", 85, "Cs"),
                ("Murtaza", 92, "Maths"),
                ("Rameez", 78, "Phy"),
                ("Ahsan", 88, "Cs"),
                ("Saboor", 95, "Maths")

            };

            var passedStudents = students.Where(s => s.Marks >= 50);

            var passedNames = passedStudents.Select(s => s.Name.ToUpper());

            var groupedByDepartment = passedStudents.GroupBy(s => s.Department);

            Console.WriteLine("Passed Students Names in UPPER CASE :");

            foreach (var name in passedNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n Passes Students Grouped by Department ");
            foreach (var group in groupedByDepartment)
            {
                Console.WriteLine($"\n Department : {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($" Name: {student.Name}, Marks: {student.Marks}");
                }
            }
        }

    }
}