﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootbalPlayer> players;
        public List<FootbalPlayer> Players
        {
            get { return players; }
            set
            {
                if (value.Count < 11 || value.Count > 22) 
                {
                    throw new Exception("Only 11 to 22 players are allowed!");
                }
                players = value;
            }
        }
        public Team(Coach coach, List<FootbalPlayer> players)
        {
            Coach = coach;
            Players = players;
        }
        
        public double AverageAge
        {
            get
            {
                int totalAge = 0;
                foreach (var item in Players)
                {
                    totalAge += item.Age;
                }
                return (double)totalAge / Players.Count;
            }
        }
       
    }
}
