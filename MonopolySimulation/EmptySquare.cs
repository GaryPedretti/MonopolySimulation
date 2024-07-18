namespace MonopolySimulation
{
    public class EmptySquare : Square
    {
        public EmptySquare()
        {
            Location = -1;
        }
        public override void LandedOn(Player player)
        {
            return;
        }

        public override Square NextSquare()
        {
            return NeighborSquare;
        }

        public override void PassedBy(Player player)
        {
            throw new NotImplementedException();
        }
    }

}
