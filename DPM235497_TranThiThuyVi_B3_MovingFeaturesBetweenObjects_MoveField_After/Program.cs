using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account { Type = new AccountType { InterestRate = 0.05 } };
            Console.WriteLine($"Tiền lãi: {acc.Type.InterestRate}");
        }
    }

    class AccountType
    {
        public double InterestRate { get; set; }
    }

    class Account
    {
        public AccountType Type { get; set; }
    }
}