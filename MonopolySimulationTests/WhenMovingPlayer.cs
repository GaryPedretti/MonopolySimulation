using MonopolySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulationTests
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
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[0]);
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
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[39]);
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2);

            //assert
            Assert.Equal(board.Squares[2], player.CurrentSquare);
        }
    }
}
