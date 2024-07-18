
using System.Runtime;

namespace MonopolySimulation
{
    public class Player
    {
        public string Token { get; set; }
        public int Funds { get; set; }
        public Square CurrentSquare { get; set; }

        private string[] _tokens = ["dog", "sports car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];

        public IList<Player> Create(int numPlayers)
        {
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

        internal void TakeTurn(Die die1, Die die2)
        {
            die1.Roll();
            die2.Roll();
            var diceTotal = die1.FaceValue + die2.FaceValue;

            for (int i = 0; i < diceTotal; i++)
            {
                CurrentSquare.NextSquare();
            }
        }
    }
}