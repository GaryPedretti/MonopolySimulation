using MonopolySimulation;

namespace MonopolySimulationTests
{
    public class DieTests
    {
        [Fact]
        public void FaceValueShouldBeBetweenOneAndSix_WhenDieIsRolled()
        {
            //arrange
            Die d = new();
            //act
            d.Roll();

            //assert
            Assert.True(d.FaceValue > 0);
            Assert.InRange(d.FaceValue, 1, 6);
        }

        [Fact]
        public void FaceValue_HasValue_Always()
        {
            //arrange
            Die d = new();
            //act

            //assert
            Assert.InRange(d.FaceValue, 1, 6);
        }
    }
}