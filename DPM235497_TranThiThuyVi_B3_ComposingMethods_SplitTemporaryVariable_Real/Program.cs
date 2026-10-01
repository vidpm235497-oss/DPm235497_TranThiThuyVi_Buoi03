using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initialForce = 100.0;
            double mass = 10.0;
            double acc1 = initialForce / mass;
            Console.WriteLine($"Gia tốc ban đầu: {acc1}");

            double secondaryForce = 200.0;
            double acc2 = (initialForce + secondaryForce) / mass;
            Console.WriteLine($"Gia tốc sau: {acc2}");
        }
    }
}