using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account { Type = new AccountType { IsPremium = true }, DaysOverdrawn = 4 };
            Console.WriteLine($"Phí quá hạn: {acc.BankCharge()}");
        }
    }

    class AccountType { public bool IsPremium { get; set; } }

    class Account
    {
        public AccountType Type { get; set; }
        public int DaysOverdrawn { get; set; }

        public double OverdraftCharge()
        {
            if (Type.IsPremium)
            {
                double result = 10;
                if (DaysOverdrawn > 7) result += (DaysOverdrawn - 7) * 0.85;
                return result;
            }
            return DaysOverdrawn * 1.75;
        }

        public double BankCharge()
        {
            double result = 4.5;
            if (DaysOverdrawn > 0) result += OverdraftCharge();
            return result;
        }
    }
}