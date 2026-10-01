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

            bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
            bool isIEBrowser = browser.ToUpper().IndexOf("IE") > -1;
            bool wasResized = resize > 0;

            if (isMacOs && isIEBrowser && wasResized)
            {
                Console.WriteLine("Điều kiện thỏa mãn.");
            }
        }
    }
}