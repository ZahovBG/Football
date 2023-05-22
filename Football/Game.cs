using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public string Winner { get; set; }
        public List<Goal> Goals = new List<Goal>();
        
        public Game(Team team1, Team team2,Referee referee)
        {
            if (team1.Players.Count != 11|| team2.Players.Count != 11)
            {
                throw new Exception("Only 11 players allowed on a team!");
            }
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
           
        }
        public void AddGoal(int minute, FootbalPlayer player)
        {
            Goal goal = new Goal(minute, player);
            Goals.Add(goal);
        }
        public void PrintResult()
        {
            List<Goal> team1Goals = new List<Goal>();
            List<Goal> team2Goals = new List<Goal>();

            Console.WriteLine("Game result:");
            Console.WriteLine("Team 1 with coach: " + Team1.Coach.Name);
            Console.WriteLine("Team 2 with coach: " + Team2.Coach.Name);
            Console.WriteLine();
            foreach (var goal in Goals)
            {
                if (Team1.Players.Contains(goal.Player))
                {
                   team1Goals.Add(goal);
                }
                else if (Team2.Players.Contains(goal.Player))
                {
                    team2Goals.Add(goal);
                }
            }
            if (team1Goals.Count > team2Goals.Count)
            {
                Winner = "Team 1";
                Console.WriteLine($"Team 1 wins! {team1Goals.Count}:{team2Goals.Count}");
                Console.WriteLine("Team 1 goals: ");
                foreach (var goal in team1Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("Team 2 goals: ");
                foreach (var goal in team2Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
            }
            else if (team1Goals.Count < team2Goals.Count) 
            {
                Winner = "Team 2";
                Console.WriteLine($"Team 2 wins! {team2Goals.Count} : {team1Goals.Count}");
                Console.WriteLine("Team 2 goals: ");
                foreach (var goal in team2Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("Team 1 goals: ");
                foreach (var goal in team1Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
            }
            else
            {
                Winner = "Draw";
                Console.WriteLine("The game ends draw!");
                Console.WriteLine("Team 1 goals: ");
                foreach (var goal in team1Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("Team 2 goals: ");
                foreach (var goal in team2Goals)
                {
                    Console.WriteLine($"{goal.Minute}' by: {goal.Player.Name}");
                }
            }
        }
       
    }
}
