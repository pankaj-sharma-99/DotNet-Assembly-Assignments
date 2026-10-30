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

        public decimal CalculateAllowances(
            decimal basicSalary,
            decimal hraRate,
            decimal daRate)
        {
            if (basicSalary < 0 || hraRate < 0 || daRate < 0)
            {
                throw new ArgumentException(
                    "Salary and allowance rates cannot be negative."
                );
            }

            decimal hra = basicSalary * hraRate / 100m;
            decimal da = basicSalary * daRate / 100m;

            return hra + da;
        }

        public decimal CalculateTotalSalary(
            decimal basicSalary,
            decimal hraRate,
            decimal daRate)
        {
            decimal allowances = CalculateAllowances(
                basicSalary,
                hraRate,
                daRate
            );

            return basicSalary + allowances;
        }
    }
}
