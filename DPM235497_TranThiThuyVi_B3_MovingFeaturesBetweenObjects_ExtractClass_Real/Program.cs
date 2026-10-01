using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Name = "Trần Thị Thúy Vi" };
            student.Address.Street = "Lý Thái Tổ";
            student.Address.City = "Long Xuyên";
            Console.WriteLine($"{student.Name} sống tại {student.Address.GetFullAddress()}");
        }
    }

    class AddressInfo
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string GetFullAddress() => $"{Street}, {City}";
    }

    class Student
    {
        public string Name { get; set; }
        public AddressInfo Address { get; } = new AddressInfo();
    }
}