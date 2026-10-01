using System;

namespace RefactoringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee { Team = new Team { LeaderName = "Trần Thị Thúy Vi" } };
            Console.WriteLine($"Nhóm trưởng: {emp.GetLeaderName()}");
        }
    }

    class Team { public string LeaderName { get; set; } }

    class Employee
    {
        public Team Team { get; set; }
        public string GetLeaderName() => Team.LeaderName;
    }
}