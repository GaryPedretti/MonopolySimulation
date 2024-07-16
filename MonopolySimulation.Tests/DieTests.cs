namespace MonopolySimulation.Tests
{
    public class DieTests
    {
        [Fact]
        public void FaceValue_ShouldReadBetweenOneAndSix_WhenDieIsRolled()
        {
            // arrange
            Die d = new();

            for (int i = 0; i < 1000; i++)
            {
                // act
                d.Roll();

                // assert
                Assert.InRange(d.FaceValue, 1, 6);
            }

        }

        [Fact]
        public void FaceValue_HasValue_Always()
        {
            Die d = new();

            Assert.InRange(d.FaceValue, 1, 6);

        }

        [Fact]
        public void FaceValue_IsActuallyRandom_AcrossOneHundredRolls()
        {

        }
    }
}