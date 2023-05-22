using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Goal
    {
        public int Minute { get; set; }
        public FootbalPlayer Player { get; set; }
        public Goal(int minute, FootbalPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
