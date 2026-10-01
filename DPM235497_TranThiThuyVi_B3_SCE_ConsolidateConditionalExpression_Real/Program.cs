using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Được giảm giá: {CanGetDiscount(65, true)}");
        }

        static bool CanGetDiscount(int age, bool isStudent)
        {
            return age >= 60 || age < 12 || isStudent;
        }
    }
}