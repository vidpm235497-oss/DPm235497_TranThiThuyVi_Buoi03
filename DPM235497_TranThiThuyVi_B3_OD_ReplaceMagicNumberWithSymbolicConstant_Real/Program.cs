using System;

namespace RefactoringDemo
{
    internal class Program
    {
        private const double VAT_RATE = 0.10;

        static void Main(string[] args)
        {
            double amount = 500000;
            double total = CalculateTotalWithTax(amount);
            Console.WriteLine($"Tổng tiền gồm thuế VAT: {total}");
        }

        static double CalculateTotalWithTax(double amount)
        {
            return amount * (1 + VAT_RATE);
        }
    }
}