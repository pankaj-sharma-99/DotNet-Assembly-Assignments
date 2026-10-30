using System;

namespace UniversityLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }

        public Student(int id, string name, string course, int age)
        {
            Id = id;
            Name = name;
            Course = course;
            Age = age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Age: " + Age);
        }
    }
}
