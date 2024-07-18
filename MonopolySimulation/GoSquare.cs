namespace MonopolySimulation
{
    public class GoSquare : Square
    {
        public string Name { get; private set; }

        public Square NextSquare { get; set; }

        public GoSquare(string name) {
            NextSquare = this;
            Name = name;
        }

        public void LandedOn(Player player)
        {
            player.Funds += 200;
        }

        public void PassedBy(Player player)
        {
            player.Funds += 200;
        }
    }
}
