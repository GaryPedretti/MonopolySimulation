namespace MonopolySimulation
{
    public class MonopolyGame
    {
        private int _playerCount;
        public int PlayerCount { get { return _playerCount; } }// set;
        public Die Die1 { get; private set; } = new Die();
        public Die Die2 { get; private set; }= new Die();
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
            Board.AssignFirstSquare(Players);
        }

        public void PlayRounds(int numberOfRounds)
        {
            for (int i = 0; i < numberOfRounds; i++)
            {
                foreach (var player in Players)
                {
                    player.TakeTurn(Die1, Die2);
                }
            }
        }

        public IList<Player> Players { get; set; } = [];
        public Board Board { get; set; }
    }
}