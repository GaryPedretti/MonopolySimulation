using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class SquareDaoTextFile : ISquareDao
    {
        public Square CreateSquare(int position)
        {
            return CreateSquare(position, "", 0, 0);
        }

        public Square CreateSquare(int position, string name, int price, int rent)
        {
            throw new NotImplementedException();
        }
    }
}
