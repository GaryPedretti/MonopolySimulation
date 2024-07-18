

namespace MonopolySimulation
{
    public class Board
    {
        private const int defaultNumberOfSquares = 40;

        public readonly IList<Square> Squares;

        public Board() : this(new MonopolySquareRepository()) { }

        public Board(ISquareRepository squareRepository)
        {
            Squares = squareRepository.GetAllSquares();
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