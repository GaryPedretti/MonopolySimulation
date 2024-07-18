

namespace MonopolySimulation
{
    public class Board
    {
        public Board()
        {
            BuildSquares();
            LinkSquares();
        }

        private void LinkSquares()
        {
            var index = 0;

            foreach (var square in Squares)
            {
                if (square.Location == -1)
                {
                    square.Location = index;
                }
                
                index++;
            }
            for (var i = 0; i < Squares.Count; i++)
            {
                var square = Squares[i];

                if (i < 39)
                {
                    var nextSquare = Squares[i + 1];
                    square.NeighborSquare = nextSquare;
                }
                else
                {
                    square.NeighborSquare = Squares[0];
                }

            }
        }

        public IList<Square> Squares { get; set; } = [];

        public void AssignFirstSquare(IList<Player> players)
        {
            foreach (Player p in players)
            {
                AssignFirstSquare(p);
            }
        }

        public void AssignFirstSquare(Player p)
        {
            p.CurrentSquare = Squares[0];
        }

        private void BuildSquares()
        {
            Squares = [new GoSquare(), new LuxurySquare(), new IncomeTaxSquare()];


            for (int i = 0; i < 37; i++)
            {
                var square = new EmptySquare();
                Squares.Add(square);
            }

        }
    }
}