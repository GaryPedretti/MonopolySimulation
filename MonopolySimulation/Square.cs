
namespace MonopolySimulation
{
    public class Square
    {
        public Square Next { get; set; }

        public virtual void LandedOn(Player player) { }
    }
}