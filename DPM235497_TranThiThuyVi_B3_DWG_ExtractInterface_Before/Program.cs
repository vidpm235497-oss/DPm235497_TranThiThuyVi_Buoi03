using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee { Rate = 100, HasSpecialSkill = true };
            Console.WriteLine($"Phí dịch vụ: {Charge(e, 5)}");
        }

        static double Charge(Employee emp, int days) => emp.Rate * days;
    }

    class Employee
    {
        public double Rate { get; set; }
        public bool HasSpecialSkill { get; set; }
    }
}