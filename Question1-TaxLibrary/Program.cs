using System;

namespace TaxConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxLibrary.TaxCalculator calculator =
                new TaxLibrary.TaxCalculator();

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter annual income: ");
            decimal income = decimal.Parse(Console.ReadLine());

            decimal oldTax =
                calculator.CalculateOldRegime(income);

            decimal newTax =
                calculator.CalculateNewRegime(income);

            Console.WriteLine("\n--- Employee Tax Details ---");
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Annual Income: " + income);
            Console.WriteLine("Old Regime Tax: " + oldTax);
            Console.WriteLine("New Regime Tax: " + newTax);

            Console.ReadKey();
        }
    }
}
