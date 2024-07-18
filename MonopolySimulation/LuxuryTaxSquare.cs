namespace MonopolySimulation
{
    public class LuxuryTaxSquare : Square
    {
        public string Name => " Luxury Tax ";

        public Square NextSquare { get; set; }

        public LuxuryTaxSquare()
        {
            NextSquare = this;
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