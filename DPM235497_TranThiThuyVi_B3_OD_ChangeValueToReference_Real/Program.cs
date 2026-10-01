using System;
using System.Collections.Generic;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = Product.Get("SP01");
            Product p2 = Product.Get("SP01");
            Console.WriteLine($"Cùng tham chiếu sản phẩm: {ReferenceEquals(p1, p2)}");
        }
    }

    class Product
    {
        private static Dictionary<string, Product> cache = new Dictionary<string, Product>();

        public string Code { get; private set; }

        private Product(string code) { Code = code; }

        public static Product Get(string code)
        {
            if (!cache.ContainsKey(code)) cache[code] = new Product(code);
            return cache[code];
        }
    }
}