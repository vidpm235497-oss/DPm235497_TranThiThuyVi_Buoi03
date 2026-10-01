using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(Employee.ENGINEER);
            Console.WriteLine($"Loại nhân viên code: {e.TypeCode}");
        }
    }

    class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;

        public int TypeCode { get; set; }

        public Employee(int typeCode)
        {
            TypeCode = typeCode;
        }
    }
}