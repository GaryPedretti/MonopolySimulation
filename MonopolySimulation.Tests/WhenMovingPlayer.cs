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

        [Fact]
        public void ShouldMoveCorrectNumberOfSquares()
        {
            // Arrange
            Board board = new();
            Player player = new("crash test dummy", board.getFirstSquare(), 1);
            Die loadedDie1 = new LoadedDie(4);
            Die loadedDie2 = new LoadedDie(3);
            Square expectedSquare = board.getFirstSquare();
            for (int i = 0; i < 7; i++)
            {
                expectedSquare = expectedSquare.NextSquare;
            }

            // Act
            player.TakeTurn(loadedDie1, loadedDie2);

            // Assert
            Assert.Equal(expectedSquare, player.CurrentSquare);
        }

        [Fact]
        public void ShouldRoundTheBoard()
        {
            // Arrange
            Board board = new();
            Player player = new("crash test dummy", board.getFirstSquare(), 1);
            Die loadedDie1 = new LoadedDie(20);
            Die loadedDie2 = new LoadedDie(20);
            Square expectedSquare = board.getFirstSquare();

            // Act
            player.TakeTurn(loadedDie1, loadedDie2);

            // Assert
            Assert.Equal(expectedSquare, player.CurrentSquare);
        }
    }
}
