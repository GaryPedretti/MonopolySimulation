using MonopolySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulationTests
{
    public class WhenLandingOnTheSquare
    {
        private MonopolyGame _game;
        string[] _tokens;
        IList<Player> _players;
        int _numOfPlayers;

        public WhenLandingOnTheSquare()
        {
            _game = new();
            _tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];
            _numOfPlayers = 8;
            _game.Setup(_numOfPlayers);
            _players = _game.Players;
        }

        [Fact]
        public void ShouldGet200WhenLandingOnGo()
        {
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[37]);

            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);
            int amountBefore = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);

            int amountAfter = player.CashAmount;


            //assert
            Assert.Equal(200, amountAfter - amountBefore);
        }

        [Fact]
        public void ShouldGet200WhenPassingGo()
        {
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[37]);

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);
            int amountBefore = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);
            int amountAfter = player.CashAmount;


            //assert
            Assert.Equal(200, amountAfter - amountBefore);
        }

        [Fact]
        public void ShouldNotDoubleDipOnGo()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[37]);
            int amountBefore = player.CashAmount;

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(1);

            player.TakeTurn(die1, die2);

            //land after go
            player.TakeTurn(die1, die2);

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(200, amountAfter - amountBefore);
        }
        [Fact]
        public void ShouldPay75onLuxurySquare()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[35]);
            int amountBefore = player.CashAmount;

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(1);

            //act
            player.TakeTurn(die1, die2);

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore - 75, amountAfter);
        }
        [Fact]
        public void ShouldNotPay75WhenPassingLuxurySquare()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[35]);
            int amountBefore = player.CashAmount;

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2);

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore, amountAfter);
        }
        [Fact]
        public void ShouldPay200OnIncomeTaxSquareWhenRich()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[0]);
            int amountBefore = player.CashAmount * 2;
            player.CashAmount = amountBefore;

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2);

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore - 200, amountAfter);
        }
        [Fact]
        public void ShouldPay10PercentOnIncomeTaxSquareWhenPoor()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            Player player = new Player("Blah", board.Squares[0]);
            int amountBefore = 980;
            player.CashAmount = amountBefore;

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2);

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore - 98, amountAfter);
        }

    }
}
