using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.AddPhone("0912345678");
        }
    }

    class Contact
    {
        public void AddPhone(string number)
        {
            Console.WriteLine($"Đã thêm sđt: {number}");
        }
    }
}