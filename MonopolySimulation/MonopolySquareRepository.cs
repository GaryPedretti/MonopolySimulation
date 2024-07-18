
namespace MonopolySimulation
{
    public class MonopolySquareRepository : ISquareRepository
    {
        private readonly IList<Square> _squares;

        public MonopolySquareRepository() : this(new CSVDataAdapter())
        {

        }

        public MonopolySquareRepository(ISquareDataAdapter squareDataAdapter)
        {
            this._squares = squareDataAdapter.CreateAllSquares();

            for (int squareCount = 0; squareCount < _squares.Count - 1; squareCount++)
            {
                _squares[squareCount].NextSquare = _squares[squareCount + 1];
            }

            _squares.Last().NextSquare = _squares.First();
        }

        public IList<Square> GetAllSquares()
        {
            return _squares;
        }
    }
}