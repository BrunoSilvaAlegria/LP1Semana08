using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public bool Ord { get; } // Read-only property
        public CompareByName (bool ord) // Constructor that defines list's order
        {
            Ord = ord;
        }

        /// <summary>
        /// Method that allows the Names of the players to be compared and the 
        /// list's order to be defined with help of the CompareByName constructor
        /// </summary>
        /// <param name="p1">First player name</param>
        /// <param name="p2">Second player name</param>
        /// <returns>An integer value that indicates the relative order of the 
        /// two objects</returns>
        
        public int Compare (Player p1, Player p2) 
        {
            int o; //Variable that stores the value returned by CompareTo method
            
            //Defines if the list will be ordered ascending or descending
            //Returns a negative integer, zero, or a positive integer if the 
            //first object is less than, equal to, or greater than the second 
            //object, respectively. 
            if (Ord)          
            {
                o = p1.Name.CompareTo (p2.Name); 
            }
            else
            {
                o = p2.Name.CompareTo (p1.Name);
            }
            return o;          
        }
    }
}