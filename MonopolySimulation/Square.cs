namespace MonopolySimulation
{
    public interface Square
    {
        public string Name { get; }
        public Square NextSquare { get; set; }

        public void LandedOn(Player player);
        public void PassedBy(Player player);
    }
}