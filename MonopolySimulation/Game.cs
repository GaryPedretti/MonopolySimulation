namespace MonopolySimulation
{
    public class Game
    {
        private int _playerCount { get; set; }
        public int PlayerCount => _playerCount;
        public IList<Player> Players { get; set; }

        public Game()
        {
            Players = new List<Player>();
        }

        public void Setup(int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Players.Add(new Player(i));
            }

            _playerCount = numberOfPlayers;
        }
    }
}