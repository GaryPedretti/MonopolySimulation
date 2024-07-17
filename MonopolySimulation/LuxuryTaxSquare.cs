namespace MonopolySimulation
{
    public class LuxuryTaxSquare : Square
    {
        public override void LandedOn(Player p)
        {
            p.Debit(75);
        }

        public override void PassedBy(Player p)
        {
            
        }
    }
}