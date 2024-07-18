using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class LuxurySquare : Square
    {
        public LuxurySquare()
        {
            Location = 38;
            NeighborSquare.Location = 39;
        }
        public override void LandedOn(Player player)
        {
            player.Funds -= 75;
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
