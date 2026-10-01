using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static int numberOfLateDeliveries = 10;

        static void Main(string[] args)
        {
            int rating = GetRating();
            Console.WriteLine($"Đánh giá điểm giao hàng: {rating}");
        }

        static int GetRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}