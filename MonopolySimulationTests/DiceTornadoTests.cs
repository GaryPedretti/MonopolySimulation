using MonopolySimulation;
using System.Security.Cryptography.X509Certificates;

namespace MonopolySimulationTests
{
    public class WhenRollingMultipleDice
    {
        DiceTornado dt = new();
        public WhenRollingMultipleDice() { 
            //anything in here is "Given"

        }

        [Fact]
        public void ShouldHaveTotalBetwenNumOfDiceAndNumberOfDiceTimesSix()
        {
            //arrange
            //DiceTornado dt = new();
            int numOfDice = 2;

            //act
            int actual = dt.Spin(numOfDice);

            //lowest possible result: all ones, highest: all sixes
            //Assert.True(actual >= numOfDice);
            Assert.InRange(actual, numOfDice, numOfDice*6);
        }

        [Fact]
        public void ShouldChangeValueAfterMultipleRolls()
        {
            //DiceTornado dt = new();
            int numOfDice = 2;
            int dieValue1 = dt.Spin(numOfDice);
            int dieValue2 = dt.Spin(numOfDice);
            bool rollWasDifferent = false;

            for(int i = 0; i < 1000; i++)
            {
                rollWasDifferent = dieValue1 != dieValue2;
                if (rollWasDifferent)
                {
                    break;
                }
                dieValue1 = dt.Spin(numOfDice);
                //currentValue = dt.Spin(numOfDice);
            }
            Assert.True(rollWasDifferent);
        }

        [Fact]
        public void ShouldThrowExceptionWhenInvalidNumberOfRolls()
        {
           // int actual = dt.Spin(0);
            Assert.Throws<ArgumentException>(() => dt.Spin(0));
        }
    }
}
