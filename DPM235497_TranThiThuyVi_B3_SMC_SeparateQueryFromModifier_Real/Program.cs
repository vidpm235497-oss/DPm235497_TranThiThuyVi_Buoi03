using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAccount account = new UserAccount();

            // Tách biệt giữa hàm lấy thông tin (Query) và hàm thay đổi dữ liệu (Modifier)
            if (account.IsLocked())
            {
                Console.WriteLine("Tài khoản đang bị khóa.");
            }
            else
            {
                account.IncrementLoginAttempts();
                Console.WriteLine("Đã cập nhật số lần đăng nhập sai.");
            }
        }
    }

    class UserAccount
    {
        private int failedAttempts = 3;

        public bool IsLocked() => failedAttempts >= 3;

        public void IncrementLoginAttempts() => failedAttempts++;
    }
}