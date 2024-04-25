namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
        
        //Returns the asked number using the property from the IMammal interface
        public int NumberOfNipples { get => 8; } 
    }
}
