using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static bool isDead = false;
        static bool isSeparated = false;
        static bool isRetired = false;

        static void Main(string[] args)
        {
            Console.WriteLine($"Số tiền: {GetPayAmount()}");
        }

        static double GetPayAmount()
        {
            if (isDead) return DeadAmount();
            if (isSeparated) return SeparatedAmount();
            if (isRetired) return RetiredAmount();

            return NormalPayAmount();
        }

        static double DeadAmount() => 100;
        static double SeparatedAmount() => 200;
        static double RetiredAmount() => 300;
        static double NormalPayAmount() => 500;
    }
}