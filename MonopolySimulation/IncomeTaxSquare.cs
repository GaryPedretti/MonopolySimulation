
namespace MonopolySimulation
{
    public class IncomeTaxSquare : Square
    {
        public override void LandedOn(Player player)
        {            
            player.CashAmount -= 200;
        }
    }
}