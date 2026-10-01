using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double perimeter = 2 * (10 + 5);
            Console.WriteLine($"Chu vi: {perimeter}");

            double area = 10 * 5;
            Console.WriteLine($"Diện tích: {area}");
        }
    }
}