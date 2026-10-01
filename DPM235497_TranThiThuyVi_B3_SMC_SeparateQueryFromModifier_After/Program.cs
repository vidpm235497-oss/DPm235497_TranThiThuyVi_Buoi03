using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static string[] people = { "Don", "John", "Kent" };

        static void Main(string[] args)
        {
            CheckForMiscreant(people);
            string found = FoundMiscreant(people);
            Console.WriteLine($"Tìm thấy kẻ xấu: {found}");
        }

        static void CheckForMiscreant(string[] people)
        {
            if (FoundMiscreant(people) != "")
            {
                SendAlert();
            }
        }

        static string FoundMiscreant(string[] people)
        {
            foreach (var p in people)
            {
                if (p == "Don" || p == "John") return p;
            }
            return "";
        }

        static void SendAlert() => Console.WriteLine("Cảnh báo khẩn cấp!");
    }
}