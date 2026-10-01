using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { PhoneNumber = "0901234567" };
            Console.WriteLine($"SĐT: {p.Getsph()}");
        }
    }

    class Person
    {
        public string PhoneNumber { get; set; }

        public string Getsph()
        {
            return PhoneNumber;
        }
    }
}