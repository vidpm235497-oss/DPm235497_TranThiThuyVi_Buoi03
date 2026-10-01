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
            return BasePrice() * DiscountFactor();
        }

        static double BasePrice() => quantity * itemPrice;

        static double DiscountFactor() => BasePrice() > 1000 ? 0.95 : 0.98;
    }
}