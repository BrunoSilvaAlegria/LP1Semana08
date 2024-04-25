using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class Player
    {
        public Player (string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string Name { get; } //Read-only property
        public int Score { get; set; }
    }
}