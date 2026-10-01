using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new European();
            Console.WriteLine($"Tốc độ: {bird.GetSpeed()}");
        }
    }

    abstract class Bird
    {
        public abstract double GetSpeed();
    }

    class European : Bird
    {
        public override double GetSpeed() => 35.0;
    }

    class African : Bird
    {
        public override double GetSpeed() => 40.0;
    }
}