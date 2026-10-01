using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string platform = "MAC";
            string browser = "IE";
            int resize = 1;

            if ((platform.ToUpper().IndexOf("MAC") > -1) &&
                (browser.ToUpper().IndexOf("IE") > -1) &&
                resize > 0)
            {
                Console.WriteLine("Điều kiện thỏa mãn.");
            }
        }
    }
}