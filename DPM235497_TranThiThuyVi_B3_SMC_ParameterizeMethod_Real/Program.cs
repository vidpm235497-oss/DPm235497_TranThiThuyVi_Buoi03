using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee { BaseSalary = 5000000 };
            emp.ApplyBonus(0.15); // Thưởng 15%
            Console.WriteLine($"Tổng thu nhập: {emp.BaseSalary}");
        }
    }

    class Employee
    {
        public double BaseSalary { get; set; }

        public void ApplyBonus(double percentage)
        {
            BaseSalary += BaseSalary * percentage;
        }
    }
}