using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product { Price = 250 };
            if (p.Price > 200)
            {
                Console.WriteLine("Sản phẩm thuộc nhóm cao cấp.");
            }
        }
    }

    class Product { public double Price { get; set; } }
}