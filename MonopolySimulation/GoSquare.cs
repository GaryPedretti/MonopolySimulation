namespace MonopolySimulation
{
    public class GoSquare : Square
    {
        public string Name => " Go ";

        public Square NextSquare { get; set; }

        public GoSquare() {
            NextSquare = this;
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
