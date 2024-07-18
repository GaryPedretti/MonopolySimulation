namespace MonopolySimulation
{
    public class PropertySquare : Square
    {
        public string Name { get; private set; }

        public Square NextSquare { get; set; }

        public PropertySquare(string name)
        {
            NextSquare = this;
            Name = name;
        }

        public void LandedOn(Player player)
        {
        }

        public void PassedBy(Player player) 
        {
        }
    }
}
