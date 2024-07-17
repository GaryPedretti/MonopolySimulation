namespace MonopolySimulation.Tests
{
    public class WhenMovingPlayer
    {
        private readonly MonopolyGame _game;
        private readonly IList<Player> _players;
        private const int numOfPlayers = 8;
        private readonly Board _board;
        private Square _firstSquare;

        public WhenMovingPlayer()
        {
            //arrange
            _game = new();
            _game.Setup(numOfPlayers);
            _players = _game.Players;
            _board = _game.Board;
            _firstSquare = _board.getFirstSquare();
            //act
        }

        [Fact]
        public void ShouldHavePlayerMove()
        {
            // Arrange

            // Act
            _game.PlayRounds(1);

            // Assert
            foreach (var player in _players)
            {
                Assert.NotEqual(_firstSquare, player.CurrentSquare);
            }
        }

        [Fact(Skip = "TODO")]
        public void ShouldMoveCorrectNumberOfSquares()
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact(Skip = "TODO")]
        public void ShouldRoundTheBoard()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
