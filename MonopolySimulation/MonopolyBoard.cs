using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class MonopolyBoard
    {
        private static readonly int _numberOfSquaresOnAMonopolyBoard = 40;
        public IList<Square> Squares { get; set; }

        public MonopolyBoard()
        {
            Squares = new List<Square>();
            for (int i = 0; i < _numberOfSquaresOnAMonopolyBoard; i++)
            {

                Square s2;
                switch (i)
                 {
               
                    case 0:

                        s2 = new GoSquare();
                        break;
                    case 4:
                        s2 = new IncomeTaxSquare();
                            break;
                      case 38:
                        s2 = new LuxuryTaxSquare();
                        break;
                    default:
                       s2 = new Square();
                        break;

                }

                if (i>0)
                {
                    Square s = Squares[i - 1];
                    s.NextSquare = s2;
                }


                Squares.Add(s2);

            }
            Squares[0].NextSquare = Squares[1];
            Squares[39].NextSquare = Squares[0];

        }
    }
}
