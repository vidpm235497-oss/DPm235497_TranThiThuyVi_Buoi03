using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = Employee.Create(Employee.ENGINEER);
            Console.WriteLine($"Loại nhân viên code: {e.GetTypeCode()}");
        }
    }

    abstract class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;

        public abstract int GetTypeCode();

        public static Employee Create(int type)
        {
            switch (type)
            {
                case ENGINEER: return new Engineer();
                case SALESMAN: return new Salesman();
                default: throw new ArgumentException("Incorrect type code");
            }
        }
    }

    class Engineer : Employee
    {
        public override int GetTypeCode() => ENGINEER;
    }

    class Salesman : Employee
    {
        public override int GetTypeCode() => SALESMAN;
    }
}