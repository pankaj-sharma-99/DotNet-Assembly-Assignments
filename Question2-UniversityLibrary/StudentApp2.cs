using System;
using UniversityLibrary;

namespace StudentApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                102,
                "Priya",
                "Information Technology",
                21
            );

            Console.WriteLine("Student Application 2");
            student.DisplayDetails();

            Console.ReadKey();
        }
    }
}
