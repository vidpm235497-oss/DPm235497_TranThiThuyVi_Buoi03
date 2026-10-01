using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Form Template Method Before");
        }
    }

    class Statement
    {
        public void PrintText()
        {
            Console.WriteLine("Header");
            Console.WriteLine("Body Text");
            Console.WriteLine("Footer");
        }

        public void PrintHtml()
        {
            Console.WriteLine("<h1>Header</h1>");
            Console.WriteLine("<p>Body Text</p>");
            Console.WriteLine("<footer>Footer</footer>");
        }
    }
}