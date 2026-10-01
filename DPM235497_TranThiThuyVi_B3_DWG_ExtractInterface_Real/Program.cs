using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrintable doc = new Invoice();
            doc.Print();
        }
    }

    interface IPrintable
    {
        void Print();
    }

    class Invoice : IPrintable
    {
        public void Print() => Console.WriteLine("In hóa đơn bán hàng...");
    }
}