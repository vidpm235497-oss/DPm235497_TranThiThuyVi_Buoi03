using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor payment = new CreditCardPayment();
            payment.Process(100.0);
        }
    }

    abstract class PaymentProcessor
    {
        public abstract void Process(double amount);
    }

    class CreditCardPayment : PaymentProcessor
    {
        public override void Process(double amount) => Console.WriteLine($"Thanh toán {amount} qua thẻ tín dụng.");
    }
}