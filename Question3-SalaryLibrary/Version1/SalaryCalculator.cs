using System;

namespace SalaryLibrary
{
    public class SalaryCalculator
    {
        public decimal CalculateBasicSalary(decimal basicSalary)
        {
            if (basicSalary < 0)
            {
                throw new ArgumentException(
                    "Basic salary cannot be negative."
                );
            }

            return basicSalary;
        }
    }
}
