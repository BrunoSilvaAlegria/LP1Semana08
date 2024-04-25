using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {   
        //Added bee sound with the same method from Dog and Cat
        public override string Sound()
        {
            return base.Sound() + "Bzzzz";
        }
        //Returns the asked number using the property from the ICanFly interface
        public int NumberOfWings { get => 2; }
    }
}