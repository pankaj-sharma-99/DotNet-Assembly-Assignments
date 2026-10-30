using System;
using UniversityLibrary;

namespace StudentApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                101,
                "Aman",
                "Computer Science",
                20
            );

            Console.WriteLine("Student Application 1");
            student.DisplayDetails();

            Console.ReadKey();
        }
    }
}
