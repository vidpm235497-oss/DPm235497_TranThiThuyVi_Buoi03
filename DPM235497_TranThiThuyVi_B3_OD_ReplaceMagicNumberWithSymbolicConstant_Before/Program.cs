using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mass = 50.0;
            double potentialEnergy = PotentialEnergy(mass, 10.0);
            Console.WriteLine($"Thế năng: {potentialEnergy}");
        }

        static double PotentialEnergy(double mass, double height)
        {
            return mass * 9.81 * height;
        }
    }
}