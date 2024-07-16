using System.Runtime.CompilerServices;

namespace MonopolySimulation.Tests2
{
    public class WhenMovingPlayer
    {
        private MonopolyGame _game;
        string[] _tokens;
        IList<Player> _players;
        int _numOfPlayers;

        public WhenMovingPlayer()
        {
            _game = new();
            _tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];
            _numOfPlayers = 8;
            _game.Setup(_numOfPlayers);
            _players = _game.Players;
        }

        [Fact(Skip ="only half implemented")]
        public void ShouldBeOnDifferentSquareAfterMove()
        {
            _game.PlayRounds(1);
            foreach (Player player in _players)
            {
                Assert.NotEqual(player.CurrentSquare, _game.Squares[0]);
            }

        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldMoveCorrectNumberOfSquares()
        {

        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldRoundTheBoard()
        {

        }
    }
}