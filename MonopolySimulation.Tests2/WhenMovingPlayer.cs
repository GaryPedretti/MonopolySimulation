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

        [Fact]
        public void ShouldBeOnDifferentSquareAfterMove()
        {
            _game.PlayRounds(1);
            foreach (Player player in _players)
            {
                Assert.NotEqual(player.CurrentSquare, _game.Squares[0]);
            }

        }

        [Fact]
        public void ShouldMoveCorrectNumberOfSquares()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player(board.Squares[0],"BLAH");

            Die die1 = new LoadedDie(4);
            Die die2 = new LoadedDie(3);
            //act
            player.TakeTurn(die1, die2);

            //assert
            Assert.Equal(board.Squares[7], player.CurrentSquare);
        }

        [Fact]
        public void ShouldRoundTheBoard()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Boardwalk to start
            Player player = new Player(board.Squares[39], "BLAH");

            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);
            //act
            player.TakeTurn(die1, die2);

            //assert
            // wound past boardwalk to go and beyond
            Assert.Equal(board.Squares[2], player.CurrentSquare);
        }
    }
}