using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static int numberOfLateDeliveries = 6;

        static void Main(string[] args)
        {
            Console.WriteLine($"Rating: {GetRating()}");
        }

        static int GetRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}