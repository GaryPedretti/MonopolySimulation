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
                Squares.Add(new Square());
            }

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
    }
}