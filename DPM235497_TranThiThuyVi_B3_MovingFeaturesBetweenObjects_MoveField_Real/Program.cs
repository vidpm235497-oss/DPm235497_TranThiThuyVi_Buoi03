using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Engine = new Engine { HorsePower = 150 } };
            Console.WriteLine($"Mã lực động cơ: {car.Engine.HorsePower}");
        }
    }

    class Engine { public int HorsePower { get; set; } }
    class Car { public Engine Engine { get; set; } }
}