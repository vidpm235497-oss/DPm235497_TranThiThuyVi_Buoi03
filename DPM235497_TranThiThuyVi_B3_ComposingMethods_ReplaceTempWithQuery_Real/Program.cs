using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator calc = new SalaryCalculator(160, 20);
            Console.WriteLine($"Lương thực nhận: {calc.GetNetSalary()}");
        }
    }

    class SalaryCalculator
    {
        private int hours;
        private double rate;

        public SalaryCalculator(int hours, double rate)
        {
            this.hours = hours;
            this.rate = rate;
        }

        public double GrossSalary() => hours * rate;
        public double Tax() => GrossSalary() * 0.1;
        public double GetNetSalary() => GrossSalary() - Tax();
    }
}