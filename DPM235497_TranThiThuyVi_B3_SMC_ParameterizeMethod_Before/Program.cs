using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static double salary = 1000;

        static void Main(string[] args)
        {
            TenPercentRaise();
            Console.WriteLine($"Lương sau tăng: {salary}");
        }

        static void TenPercentRaise()
        {
            salary *= 1.10;
        }

        static void FivePercentRaise()
        {
            salary *= 1.05;
        }
    }
}