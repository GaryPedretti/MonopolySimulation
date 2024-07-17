namespace MonopolySimulation
{
    public class GoSquare : Square
    {
        
        public override void LandedOn(Player p)
        {
            
        }

        public override void PassedBy(Player p)
        {
            p.Credit(200);
        }

    }
}