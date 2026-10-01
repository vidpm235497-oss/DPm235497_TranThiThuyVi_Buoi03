using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.OfficeTelephone.Number = "123456";
            Console.WriteLine($"Số điện thoại: {p.OfficeTelephone.Number}");
        }
    }

    class TelephoneNumber { public string Number { get; set; } }

    class Person
    {
        public TelephoneNumber OfficeTelephone { get; } = new TelephoneNumber();
    }
}