using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JetPlane jet = new JetPlane();
            jet.ActivateAfterburner();
        }
    }

    abstract class Aircraft { }

    class JetPlane : Aircraft
    {
        public void ActivateAfterburner() => Console.WriteLine("Kích hoạt tăng tốc phản lực!");
    }
}