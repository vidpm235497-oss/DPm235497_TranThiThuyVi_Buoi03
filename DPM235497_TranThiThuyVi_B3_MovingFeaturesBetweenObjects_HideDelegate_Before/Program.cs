using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.Department = new Department { Manager = new Person { Name = "Sếp Vi" } };

            Person manager = john.Department.Manager;
            Console.WriteLine($"Quản lý là: {manager.Name}");
        }
    }

    class Department { public Person Manager { get; set; } }

    class Person
    {
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}