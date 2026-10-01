using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Tốc độ: {GetSpeed(1)}");
        }

        static double GetSpeed(int type)
        {
            switch (type)
            {
                case 1: return 35.0;
                case 2: return 40.0;
                default: return 0.0;
            }
        }
    }
}