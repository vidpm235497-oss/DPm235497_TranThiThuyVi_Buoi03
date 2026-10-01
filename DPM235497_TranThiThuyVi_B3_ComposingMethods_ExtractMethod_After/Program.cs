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
            PrintBanner();
            PrintDetails(name, amount);
        }

        static void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        static void PrintDetails(string name, double amount)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Amount: {amount}");
        }
    }
}