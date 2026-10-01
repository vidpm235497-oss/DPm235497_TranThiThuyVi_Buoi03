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
            if (IsNotEligibleForDisability(seniority, monthsDisabled, isPartTime))
            {
                return 0;
            }
            return 1000;
        }

        static bool IsNotEligibleForDisability(int seniority, int monthsDisabled, bool isPartTime)
        {
            return (seniority < 2) || (monthsDisabled > 12) || isPartTime;
        }
    }
}