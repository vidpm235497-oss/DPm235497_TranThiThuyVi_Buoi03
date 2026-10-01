using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { BasePrice = 1200 };
            Console.WriteLine($"Lớn hơn 1000: {HasDiscount(order)}");
        }

        static bool HasDiscount(Order order)
        {
            double basePrice = order.BasePrice;
            return basePrice > 1000;
        }
    }

    class Order { public double BasePrice { get; set; } }
}