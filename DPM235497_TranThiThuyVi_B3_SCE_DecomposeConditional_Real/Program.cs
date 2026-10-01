using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Giá phòng: {GetRoomRate(7, true)}");
        }

        static double GetRoomRate(int month, bool isWeekend)
        {
            if (IsPeakSeason(month, isWeekend))
                return 200.0;
            return 100.0;
        }

        static bool IsPeakSeason(int month, bool isWeekend)
        {
            return (month >= 6 && month <= 8) || isWeekend;
        }
    }
}