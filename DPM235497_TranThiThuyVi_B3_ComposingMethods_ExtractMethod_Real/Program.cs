using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = { 10.0, 20.5, 30.0 };
            ProcessInvoice("Đơn hàng #001", prices);
        }

        static void ProcessInvoice(string orderName, double[] prices)
        {
            double total = CalculateTotal(prices);
            PrintInvoice(orderName, total);
        }

        static double CalculateTotal(double[] prices)
        {
            double sum = 0;
            foreach (var p in prices) sum += p;
            return sum;
        }

        static void PrintInvoice(string orderName, double total)
        {
            Console.WriteLine($"Hóa đơn: {orderName}");
            Console.WriteLine($"Tổng tiền: {total} VNĐ");
        }
    }
}