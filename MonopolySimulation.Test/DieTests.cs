using NuGet.Frameworks;

namespace MonopolySimulation.Test
{
    public class DieTests
    {
        [Fact]
        public void FaceValue_ShouldReadBetweenOneAndSix_WhenDieIsRolled()
        {
            // arrange
            Die d = new();

            // act
            d.Roll();

            // assert
            Assert.InRange(d.FaceValue, 1, 6);

        }

        [Fact]
        public void FaceValue_HasValue_Always()
        {
            // arrange
            Die d = new();

            // act

            // assert
            Assert.InRange(d.FaceValue, 1, 6);
        }

        [Fact]
        public void FaceValue_IsActuallyRandom_AcrossOneHundredRolls()
        {
            // arrange
            Die die = new();

            // act

            // assert
        }
    }
}