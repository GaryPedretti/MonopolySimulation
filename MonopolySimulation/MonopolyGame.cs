

namespace MonopolySimulation
{
    public class MonopolyGame
    {
        public int PlayerCount { get{ return Players.Count(); } }
        public IList<Player> Players { get; private set; } = [];
        public Board Board { get; private set; } = new();

        private readonly string[] _tokens = ["dog", "top hat", "race car", "thimble", "iron", "battleship", "cat", "penguin"];
        private readonly Die _die1 = new();
        private readonly Die _die2 = new();
        private const int InitialFunds = 1500;

        public void Setup(int numOfPlayers)
        {
            if (numOfPlayers < 2 || numOfPlayers > 8) 
            {
                throw new ArgumentException(nameof(numOfPlayers));
            }

            Players.Clear();

            Square firstSquare = Board.getFirstSquare();

            for (int i = 0; i < numOfPlayers; i++)
            {
                Players.Add(new Player(_tokens[i], firstSquare, InitialFunds));
            }
        }

        public void PlayRounds(int numRounds)
        {
            for (int round = 0; round < numRounds; round++)
            {
                PlayRound(round);
            }
        }

        private void PlayRound(int round)
        {
            foreach (Player player in Players)
            {
                player.TakeTurn(_die1, _die2);
            }
        }
    }
}