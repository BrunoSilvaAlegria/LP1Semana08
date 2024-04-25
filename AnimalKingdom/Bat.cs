using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        //Added bat sound with the same method from Dog and Cat
        public override string Sound()
        {
            return base.Sound() + "Tititi"; 
        }
        
        //Returns the asked number using the property from the IMammal interface
        public int NumberOfNipples { get => 2; }
        
        //Returns the asked number using the property from the ICanFly interface
        public int NumberOfWings { get => 2; }
    }
}