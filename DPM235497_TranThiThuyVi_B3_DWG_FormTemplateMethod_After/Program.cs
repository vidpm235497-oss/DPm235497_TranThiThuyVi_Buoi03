using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statement stmt = new TextStatement();
            stmt.Print();
        }
    }

    abstract class Statement
    {
        public void Print()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        protected abstract void PrintHeader();
        protected abstract void PrintBody();
        protected abstract void PrintFooter();
    }

    class TextStatement : Statement
    {
        protected override void PrintHeader() => Console.WriteLine("Header");
        protected override void PrintBody() => Console.WriteLine("Body Text");
        protected override void PrintFooter() => Console.WriteLine("Footer");
    }
}