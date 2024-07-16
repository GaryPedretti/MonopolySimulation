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

        }
    }
}