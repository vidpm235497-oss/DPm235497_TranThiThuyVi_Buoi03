using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProcessor processor = new OrderProcessor();
            processor.CalculateTotalAmount(150000, 2);
        }
    }

    class OrderProcessor
    {
        public double CalculateTotalAmount(double price, int quantity)
        {
            double total = price * quantity;
            Console.WriteLine($"Tổng thành tiền: {total} VNĐ");
            return total;
        }
    }
}