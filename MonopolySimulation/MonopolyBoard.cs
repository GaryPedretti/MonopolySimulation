using System.ComponentModel.Design;

namespace MonopolySimulation
{
    public class MonopolyBoard
    {
        private static readonly int _numberOfSquaresOnAMonopolyBoard = 40;
        
        private ISquareDao _squareDao;

        public IList<Square> Squares { get; set; }

        public MonopolyBoard() : this(new SquareHardcodedDao()) { }

        public MonopolyBoard(ISquareDao squareDao)
        {
            _squareDao = squareDao;
            CreateSquares();
            LinkSquares();
        }

        private void LinkSquares()
        {
            for (int i = 0; i < _numberOfSquaresOnAMonopolyBoard; i++)
            {
                if (i != (_numberOfSquaresOnAMonopolyBoard - 1))
                {
                    Squares[i].NextSquare = Squares[i + 1];
                }
                else
                {
                    // wraparound after Boardwalk
                    Squares[i].NextSquare = Squares[0];
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void CreateSquares()
        {
            Squares = new List<Square>();

            for (int i = 0; i < _numberOfSquaresOnAMonopolyBoard; i++)
            {
                Squares.Add(_squareDao.CreateSquare(i));
            }
        }
    }
}