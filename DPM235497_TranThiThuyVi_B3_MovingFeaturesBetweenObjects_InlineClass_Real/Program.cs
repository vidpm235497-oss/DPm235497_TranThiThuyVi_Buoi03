using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Email = "thuyvi@example.com" };
            Console.WriteLine($"Email người dùng: {user.Email}");
        }
    }

    class User
    {
        public string Email { get; set; }
    }
}