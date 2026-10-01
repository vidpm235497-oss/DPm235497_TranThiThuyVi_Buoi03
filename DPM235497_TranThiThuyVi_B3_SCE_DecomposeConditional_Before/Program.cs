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
            int quantity = 10;
            double charge;

            if (date >= SUMMER_START && date <= SUMMER_END)
            {
                charge = quantity * 15.0;
            }
            else
            {
                charge = quantity * 20.0;
            }

            Console.WriteLine($"Chi phí: {charge}");
        }
    }
}