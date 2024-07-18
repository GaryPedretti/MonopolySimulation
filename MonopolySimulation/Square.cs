using System.IO.Pipes;

namespace MonopolySimulation
{
    public abstract class BaseSquare
    {
        public Square NextSquare { get; set; }

 


        public virtual void LandedOn(Player p)
        {

        }
        public virtual void PassedBy(Player p)
        {

        }
    }
    public class Square : BaseSquare {

    }
    public class GoSquare : Square
    {
        public override void LandedOn(Player p)
        {
            //p.CashAmount += 200;
        }
        public override void PassedBy(Player p)
        {
            p.CashAmount += 200;
        }

    }


    public class LuxuryTaxSquare : Square
    {
        public override void LandedOn(Player p)
        {
            p.CashAmount -= 75;
        }
        public override void PassedBy(Player p)
        {

        }
    }
    public class IncomeTaxSquare : Square
    {
        public override void LandedOn(Player p)
        {
            p.CashAmount -= Math.Min(200, p.CashAmount / 10);
        }
        public override void PassedBy(Player p)
        {

        }
    }


}