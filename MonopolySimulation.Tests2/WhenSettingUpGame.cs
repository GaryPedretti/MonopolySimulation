using System.Runtime.CompilerServices;

namespace MonopolySimulation.Tests2
{
    public class WhenSettingUpGame
    {
        private MonopolyGame _game;
        string[] _tokens;
        IList<Player> _players;
        int _numOfPlayers;

        public WhenSettingUpGame()
        {
            _game = new();
            _tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];
            _numOfPlayers = 8;
            _game.Setup(_numOfPlayers);
            _players = _game.Players;
        }
        [Fact]
        public void ShouldHaveCorrectNumberOfPlayers()
        {
            // assert
            Assert.Equal(_numOfPlayers, _game.PlayerCount);
        }
        [Fact]
        public void ShouldHaveCorrectTokens()
        {
            // assert
            for (int i = 0; i < _tokens.Count(); i++)
            {
                Assert.Equal(_tokens[i], _players[i].Token);
            }
        }

        [Fact]
        public void ShouldNotAllowLessThan2Players()
        {
            // act
            // need to call Setup again for a < 2
            Assert.Throws<System.ArgumentException>(() => _game.Setup(1));
        }

        [Fact]
        public void ShouldNotAllowMoreThan8Players()
        {
            // act
            // need to call Setup again for a > 8
            Assert.Throws<System.ArgumentException>(() => _game.Setup(9));
        }

        [Fact]
        public void ShouldHave40Squares()
        {
            Assert.Equal(40, _game.Squares.Count);
        }
        [Fact]
        public void ShouldStartPlayersOnFirstSquare()
        {
            foreach(Player p in _players)
            {
                Assert.True(p.CurrentSquare == _game.Squares[0], string.Format( "Player {0} is not on the first square.", p.Token));
            }
        }

        [Fact]
        public void ShouldStartPlayersWith1500()
        {
            foreach (Player p in _players)
            {
                Assert.True(p.CashAmount == 1500, string.Format("Player {0} does not have $1,500 (actually has ${1}).", p.Token, p.CashAmount));
            }
        }
    }
}