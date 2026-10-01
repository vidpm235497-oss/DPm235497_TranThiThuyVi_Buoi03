using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.PrintInvoice("Thắc mắc hóa đơn"); // Tham số unused không dùng tới
        }
    }

    class Customer
    {
        public void PrintInvoice(string unusedUnneededParam)
        {
            Console.WriteLine("In hóa đơn cho khách hàng...");
        }
    }
}