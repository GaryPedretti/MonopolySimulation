namespace MonopolySimulation
{
    public class Player
    {
        public string Token { get; set; }
        public int Funds { get; set; }

        private string[] _tokens = ["dog", "sports car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];

        public IList<Player> Create(int numPlayers) {
            var players = new List<Player>();

            for (int i = 0; i < numPlayers; i++)
            {
                var player = new Player();
                player.Token = _tokens[i];
                player.Funds = 1500;
                players.Add(player);
            }
            return players;
        }
    }
}