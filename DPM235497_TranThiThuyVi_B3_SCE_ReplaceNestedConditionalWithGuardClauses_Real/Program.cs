using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessOrder(10, 50.0);
        }

        static void ProcessOrder(int quantity, double price)
        {
            if (quantity <= 0) return;
            if (price <= 0) return;

            Console.WriteLine($"Xử lý đơn hàng: {quantity * price} VNĐ");
        }
    }
}