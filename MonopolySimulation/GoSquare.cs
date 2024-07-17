
namespace MonopolySimulation
{
    public class GoSquare : Square
    {
        public override void LandedOn(Player player)
        {
            player.CashAmount += 200;
        }
    }
}