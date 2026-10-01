using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rental rental = new Rental { Movie = new Movie { Price = 3.0 }, DaysRented = 5 };
            Console.WriteLine($"Tổng tiền thuê: {rental.GetCharge()}");
        }
    }

    class Movie { public double Price { get; set; } }

    class Rental
    {
        public Movie Movie { get; set; }
        public int DaysRented { get; set; }

        public double GetCharge() => Movie.Price * DaysRented;
    }
}