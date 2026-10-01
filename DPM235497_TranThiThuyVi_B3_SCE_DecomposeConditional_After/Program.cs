using System;

namespace RefactoringDemo
{
    internal class Program
    {
        private static readonly DateTime SUMMER_START = new DateTime(2026, 6, 1);
        private static readonly DateTime SUMMER_END = new DateTime(2026, 8, 31);

        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            double charge = IsSummer(date) ? SummerCharge(10) : WinterCharge(10);
            Console.WriteLine($"Chi phí: {charge}");
        }

        static bool IsSummer(DateTime date) => date >= SUMMER_START && date <= SUMMER_END;
        static double SummerCharge(int quantity) => quantity * 15.0;
        static double WinterCharge(int quantity) => quantity * 20.0;
    }
}