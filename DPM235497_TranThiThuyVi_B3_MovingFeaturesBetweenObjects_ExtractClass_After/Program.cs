using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Thúy Vi" };
            p.Phone.AreaCode = "0296";
            p.Phone.Number = "123456";
            Console.WriteLine($"{p.Name} - {p.Phone.GetPhoneNumber()}");
        }
    }

    class TelephoneNumber
    {
        public string AreaCode { get; set; }
        public string Number { get; set; }
        public string GetPhoneNumber() => $"({AreaCode}) {Number}";
    }

    class Person
    {
        public string Name { get; set; }
        public TelephoneNumber Phone { get; } = new TelephoneNumber();
    }
}