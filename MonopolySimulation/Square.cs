namespace MonopolySimulation
{
    public class Square
    {
        public string Name { get; set; }

        public Square NextSquare { get; set; }

        public virtual void LandedOn(Player p)
        {

        }

        public virtual void PassedBy(Player p)
        {

        }

    }
}