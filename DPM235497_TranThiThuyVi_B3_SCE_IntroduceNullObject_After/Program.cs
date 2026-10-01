using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = null;
            string plan = (customer == null) ? "Khách chưa đăng nhập" : customer.GetName();
            Console.WriteLine($"Tên khách hàng: {plan}");
        }
    }

    class Customer
    {
        public string GetName() => "Khách hàng hợp lệ";
    }
}