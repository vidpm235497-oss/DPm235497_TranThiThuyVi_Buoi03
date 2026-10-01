using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService service = new NotificationService();
            service.SendNotification("Trần Thị Thúy Vi", "Thông báo họp", true);
        }
    }

    class NotificationService
    {
        public void SendNotification(string user, string message, bool isUrgent)
        {
            string urgentPrefix = isUrgent ? "[KHẨN] " : "";
            Console.WriteLine($"Gửi tới {user}: {urgentPrefix}{message}");
        }
    }
}