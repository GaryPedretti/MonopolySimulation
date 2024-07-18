


using System.ComponentModel.DataAnnotations.Schema;

namespace MonopolySimulation
{
    public class MonopolyGame
    {
        string[] tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];

        private int _playerCount;
        public int PlayerCount { get { return _playerCount; } }

        public IList<Player> Players { get; set; }
        public MonopolyBoard Board { get; set; }
        public IList<Square> Squares { get { return Board.Squares; } }

        public MonopolyGame(){
            Players = new List<Player>();
            Board = new MonopolyBoard();
        }

        public Die Die1 { get; set; }
        public Die Die2 { get; set; }

        public void Setup(int numOfPlayers)
        {
            if (numOfPlayers < 2)
            {
                throw new ArgumentException("Number of players should be more than 1");
            }
            if (numOfPlayers > 8)
            {
                throw new ArgumentException("Number of players should be less than 9");
            }

            _playerCount = numOfPlayers;
            Players = new List<Player>();
            for(int i = 0; i < _playerCount; i++)
            {
                Player p = new Player(tokens[i], Squares.First());
                Players.Add(p);

            }

        }

        public void PlayRounds(int numberOfRounds)
        {
            for (int i = 0; i < numberOfRounds; i++)
            {
                foreach (Player p in Players)
                {
                    p.TakeTurn(Die1, Die2);
                }
            }
        }
    }
}