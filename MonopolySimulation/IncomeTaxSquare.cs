namespace MonopolySimulation
{
    internal class IncomeTaxSquare : Square
    {
        public string Name { get; private set; }

        public Square NextSquare { get; set; }

        public IncomeTaxSquare(string name)
        {
            NextSquare = this;
            Name = name;
        }

        public void LandedOn(Player player)
        {
            if (player.Funds < 2000)
            {
                player.Funds = (int)(0.9 * player.Funds);
            }
            else {
                player.Funds -= 200;
            }
        }

        public void PassedBy(Player player)
        {
        }
    }
}