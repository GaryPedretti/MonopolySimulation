using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class IncomeTaxSquare : Square
    {
        public IncomeTaxSquare() {
            Location = 4;
            NeighborSquare.Location = 5;
        }

        public override void LandedOn(Player player)
        {
            //var taxPercent = player.Funds * 0.1f;

            //if (taxPercent > 200f)
            //{
            //    player.Funds -= 200;
            //} else
            //{
            //    player.Funds -= (int)Math.Floor(taxPercent);
            //}

            player.Funds = (player.Funds / 10) > 200 ? 
                player.Funds - 200 : 
                player.Funds - player.Funds / 10; 
        }

        public override Square NextSquare()
        {
            return NeighborSquare;
        }

        public override void PassedBy(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
