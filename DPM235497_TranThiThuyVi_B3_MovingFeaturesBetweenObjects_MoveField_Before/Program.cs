using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account { InterestRate = 0.05 };
            Console.WriteLine($"Tiền lãi: {acc.InterestRate}");
        }
    }

    class AccountType { }

    class Account
    {
        public AccountType Type { get; set; }
        public double InterestRate { get; set; }
    }
}