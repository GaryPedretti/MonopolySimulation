using System.Runtime.CompilerServices;

namespace MonopolySimulation.Tests
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
            _game.Setup(_numOfPlayers, _tokens);
            _game.PlayRounds(1);
            _players = _game.Players!;
        }

        [Fact]
        public void ShouldBeOnDifferentSquareAfterMove()
        {
            var game = new MonopolyGame();
            game.Setup(2, new string[] { "a", "b" });
            game.PlayRounds(1);
            var firstSquare = _game.Squares.First();

            foreach (Player p in _game.Players!)
            {
                Assert.True(p.CurrentSquare != firstSquare);
            }
        }

        [Fact]
        public void ShouldMoveCorrectNumberOfSquares()
        {
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player(board.Squares[0], "BLAH");        
            Die die1 = new LoadedDie(4);
            Die die2 = new LoadedDie(3);

            //act
            player.TakeTurn(die1, die2);

            // assert
            Assert.Equal(board.Squares[7], player.CurrentSquare);

        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldRoundTheBoard()
        {
            //
        }
    }
}