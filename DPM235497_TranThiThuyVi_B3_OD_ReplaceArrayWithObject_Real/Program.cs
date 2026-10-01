using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentScore score = new StudentScore("Trần Thị Thúy Vi", 8.5, 9.0);
            Console.WriteLine($"Sinh viên: {score.StudentName}, ĐTB: {score.GetAverage()}");
        }
    }

    class StudentScore
    {
        public string StudentName { get; set; }
        public double MathScore { get; set; }
        public double EnglishScore { get; set; }

        public StudentScore(string name, double math, double english)
        {
            StudentName = name;
            MathScore = math;
            EnglishScore = english;
        }

        public double GetAverage() => (MathScore + EnglishScore) / 2;
    }
}