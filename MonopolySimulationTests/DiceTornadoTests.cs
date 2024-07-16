using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation.Test
{
    public class WhenRollingMultipleDice //DiceTornedoTests
    {
        DiceTornedo dt;
        public WhenRollingMultipleDice()
        {
            dt = new DiceTornedo();
        }

        [Fact]
        public void ShouldHavetotalBetweenNumOfDiceAndNumOfDiceTimeSix()
        {
            //arrange
            // DiceTornedo dt = new();
            int numOfDice = 2;

            //act
            int actual = dt.Spin(numOfDice);

            //assert

            //Assert.True(actual >= numOfDice);

            Assert.InRange(actual, numOfDice, (numOfDice * 6));
        }

        [Fact]
        public void ShouldChangeValueAfterMultipleSpin()
        {

            int numOfDice = 2;
            int dieValue1 = dt.Spin(numOfDice);
            int dieValue2 = dt.Spin(numOfDice);
            bool rollwasDifferent = false;
            for (int i = 0; i < 1000; i++)
            {
                rollwasDifferent = (dieValue1 != dieValue2);
                if (rollwasDifferent)
                {
                    break;
                }
                dieValue1 = dt.Spin(numOfDice);
                // dieValue2 = d.Spin(numOfDice);
            }
            Assert.True(rollwasDifferent);
        }

        [Fact]
        public void ShouldThrowExceptionWhenInvalidNumOfDice()
        {
            //Assert.Throws(typeof(System.ArgumentException), () => dt.Spin(0));
            Assert.Throws<System.ArgumentException>(() => dt.Spin(0));

        }
    }
}
