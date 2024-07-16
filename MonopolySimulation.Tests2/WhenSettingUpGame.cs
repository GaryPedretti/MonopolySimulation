namespace MonopolySimulation.Tests2
{
    public class WhenSettingUpGame
    {
        private Game _game;
        private IList<string> _tokens;
        private IList<Player> _players;
        private int _playerCount;

        public WhenSettingUpGame()
        {
            _playerCount = 8;
            _game = new();
            _game.Setup(numberOfPlayers: _playerCount);

            Token token = new();
            _tokens = token.Tokens;

            _players = _game.Players;
        }

        [Fact]
        public void ShouldHaveCorrectNumberOfPlayers()
        {
            // Arrange

            // Act

            // Assert
            Assert.Equal(_playerCount, _game.PlayerCount);
        }

        [Fact]
        public void ShouldNotAllowLessThan2Players()
        {
            Game game = new();

            Assert.Throws<System.ArgumentException>(() => game.Setup(1));
        }

        [Fact]
        public void ShouldNotAllowMoreThan8Players()
        {
            Game game = new();
         
            Assert.Throws<System.ArgumentException>(() => game.Setup(9));
        }

        [Fact]
        public void ShouldHaveCorrectTokens()
        {
            for (int i = 0; i < _tokens.Count(); i++)
            {
                Assert.Equal(_players[i].Token, _tokens[i]);
            }
        }

        [Fact]
        public void ShouldHave40Squares()
        {
            Assert.Equal(40, _game.Squares.Count());
        }

        [Fact]
        public void ShouldStartPlayersOnFirstSquare()
        {
            foreach (var player in _game.Players)
            {
                Assert.Equal(0, player.CurrentPosition);
            }
        }

        [Fact(Skip = "Not implemented yet")]
        public void ShouldStartPlayersWith1500()
        {

        }
    }
}