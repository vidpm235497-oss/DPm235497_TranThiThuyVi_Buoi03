using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new NullLogger();
            logger.Log("Thực thi công việc...");
        }
    }

    interface ILogger { void Log(string message); }

    class NullLogger : ILogger
    {
        public void Log(string message) { /* Không làm gì cả */ }
    }
}