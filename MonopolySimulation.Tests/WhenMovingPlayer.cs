using Newtonsoft.Json.Linq;
using System.Xml.Linq;

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
            _game.Setup(_numOfPlayers);
            _players = _game.Players;
        }

        [Fact]
        public void ShouldBeOnDifferentSquareAfterMove()
        {
            _game.PlayRounds(1);
            foreach (Player player in _players)
            {
                Assert.NotEqual(player.CurrentSquare, _game.Board.Squares[0]);
            }
        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldMoveCorrectNumberOfSquares()
        {
            //// arrange
            //MonopolyBoard board = new MonopolyBoard();
            //Player player = new Player(board.Squares[0], "Blah");

            //Die die1 = new LoadedDie(4);
            //Die die2 = new LoadedDie(3);

            //// act
            //player.TakeTurn(die1, die2);

            //// assert
            //Assert.Equal(board.Squares[7], player.CurrentSquare);

        }

        [Fact(Skip = "not implemented yet")]
        public void shouldroundtheboard()
        {
        //    arrange
        //   monopolyboard board = new monopolyboard();
        //    player setup on boardwalk to start
        //player player = new player(board.squares[39], "blah");

        //    die die1 = new loadeddie(4);
        //    die die2 = new loadeddie(3);

        //    // act
        //    player.taketurn(die1, die2);

        //    // assert
        //    assert.equal(board.squares[39], player.currentsquare);
        }
    }
}
