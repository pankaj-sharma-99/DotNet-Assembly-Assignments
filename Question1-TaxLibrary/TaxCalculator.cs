using System;

namespace TaxLibrary
{
    public class TaxCalculator
    {
        public decimal CalculateOldRegime(decimal income)
        {
            if (income < 0)
                throw new ArgumentException("Income cannot be negative.");

            decimal tax = 0;

            if (income > 250000)
                tax += Math.Min(income - 250000, 250000) * 0.05m;

            if (income > 500000)
                tax += Math.Min(income - 500000, 500000) * 0.20m;

            if (income > 1000000)
                tax += (income - 1000000) * 0.30m;

            return tax;
        }

        public decimal CalculateNewRegime(decimal income)
        {
            if (income < 0)
                throw new ArgumentException("Income cannot be negative.");

            decimal tax = 0;

            if (income > 300000)
                tax += Math.Min(income - 300000, 400000) * 0.05m;

            if (income > 700000)
                tax += Math.Min(income - 700000, 300000) * 0.10m;

            if (income > 1000000)
                tax += Math.Min(income - 1000000, 200000) * 0.15m;

            if (income > 1200000)
                tax += Math.Min(income - 1200000, 300000) * 0.20m;

            if (income > 1500000)
                tax += (income - 1500000) * 0.30m;

            return tax;
        }
    }
}
