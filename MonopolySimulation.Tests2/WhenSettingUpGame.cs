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

        [Fact(Skip = "Not implemented yet")]
        public void ShouldNotAllowLessThan2Players()
        {

        }

        [Fact(Skip = "Not implemented yet")]
        public void ShouldNotAllowMoreThan8Players()
        {

        }

        [Fact]
        public void ShouldHaveCorrectTokens()
        {
            for (int i = 0; i < _tokens.Count(); i++)
            {
                Assert.Equal(_players[i].Token, _tokens[i]);
            }
        }

        [Fact(Skip = "Not implemented yet")]
        public void ShouldHave40Squares()
        {

        }

        [Fact(Skip = "Not implemented yet")]
        public void ShouldStartPlayersOnFirstSquare()
        {

        }

        [Fact(Skip = "Not implemented yet")]
        public void ShouldStartPlayersWith1500()
        {

        }
    }
}