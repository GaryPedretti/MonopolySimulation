namespace MonopolySimulation.Tests
{
    public class WhenSettingUpGame
    {
        private readonly MonopolyGame _game;
        private readonly string[] _tokens = ["dog", "top hat", "race car", "thimble", "iron", "battleship", "cat", "penguin"];
        private readonly IList<Player> _players;
        private const int numOfPlayers = 8;
        private readonly Board _board;

        public WhenSettingUpGame() {
            //arrange
            _game = new();
            _game.Setup(numOfPlayers);
            _players = _game.Players;
            _board = _game.Board;
            //act
        }

        [Fact]
        public void ShouldHaveCorrectNumberOfPlayers()
        {
            //assert
            Assert.Equal(numOfPlayers, _game.PlayerCount);

        }
        [Fact]

        public void ShouldNotAllowMoreThan8Players()
        {
            Assert.Throws<ArgumentException>(() => _game.Setup(9));
        
        }

        [Fact]

        public void ShouldNotAllowLessThan2Players()
        {
            Assert.Throws<ArgumentException>(() => _game.Setup(1));
        }

        [Fact]

        public void ShouldHaveCorectTokens()
        {

                       

            //assert
            for(int i = 0; i < _tokens.Count(); i++)
            {
                Assert.Equal(_tokens[i], _players[i].Token);
            }

        }

        [Fact]

        public void ShouldHave40Squares()
        {
            // Assert
            Assert.Equal(40, _board.getCountOfSquares());
        }

        [Fact]

        public void ShouldStartPlayersOnFirstSquare()
        {
            //Arrange
            var firstSquare = _board.getFirstSquare();

            //Act

            //Assert
            foreach (var player in _players)
            {
                Assert.Equal(firstSquare, player.CurrentSquare);
            }
        }

        [Fact]

        public void ShouldStartPlayerswith1500()
        {
            foreach (var player in _players)
            {
                Assert.Equal(1500, player.Funds);
            }
        }
    }
}
