using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Mức hỗ trợ: {DisabilityAmount(12, 2, true)}");
        }

        static double DisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;

            return 1000;
        }
    }
}