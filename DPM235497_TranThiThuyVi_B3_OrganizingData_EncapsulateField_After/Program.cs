using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Trần Thị Thúy Vi";
            Console.WriteLine($"Tên: {p.Name}");
        }
    }

    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}