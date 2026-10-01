using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Trần Thị Thúy Vi";
            Console.WriteLine($"Tên: {p.name}");
        }
    }

    class Person
    {
        public string name;
    }
}