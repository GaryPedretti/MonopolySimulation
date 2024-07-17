using System.Runtime.InteropServices;

namespace MonopolySimulation
{
    public class MonopolyBoard
    {
        private static readonly int _numberOfSquaresOnAMonopolyBoard = 40;

        public IList<Square> Squares { get; set; }

        public MonopolyBoard()
        {
            Squares = new List<Square>();
            CreateSquares();
            LinkSquares();
        }

        private void LinkSquares()
        {
            for (int i = 0; i < _numberOfSquaresOnAMonopolyBoard; i++)
            {
                var nextIndex = i + 1;
                if (nextIndex == _numberOfSquaresOnAMonopolyBoard)
                    nextIndex = 0;

                Squares[i].Next = Squares[nextIndex];
            }
        }

        private void CreateSquares()
        {
            for (int i = 0; i < _numberOfSquaresOnAMonopolyBoard; i++)
            {
                Square squareToAdd;

                switch (i)
                {
                    case 0: 
                        squareToAdd = new GoSquare();
                        break;
                    case 4:
                        squareToAdd = new IncomeTaxSquare();
                        break;
                    case 38:
                        squareToAdd = new LuxurySquare();
                        break;
                    default:
                        squareToAdd = new Square();
                        break;
                }
                Squares.Add(squareToAdd);
            }
        }
    }
}