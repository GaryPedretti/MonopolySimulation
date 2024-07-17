namespace MonopolySimulation.Tests2
{
    public class WhenMovingPlayers
    {
        private Game _game;
        private IList<string> _tokens;
        private IList<Player> _players;
        private int _playerCount;

        public WhenMovingPlayers()
        {
            _playerCount = 8;
            _game = new();
            _game.Setup(numberOfPlayers: _playerCount);

            Token token = new();
            _tokens = token.Tokens;

            _players = _game.Players;
        }

        [Fact]
        public void ShouldHavePlayerMove()
        {
            var startingPosition = _players[0].CurrentPosition;

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(5);
            _players[0].TakeTurn(die1, die2);

            Assert.NotEqual(startingPosition, _players[0].CurrentPosition);
        }

        [Fact]
        public void ShouldHaveMoveCorrectNumberIfSquare()
        {
            var startingPosition = _players[0].CurrentPosition;

            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(5);
            _players[0].TakeTurn(die1, die2);

            Assert.Equal(startingPosition + 7, _players[0].CurrentPosition);
        }

        [Fact]
        public void ShouldRoundTheBoard()
        {

        }
    }
}