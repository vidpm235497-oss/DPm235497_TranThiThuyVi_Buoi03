using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salesman s = new Salesman();
            s.GetQuota();
        }
    }

    abstract class Employee { }

    class Salesman : Employee
    {
        public void GetQuota() => Console.WriteLine("Chỉ tiêu doanh số");
    }

    class Engineer : Employee { }
}