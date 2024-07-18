namespace MonopolySimulation
{
    public class PropertySquare : Square
    {
        public string Name => "Random Property";

        public Square NextSquare { get; set; }

        public PropertySquare()
        {
            NextSquare = this;
        }

        public void LandedOn(Player player)
        {
        }

        public void PassedBy(Player player) 
        {
        }
    }
}
