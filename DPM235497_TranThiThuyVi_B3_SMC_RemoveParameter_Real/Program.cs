using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"Kết quả tính: {calc.GetDefaultRate()}");
        }
    }

    class Calculator
    {
        public double GetDefaultRate()
        {
            return 0.08;
        }
    }
}