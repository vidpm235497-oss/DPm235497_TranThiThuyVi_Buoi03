using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBillable billable = new Employee { Rate = 100 };
            Console.WriteLine($"Phí dịch vụ: {Charge(billable, 5)}");
        }

        static double Charge(IBillable item, int days) => item.Rate * days;
    }

    interface IBillable
    {
        double Rate { get; set; }
    }

    class Employee : IBillable
    {
        public double Rate { get; set; }
        public bool HasSpecialSkill { get; set; }
    }
}