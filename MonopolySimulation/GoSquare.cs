
namespace MonopolySimulation
{
    public class GoSquare : Square
    {
        public override void LandedOn(Player player)
        {
            player.CashAmount += 200;
        }

        internal override void PassedBy(Player player)
        {
            player.CashAmount += 200;
        }
    }
}