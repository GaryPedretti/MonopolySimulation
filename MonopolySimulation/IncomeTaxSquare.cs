namespace MonopolySimulation
{
    public class IncomeTaxSquare : Square
    {
        public IncomeTaxSquare() 
        { 
            Name = "Income Tax"; 
        }

        public override void LandedOn(Player p)
        {
            p.Debit(Math.Min(200, p.CashAmount / 10));
        }

        public override void PassedBy(Player p)
        {
            
        }
    }
}