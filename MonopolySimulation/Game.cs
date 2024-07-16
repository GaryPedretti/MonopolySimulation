namespace MonopolySimulation
{
    public class Game
    {
        private int _playerCount { get; set; }
        public int PlayerCount => _playerCount;
        public IList<Player> Players { get; set; }
        public IList<string> Squares { get; set; }

        public Game()
        {
            Players = new List<Player>();
            Squares = new List<string>();
            for (int i = 0; i < 40; i++)
            {
                Squares.Add("Square " + i);
            }
        }

        public void Setup(int numberOfPlayers)
        {
            if (numberOfPlayers < 2 || numberOfPlayers > 8) { throw new System.ArgumentException("Player count is not correct"); }
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Players.Add(new Player(i));
            }

            _playerCount = numberOfPlayers;
        }
    }
}