using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static double salary = 1000;

        static void Main(string[] args)
        {
            Raise(0.10); // Tăng 10%
            Console.WriteLine($"Lương sau tăng: {salary}");
        }

        static void Raise(double factor)
        {
            salary *= (1 + factor);
        }
    }
}