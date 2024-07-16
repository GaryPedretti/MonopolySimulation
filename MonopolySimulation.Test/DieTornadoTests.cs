using NuGet.Frameworks;

namespace MonopolySimulation.Test
{
    public class WhenRollingMultipleDice
    {
        DiceTornado dt;

        public WhenRollingMultipleDice() { 
            // anything in here is essentially a "Give" clause
            dt = new DiceTornado();

        }
        
        [Fact]
        public void ShouldHaveTotalBetweenNumOfDiceAndNumAndNumOfDiceTimesSix()
        {
            // arrange
            // DiceTornado dt = new();
            int numOfDice = 2;

            // act
           int actual = dt.Spin(numOfDice);

            // assert
            // lowest possible result: all ones
            Assert.InRange(actual, numOfDice, (numOfDice * 6));

        }
        [Fact]
        public void ShouldChangeValueAfterMultipleRolls()
        {
            // arrange
            DiceTornado dt = new();
            int numOfDice = 2;
            int dieValue1 = dt.Spin(numOfDice);
            int dieValue2= dt.Spin(numOfDice);
            bool rollWasDifferent = false;

            // act
            for (int i = 0; i < 1000; i++)
            {
           
                rollWasDifferent = (dieValue1 != dieValue2);
                if (rollWasDifferent)
                {
                    break;
                }
                // roll only 1 of the dice?
                dieValue1 = dt.Spin(numOfDice);
                //currentValue = dt.Spin(numOfDice);

            }

            // assert
            Assert.True(rollWasDifferent);
        }

        [Fact]
        public void ShouldThrowExcepetionWhenInvalidNumberOfDice ()
        {
            int actual = dt.Spin(0);
        }
    }
}