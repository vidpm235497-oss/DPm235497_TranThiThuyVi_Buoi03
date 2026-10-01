using System;
using System.Collections.Generic;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = Customer.Get("Công ty A");
            Customer c2 = Customer.Get("Công ty A");
            Console.WriteLine($"Tham chiếu trùng nhau: {ReferenceEquals(c1, c2)}");
        }
    }

    class Customer
    {
        private static Dictionary<string, Customer> instances = new Dictionary<string, Customer>();

        public string Name {; private set; }

        private Customer(string name) { Name = name; }

        public static Customer Get(string name)
        {
            if (!instances.ContainsKey(name)) instances[name] = new Customer(name);
            return instances[name];
        }
    }
}