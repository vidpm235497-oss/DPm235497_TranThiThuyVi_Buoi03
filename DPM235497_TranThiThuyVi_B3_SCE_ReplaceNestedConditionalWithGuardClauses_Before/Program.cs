using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static bool isDead = false;
        static bool isSeparated = false;
        static bool isRetired = false;

        static void Main(string[] args)
        {
            Console.WriteLine($"Số tiền: {GetPayAmount()}");
        }

        static double GetPayAmount()
        {
            double result;
            if (isDead)
            {
                result = 100;
            }
            else
            {
                if (isSeparated)
                {
                    result = 200;
                }
                else
                {
                    if (isRetired)
                        result = 300;
                    else
                        result = 500;
                }
            }
            return result;
        }
    }
}