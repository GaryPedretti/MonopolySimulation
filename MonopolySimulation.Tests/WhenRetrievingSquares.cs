namespace MonopolySimulation.Tests
{
    public class WhenRetrievingSquares
    {
        private readonly IList<string> _expectedSquares = [
            "Go", "Mediterranean Avenue",
            "Community Chest", "Baltic Avenue", "Income Tax", "Reading Railroad",
            "Oriental Avenue", "Chance", "Vermont Avenue", "Connecticut Avenue",
            "Jail", "St. Charles Place", "Electric Company", "States Avenue",
            "Virginia Avenue", "Pennsylvania Railroad", "St. James Place",
            "Community Chest", "Tennessee Avenue", "New York Avenue", "Free Parking",
            "Kentucky Avenue", "Chance", "Indiana Avenue", "Illinois Avenue",
            "B & O Railroad", "Atlantic Avenue", "Ventor Avenue", "Water Works",
            "Marvin Gardens", "Go To Jail", "Pacific Avenue", "North Carolina Avenue",
            "Community Chest", "Pennsylvania Avenue", "Short Line Railroad",
            "Chance", "Park Place", "Luxury Tax", "Boardwalk"
        ];

        // Arrange
        private ISquareRepository _squareRepository;
        private IList<Square> _squares;

        public WhenRetrievingSquares()
        {
            _squareRepository = new MonopolySquareRepository();
            _squares = _squareRepository.GetAllSquares();
        }

        [Fact]
        public void ShouldHave40Squares()
        {
            // Assert
            Assert.Equal(40, _squares.Count);
        }

        [Fact]
        public void ShouldAllSquaresHaveNames()
        {
            // Assert
            Assert.All(_squares, (square) =>
            {
                Assert.False(string.IsNullOrWhiteSpace(square.Name));
            });
        }

        [Fact]
        public void ShouldAllSquaresHaveCorrectNames()
        {
            // Assert
            Assert.All(_expectedSquares, (expectedSquareName, idx) =>
            {
                Assert.Equal(expectedSquareName, _squares[idx].Name);
            });
        }
    }
}
