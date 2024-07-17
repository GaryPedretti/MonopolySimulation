using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation.Tests
{
    public class WhenLandingOnMoneySquare
    {
        private MonopolyGame _game;
        string[] _tokens;
        IList<Player> _players;
        int _numOfPlayers;

        public WhenLandingOnMoneySquare()
        {
            _game = new();
            _tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];
            _numOfPlayers = 8;
            _game.Setup(_numOfPlayers, _tokens);
            _game.PlayRounds(1);
            _players = _game.Players!;
        }

        [Fact]
        public void ShouldGet200WhenLandingOnGo()
        {
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player(board.Squares[37], "BLAH");
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);
            var originalAmount = player.CashAmount;
            
            //act
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount + 200);
        }


        [Fact]
        public void ShouldGet200WhenPassingGo()
        {
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player(board.Squares[37], "BLAH");
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);
            var originalAmount = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount + 200);
        }

        [Fact]
        public void ShouldNotDoubleDipOnGo()
        {
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player(board.Squares[37], "BLAH");
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);
            var originalAmount = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount + 200);
        }

    }
}
