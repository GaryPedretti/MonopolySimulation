


namespace MonopolySimulation
{
    public class MonopolyGame
    {
        private int _playerCount;
        public int PlayerCount { get { return _playerCount; } }

        public IList<Player> Players { get; set; }

        public void Setup(int numOfPlayers)
        {
            if (numOfPlayers < 2)
            {
                throw new ArgumentException("Number of players should be more than 1");
            }
            if (numOfPlayers > 9)
            {
                throw new ArgumentException("Number of players should be less than 9");
            }

            _playerCount = numOfPlayers;
            Players = [new Player("dog"), new Player("sport car"), new Player("iron"), new Player("battleship"), new Player("top hat"), new Player("thimble"), new Player("wheelbarrow"), new Player("cat")];

        }
    }
}