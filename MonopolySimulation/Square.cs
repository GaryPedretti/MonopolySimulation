
namespace MonopolySimulation
{
    public abstract class Square
    {
        public int Location { get; set; }
        public Square NeighborSquare  { get; set; }
        public abstract Square NextSquare();      
        public abstract void LandedOn(Player player); 
        public abstract void PassedBy(Player player);


       
    }

}