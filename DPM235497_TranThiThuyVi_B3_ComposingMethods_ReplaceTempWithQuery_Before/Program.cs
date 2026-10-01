using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static int quantity = 5;
        static double itemPrice = 100;

        static void Main(string[] args)
        {
            Console.WriteLine($"Price: {CalculatePrice()}");
        }

        static double CalculatePrice()
        {
            double basePrice = quantity * itemPrice;
            double discountFactor;

            if (basePrice > 1000) discountFactor = 0.95;
            else discountFactor = 0.98;

            return basePrice * discountFactor;
        }
    }
}