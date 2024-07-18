namespace MonopolySimulation
{
    public class LuxuryTaxSquare : Square
    {
        public string Name { get; private set; }

        public Square NextSquare { get; set; }

        public LuxuryTaxSquare(string name)
        {
            NextSquare = this;
            Name = name;
        }

        public void LandedOn(Player player)
        {
            player.Funds -= 75;
        }

        public void PassedBy(Player player)
        {
        }
    }
}