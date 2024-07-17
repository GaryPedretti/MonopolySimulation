


namespace MonopolySimulation
{
    public class Game
    {
        private int _playerCount;

        public int PlayerCount { get { return _playerCount; } }

        private string[] _tokens;

        public IList<Player>? Players { get; set; }
        public Board Board { get; set; }
        public IList<Square> Squares { get
            { return Board.Squares; }  }

        public Game()
        {
            Players = new List<Player>();
            Board = new Board();
        }

        public void Setup(int numOfPlayers, string[] tokens)
        {
            if (numOfPlayers < 2 || numOfPlayers > 8)
                throw new ArgumentException("Number of players must be between 2 and 8", "numOfPlayers");

            _tokens = tokens;
            Players = new List<Player>(); 
            _playerCount = numOfPlayers;
            for (int i = 0; i < numOfPlayers; i++)
            {
                Player p = new Player(Squares.First(), tokens[i]);
                Players.Add(p);
            }
        }

        public void PlayRounds(int numberOfRounds)
        {
            foreach (Player player in Players) {
                player.CurrentSquare = new Square(); 
            }
        }
    }
}