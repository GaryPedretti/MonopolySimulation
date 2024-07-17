using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class SquareHardcodedDao : ISquareDao
    {
        private static readonly int _positionOfGoSquare = 0;
        private static readonly int _positionOfIncomeTaxSquare = 4;
        private static readonly int _positionOfLuxuryTaxSquare = 38;

        public Square CreateSquare(int position)
        {
            if (position == _positionOfGoSquare)
            {
                return new GoSquare();
            }
            else if (position == _positionOfLuxuryTaxSquare)
            {
                return new LuxuryTaxSquare();
            }
            else if (position == _positionOfIncomeTaxSquare)
            {
                return new IncomeTaxSquare();
            }
            else
            {
                return new Square() { Name= position.ToString() };
            }
        }
    }
}
