using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performance perf = new Performance { Name = "Liverpool", Wins = 15 };
            Console.WriteLine($"Đội: {perf.Name}, Thắng: {perf.Wins}");
        }
    }

    class Performance
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }
}