using System;
using SalaryLibrary;

namespace SalaryClientApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator calculator = new SalaryCalculator();

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter basic salary: ");
            decimal basicSalary = decimal.Parse(Console.ReadLine());

            decimal salary = calculator.CalculateBasicSalary(basicSalary);

            Console.WriteLine("\n--- Employee Salary Details ---");
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Basic Salary: " + salary);

            Console.ReadKey();
        }
    }
}
