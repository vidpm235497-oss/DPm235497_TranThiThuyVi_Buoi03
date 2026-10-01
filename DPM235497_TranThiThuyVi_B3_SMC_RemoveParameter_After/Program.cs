using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.PrintInvoice();
        }
    }

    class Customer
    {
        public void PrintInvoice()
        {
            Console.WriteLine("In hóa đơn cho khách hàng...");
        }
    }
}