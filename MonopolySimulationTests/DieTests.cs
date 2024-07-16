using MonopolySimulation;

namespace MonopolySimulationTests
{
    public class DieTests
    {
        [Fact]
        public void FaceValue_ShouldReadBetweenOneAndSix_WhenDieIsRolled()
        {
            Die d = new Die();

            d.Roll();

            Assert.InRange(d.FaceValue, 1, 6);
        }

        [Fact]
        public void FaceValue_HasValue_Always()
        {
            Die d = new Die();

            Assert.InRange(d.FaceValue, 1, 6);
        }

        [Fact]
        public void FaceValue_IsActuallyRandom_Across100Rolls()
        {
            Die d = new Die();

            Assert.InRange(d.FaceValue, 1, 6);
        }
    }
}