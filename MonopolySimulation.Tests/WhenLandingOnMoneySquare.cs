using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation.Tests
{
    public class WhenLandingOnMoneySquare
    {
        

        [Fact]
        public void ShouldGet200WhenLandingOnGo()
        {
            // arrange
            var board = new Board();
            var player = new Player();
            player.Create(1);
            board.AssignFirstSquare(player);

            // act
            board.Squares[0].LandedOn(player);

            // assert
            // Assert.Equal(player.Funds + 200, 'Blah');
        }
    }
}
