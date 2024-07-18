namespace MonopolySimulation.Tests
{
    public class WhenLandingOnSpecialtySquares
    {
        private const int _initialRichFunds = 2500;
        private const int _initialPoorFunds = 1500;
        private readonly Board _board = new Board();

        private readonly Player _richPlayer;
        private readonly Player _poorPlayer;

        public WhenLandingOnSpecialtySquares()
        {
            //arrange
            _richPlayer = new Player("top hat", _board.getFirstSquare(), _initialRichFunds);
            _poorPlayer = new Player("dog", _board.getFirstSquare(), _initialPoorFunds);
        }

        [Fact]
        public void ShouldGet200WhenLandingOnGo()
        {
            // Arrange
            Die die1 = new LoadedDie([22]);
            Die die2 = new LoadedDie([18]);

            // Act
            _richPlayer.TakeTurn(die1, die2);

            // Assert
            Assert.Equal(_initialRichFunds + 200, _richPlayer.Funds);
        }

        [Fact]
        public void ShouldGet200WhenPassingGo()
        {
            //Arrange
            Die die1 = new LoadedDie([23]);
            Die die2 = new LoadedDie([19]);

            //Act
            _richPlayer.TakeTurn(die1, die2);


            //Assert
            Assert.Equal(_initialRichFunds + 200, _richPlayer.Funds);
        }

        [Fact]
        public void ShouldNotDoubleDipOnGo()
        {
            //Arrange
            Die die1 = new LoadedDie([22, 10]);
            Die die2 = new LoadedDie([18, 19]);

            //Act
            _richPlayer.TakeTurn(die1, die2);
            _richPlayer.TakeTurn(die1, die2);

            //Assert
            Assert.Equal(_initialRichFunds + 200, _richPlayer.Funds);
        }

        [Fact]
        public void ShouldPlay75LandingOnLuxuryTax()
        {
            // Arrange
            Die die1 = new LoadedDie([14]);
            Die die2 = new LoadedDie([24]);

            // Act
            _richPlayer.TakeTurn(die1, die2);

            // Assert
            Assert.Equal(_initialRichFunds - 75, _richPlayer.Funds);
        }

        [Fact]
        public void ShouldNotPay75WhenPassingLuxuryTax()
        {
            // Arrange
            Die die1 = new LoadedDie([14]);
            Die die2 = new LoadedDie([25]);

            // Act
            _richPlayer.TakeTurn(die1, die2);

            // Assert
            Assert.Equal(_initialRichFunds, _richPlayer.Funds);
        }

        [Fact]
        public void ShouldPay200IncomeTaxWhenRich()
        {
            // Arrange
            Die die1 = new LoadedDie([1]);
            Die die2 = new LoadedDie([3]);

            // Act
            _richPlayer.TakeTurn(die1, die2);

            // Assert
            Assert.Equal(_initialRichFunds - 200, _richPlayer.Funds);
        }

        [Fact]
        public void ShouldPay10percentIncomeTaxWhenPoor()
        {
            // Arrange
            Die die1 = new LoadedDie([1]);
            Die die2 = new LoadedDie([3]);

            // Act
            _poorPlayer.TakeTurn(die1, die2);

            // Assert
            Assert.Equal(_initialPoorFunds * 0.90, _poorPlayer.Funds);
        }

    }
}
