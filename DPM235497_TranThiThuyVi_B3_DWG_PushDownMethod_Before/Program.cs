using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code trước khi Push Down Method");
        }
    }

    abstract class Employee
    {
        public void GetQuota() => Console.WriteLine("Chỉ tiêu doanh số");
    }

    class Salesman : Employee { }
    class Engineer : Employee { }
}