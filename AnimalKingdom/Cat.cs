namespace AnimalKingdom
{
    public class Cat : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
        
        //Returns the asked number using the property from the IMammal interface
        public int NumberOfNipples { get => 8; }
    }
}
