using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class Player : IComparable<Player>
    {
        public Player (string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string Name { get; } //Read-only property
        public int Score { get; set; }

        public int CompareTo(Player other) //Compares the players score
        {
            // 1 means that this player's score is bigger than the other players score.
            // -1 means that this player's score is smaller than the other players score.
            // 0 means that this player's score is the same than the other players score. 
            if (other == null) return 1; 
            if (Score > other.Score) return 1;
            else if (Score < other.Score) return -1;
            else return 0;

        }
    }
}
