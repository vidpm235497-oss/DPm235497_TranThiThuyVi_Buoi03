using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code trước khi Pull Up Method");
        }
    }

    abstract class Vehicle { }

    class Car : Vehicle
    {
        public void TurnOnEngine() => Console.WriteLine("Bật động cơ");
    }

    class Truck : Vehicle
    {
        public void TurnOnEngine() => Console.WriteLine("Bật động cơ");
    }
}