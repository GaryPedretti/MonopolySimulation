


namespace MonopolySimulation
{
    public class MonopolyGame
    {
        private int _playerCount;
        string[] tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];

        public int PlayerCount { get { return _playerCount; } }// set; }

        public IList<Player> Players { get; set; }
        public MonopolyBoard Board { get; set; }
        public IList<Square> Squares { get
            { return Board.Squares; }  }

        Die die1;
        Die die2;

        public MonopolyGame()
        {
            Players = new List<Player>();
            Board = new MonopolyBoard();
             die1 = new Die();
             die2 = new Die();
        }

        public void Setup(int numOfPlayers)
        {
            if (numOfPlayers < 2 || numOfPlayers > 8)
                throw new ArgumentException("Number of players must be between 2 and 8", "numOfPlayers");

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
     
            for (int i = 0; i < numberOfRounds; i++)
            {
                foreach (Player p in Players)
                {
                    p.TakeTurn(die1, die2);
                }
            }
        }
    }
}