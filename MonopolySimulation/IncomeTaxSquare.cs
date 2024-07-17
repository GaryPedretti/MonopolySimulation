
namespace MonopolySimulation
{
    public class IncomeTaxSquare : Square
    {
        public override void LandedOn(Player player)
        {            
            if (player.CashAmount < 2000)
            {
                var amountToPay = player.CashAmount * .1;
                player.CashAmount -= (int)amountToPay;
            }
            else
            {
                player.CashAmount -= 200;
            }
        }
    }
}