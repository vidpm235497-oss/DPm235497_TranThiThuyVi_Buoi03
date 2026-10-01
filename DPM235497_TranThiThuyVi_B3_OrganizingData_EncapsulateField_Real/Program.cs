using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            Console.WriteLine($"Số dư tài khoản: {account.Balance}");
        }
    }

    class BankAccount
    {
        private double balance;

        public double Balance => balance;

        public void Deposit(double amount)
        {
            if (amount > 0) balance += amount;
        }
    }
}