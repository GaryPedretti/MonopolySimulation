using MonopolySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulationTests
{
    public class WhenSettingUpGame
    {
        private MonopolyGame game = new();
        string[] tokens;
        IList<Player> players;
        int numOfPlayers;

        public WhenSettingUpGame(){
            game = new();

            tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];

            numOfPlayers = tokens.Count();

            game.Setup(numOfPlayers);

            players = game.Players;
        }
        [Fact]
        public void ShouldHaveCorrectNumberOfPlayers()
        {
            //arrange
            //int numOfPlayers = 8;

            //act

            //assert
            Assert.Equal(numOfPlayers, game.PlayerCount);
        }

        [Fact]
        public void ShouldNotAllowLessThan2Players()
        {
            MonopolyGame g1 = new MonopolyGame();
           // g1.Setup(1);

            Assert.Throws<ArgumentException>(() => g1.Setup(1));
        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldNotAllowMoreThan8Players()
        {
            MonopolyGame g1 = new MonopolyGame();

            Assert.Throws<ArgumentException>(() => g1.Setup(9));
        }

        [Fact]
        public void ShouldHaveCorrectTokens()
        {

            //assert;
            for(int i=0; i<tokens.Count(); i++)
            {
                string temp = players[i].Token;
                string temp2 = tokens[i];
                Assert.Equal(temp2, temp);
            }

        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldHave40Squares()
        {

        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldStartPlayersOnFirstSquare()
        {

        }

        [Fact(Skip = "not implemented yet")]
        public void ShouldStartPlayersWith1500()
        {

        }
    }
}
