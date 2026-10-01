using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            bool canVote = age >= 18;
            Console.WriteLine($"Được phép bầu cử: {canVote}");
        }
    }
}