using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp = 2 * (10 + 5);
            Console.WriteLine($"Chu vi: {temp}");

            temp = 10 * 5;
            Console.WriteLine($"Diện tích: {temp}");
        }
    }
}