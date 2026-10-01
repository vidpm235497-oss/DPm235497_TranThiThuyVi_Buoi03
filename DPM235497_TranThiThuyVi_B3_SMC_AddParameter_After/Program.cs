using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.AddPhone("0912345678", "Di động");
        }
    }

    class Contact
    {
        public void AddPhone(string number, string type)
        {
            Console.WriteLine($"Đã thêm sđt: {number} ({type})");
        }
    }
}