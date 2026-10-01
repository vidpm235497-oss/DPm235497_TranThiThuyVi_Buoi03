using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { PhoneNumber = "123456" };
            Console.WriteLine($"Số điện thoại: {p.PhoneNumber}");
        }
    }

    class Person
    {
        public string PhoneNumber { get; set; }
    }
}