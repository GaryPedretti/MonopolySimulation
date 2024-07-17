
namespace MonopolySimulation
{
    public class LuxurySquare : Square
    {
        public override void LandedOn(Player player)
        {
            player.CashAmount -= 75;
        }
    }
}