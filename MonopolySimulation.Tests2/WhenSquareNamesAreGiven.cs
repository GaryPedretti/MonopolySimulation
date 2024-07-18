using System.Runtime.CompilerServices;

namespace MonopolySimulation.Tests2
{
    public class WhenSquareNamesAreGiven
    {
        
        private static readonly string[] _propertyNames = { "Go", "Mediterranean Avenue",
            "Community Chest", "Baltic Avenue", "Income Tax", "Reading Railroad",
            "Oriental Avenue", "Chance", "Vermont Avenue", "Connecticut Avenue",
            "Jail", "St. Charles Place", "Electric Company", "States Avenue",
            "Virginia Avenue", "Pennsylvania Railroad", "St. James Place",
            "Community Chest", "Tennessee Avenue", "New York Avenue", "Free Parking",
            "Kentucky Avenue", "Chance", "Indiana Avenue", "Illinois Avenue",
            "B & O Railroad", "Atlantic Avenue", "Ventor Avenue", "Water Works",
            "Marvin Gardens", "Go To Jail", "Pacific Avenue", "North Carolina Avenue",
            "Community Chest", "Pennsylvania Avenue", "Short Line Railroad",
            "Chance", "Park Place", "Luxury Tax", "Boardwalk"};


        private ISquareFileDao _squareFileDao;
        public WhenSquareNamesAreGiven()
        {
            _squareFileDao = new SquareHardcodedFileDao();
        }

        [Fact]
        public void ShouldHaveSqureHaveName()
        {
            // arrange

           
            List<Square> squares = new List<Square>();

            for (int i = 0; i < 40; i++)
            {
                Square sqaure= _squareFileDao.CreateSquare(i);
                squares.Add(sqaure);
            }
            for (int i = 0; i < 40; i++)
            {
                Assert.Equal(_propertyNames[i], squares[i].Name);
            }

        }

        
    }
}