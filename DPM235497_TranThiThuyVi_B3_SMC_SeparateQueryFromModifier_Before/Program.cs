using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static string[] people = { "Don", "John", "Kent" };

        static void Main(string[] args)
        {
            string found = FoundMiscreantAndSendAlert(people);
            Console.WriteLine($"Tìm thấy kẻ xấu: {found}");
        }

        static string FoundMiscreantAndSendAlert(string[] people)
        {
            foreach (var p in people)
            {
                if (p == "Don" || p == "John")
                {
                    SendAlert();
                    return p;
                }
            }
            return "";
        }

        static void SendAlert() => Console.WriteLine("Cảnh báo khẩn cấp!");
    }
}