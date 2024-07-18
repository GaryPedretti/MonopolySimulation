namespace MonopolySimulation.Tests
{
    public class WhenRetrievingSquares
    {
        private readonly IList<string> _expectedSquares = [

        ];

        [Fact]
        public void ShouldAllSquaresHaveNames()
        {
            // Arrange
            ISquareRepository squareRepository = new TraditionalMonopolySquareRepository();

            // Act
            IList<Square> squares = squareRepository.GetAllSquares();

            // Assert
            Assert.All(squares, (square) =>
            {
                Assert.False(string.IsNullOrWhiteSpace(square.Name));
            });
        }

        [Fact]
        public void ShouldAllSquaresHaveCorrectNames()
        {

        }
    }
}
