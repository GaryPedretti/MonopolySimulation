namespace MonopolySimulation
{
    public class MonopolyGame
    {
        private int _playerCount;
        public int PlayerCount { get { return _playerCount; } }// set;
        public void Setup(int numOfPlayers) {
            if (numOfPlayers < 2)
            {
                throw new ArgumentException("You cannot play solo");
            }

            if (numOfPlayers > 8)
            {
                throw new ArgumentException("Too many players, no more than 8, please");
            }
           
            _playerCount = numOfPlayers;
            var player= new Player();

            Players = player.Create(numOfPlayers);
            Board = new ();
        }
        public IList<Player> Players { get; set; } = [];
        public Board Board { get; set; }
    }
}