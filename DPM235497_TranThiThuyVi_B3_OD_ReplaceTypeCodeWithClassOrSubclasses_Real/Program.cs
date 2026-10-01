using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRole role = UserRole.Admin;
            Console.WriteLine($"Quyền truy cập: {role}");
        }
    }

    enum UserRole
    {
        Guest,
        Member,
        Admin
    }
}