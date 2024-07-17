


namespace MonopolySimulation
{
    public class MonopolyGame
    {
        private int _playerCount;
        private int _totalRoundsPlayed = 0;
        private IMonopolyUI _ui;

        string[] tokens = ["Dog", "Sport Car", "Iron", "Battleship", "Top Hat", "Thimble", 
            "Wheelbarrow", "Cat"];

        public int PlayerCount { get { return _playerCount; } }  

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
                _ui.SendUIMessage(string.Format("** START ROUND {0} **", _totalRoundsPlayed));
                _ui.SendUIMessage(string.Empty);
                foreach (Player p in Players)
                {
                    _ui.SendUIMessage(string.Format("Player: {0}", p.Token));
                    _ui.SendUIMessage(string.Format("is currently on {0}", p.CurrentSquare.Name));

                    p.TakeTurn(die1, die2);
                    _ui.SendUIMessage(string.Format("rolls a {0}", (die1.FaceValue + die2.FaceValue)));

                    _ui.SendUIMessage(string.Format("lands on {0}", p.CurrentSquare.Name));
                    _ui.SendUIMessage(string.Format("has $ {0}", p.CashAmount));
                    _ui.SendUIMessage(string.Empty);
                    
                }
                _ui.SendUIMessage(string.Format("** END ROUND {0} **", _totalRoundsPlayed));
                _ui.SendUIMessage(string.Empty); 

            }
        }
    }
}