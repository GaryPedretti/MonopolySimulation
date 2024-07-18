

namespace MonopolySimulation
{
    public class Board
    {
        private const int defaultNumberOfSquares = 40;

        public readonly IList<Square> Squares;

        public Board()
        {
            Squares = [
                new GoSquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new IncomeTaxSquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new PropertySquare(),
                new LuxuryTaxSquare(),
                new PropertySquare()
            ];
            for (int squareCount = 0; squareCount < Squares.Count - 1 ;  squareCount++)
            {
                Squares[squareCount].NextSquare = Squares[squareCount + 1];
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