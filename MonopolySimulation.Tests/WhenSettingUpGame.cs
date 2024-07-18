namespace MonopolySimulation.Tests
{
    public class WhenSettingUpGame
    {

        private MonopolyGame _game;
        string[] tokens;
        IList<Player> _players;
        int _numOfPlayers = 8;

        public WhenSettingUpGame(int playersWanted = 8)
        {
            // arrange
            _game = new();

            tokens = ["dog", "sports car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];
            _game.Setup(playersWanted);
            

            // act
            _players = _game.Players;
        }

        [Fact]
        public void ShouldHaveCorrectNumberOfPlayers()
        {
            // arrange
            
            // act
                        
            // assert
            Assert.Equal(_numOfPlayers, _game.PlayerCount);
        }

        [Fact]
        public void ShouldNotAllowLessThan2Players()
        {
            // arrange

            // act

            // assert
            Assert.Throws<ArgumentException>(() => _game.Setup(1));

        }
        [Fact]
        public void ShouldNotAllowMoreThan8Players()
        {

            // assert
            Assert.Throws<ArgumentException>(() => _game.Setup(9));
        }

        [Fact]
        public void ShouldHaveCorrectTokens()
        {

            
            // assert
            for (int i=0; i<tokens.Count(); i++)
            {
                Assert.Equal(tokens[i], _players[i].Token);
            }
        }

        [Fact]
        public void ShouldHave40Squares()
        {
            //arrange
            int monopolySquares = 40;
            //act

            // assert
            Assert.Equal(_game.Board.Squares.Count, monopolySquares);
        }

        [Fact]
        public void ShouldStartPlayersOnFirstSquare()
        {
            // arrange
            // act // assert
            for (int i = 0; i < _players.Count; i++)
            {
                Assert.Equal(_game.Players[i].CurrentSquare, _game.Board.Squares[0] );
            }
        }

        [Fact]
        public void ShouldStartPlayersWith1500()
        {
            // arrange
            int initialFunds = 1500;

            // act // assert
            for (int i = 0; i < _players.Count; i++)
            {
                Assert.Equal(_game.Players[i].Funds , initialFunds);
            }
            
        }

      
    }
}