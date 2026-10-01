using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Thúy Vi", OfficeAreaCode = "0296", OfficeNumber = "123456" };
            Console.WriteLine($"{p.Name} - {p.GetPhoneNumber()}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string OfficeAreaCode { get; set; }
        public string OfficeNumber { get; set; }

        public string GetPhoneNumber() => $"({OfficeAreaCode}) {OfficeNumber}";
    }
}