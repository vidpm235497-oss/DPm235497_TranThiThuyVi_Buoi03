using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] row = new string[3];
            row[0] = "Liverpool";
            row[1] = "15";

            Console.WriteLine($"Đội: {row[0]}, Thắng: {row[1]}");
        }
    }
}