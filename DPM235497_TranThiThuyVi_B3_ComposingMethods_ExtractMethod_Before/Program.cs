using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOwing("Trần Thị Thúy Vi", 150.5);
        }

        static void PrintOwing(string name, double amount)
        {
            // Print banner
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");

            // Print details
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}");
        }
    }
}