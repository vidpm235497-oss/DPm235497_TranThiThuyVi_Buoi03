using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Công ty A");
            Customer c2 = new Customer("Công ty A");
            Console.WriteLine($"Khách hàng 1: {c1.Name}, Khách hàng 2: {c2.Name}");
        }
    }

    class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
    }
}