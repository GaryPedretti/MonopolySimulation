using MonopolySimulation;

namespace MonopolySimulationTests
{
    public class DiceTornadoTests
    {
        [Fact]
        public void TestSpin()
        {
            DiceTornado dt = new ();
            int numOfDice = 2;

            int actual = dt.Spin(numOfDice);

            Assert.True(actual >= numOfDice);
        }

        [Fact]
        public void MultipleSpinsShouldNotBeEqual()
        {
            DiceTornado dt = new();
            int numOfDice = 2;
            bool rolledDifferent = false;

            for (int i = 0; i < 1000; i++)
            {
                int actual = dt.Spin(numOfDice);
                int actual2 = dt.Spin(numOfDice);

                if (actual != actual2)
                {
                    rolledDifferent = true;
                    break;
                }
            }

            Assert.True(rolledDifferent);
        }
    }
}