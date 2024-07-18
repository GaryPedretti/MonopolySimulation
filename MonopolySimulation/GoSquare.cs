using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class GoSquare : Square
    {
        public GoSquare()
        {
            Location = 0;
            NeighborSquare.Location = 1;
        }
        public override void LandedOn(Player player)
        {
            player.Funds += 200;
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
