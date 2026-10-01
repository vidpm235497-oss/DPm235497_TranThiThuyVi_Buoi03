using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Eat();
        }
    }

    abstract class Animal
    {
        public void Eat() => Console.WriteLine("Đang ăn thức ăn...");
    }

    class Dog : Animal { }
    class Cat : Animal { }
}