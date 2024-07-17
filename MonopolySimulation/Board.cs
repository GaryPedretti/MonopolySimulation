

namespace MonopolySimulation
{
    public class Board
    {
        private const int defaultNumberOfSquares = 40;

        public readonly IList<Square> Squares;

        public Board()
        {
            Squares = new List<Square>();

            for (int squareCount = 0; squareCount < defaultNumberOfSquares;  squareCount++)
            {
                Squares.Add(new());
            }

            for (int squaresIdx = 0; squaresIdx < Squares.Count - 1; squaresIdx++)
            {
                Squares[squaresIdx].NextSquare = Squares[(squaresIdx + 1)];
            }

            Squares.Last().NextSquare = Squares.First();
        }

        public int getCountOfSquares()
        {
            return Squares.Count;
        }

        public Square getFirstSquare()
        {
            return Squares.First();
        }
    }
}