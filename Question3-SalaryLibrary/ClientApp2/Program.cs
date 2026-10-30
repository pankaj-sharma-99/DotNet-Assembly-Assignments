using System;
using SalaryLibrary;

namespace SalaryClientApp2
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

            Console.Write("Enter HRA percentage: ");
            decimal hraRate = decimal.Parse(Console.ReadLine());

            Console.Write("Enter DA percentage: ");
            decimal daRate = decimal.Parse(Console.ReadLine());

            decimal allowances = calculator.CalculateAllowances(
                basicSalary, hraRate, daRate);

            decimal totalSalary = calculator.CalculateTotalSalary(
                basicSalary, hraRate, daRate);

            Console.WriteLine("\n--- Employee Salary Details ---");
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Total Allowances: " + allowances);
            Console.WriteLine("Total Salary: " + totalSalary);

            Console.ReadKey();
        }
    }
}
