


namespace MonopolySimulation
{
    public class MonopolyGame
    {
        private int _playerCount;
        private int _totalRoundsPlayed = 0;
        private IMonopolyUI _ui;

        string[] tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];

        public int PlayerCount { get { return _playerCount; } }// set; }

        public IList<Player> Players { get; set; }
        public MonopolyBoard Board { get; set; }
        public IList<Square> Squares { get
            { return Board.Squares; }  }

        Die die1;
        Die die2;

        public MonopolyGame() : this(new MonopolyConsoleUI()) { }

        public MonopolyGame(IMonopolyUI monopolyUI)
        {
            _ui = monopolyUI;
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
                _totalRoundsPlayed++;
                _ui.SendUIMessage(string.Format("** ROUND {0} **", _totalRoundsPlayed));
                foreach (Player p in Players)
                {
                    p.TakeTurn(die1, die2);
                    _ui.SendUIMessage(string.Format("{0} rolls a {1}", p.Token, (die1.FaceValue + die2.FaceValue)));
                    _ui.SendUIMessage(string.Format("{0} lands on square {1}", p.Token, p.CurrentSquare.Name));
                    _ui.SendUIMessage(string.Format("{0} has ${1}", p.Token, p.CashAmount));
                }
            }
        }
    }
}