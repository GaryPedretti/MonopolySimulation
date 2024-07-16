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

        [Fact]
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

        [Fact]
        public void ShouldHave40Squares()
        {
            Assert.Equal(40, game.Squares.Count);
        }

        [Fact]
        public void ShouldStartPlayersOnFirstSquare()
        {
            foreach(var player in players)
            {
                //Assert.True(p.BoardPosition == 0, string.Format(""));
                Assert.True(player.CurrentSquare == game.Squares[0], string.Format("Player {0} started on first square", player.Token));
            }
        }

        [Fact]
        public void ShouldStartPlayersWith1500()
        {
            foreach (var player in players)
            {
                Assert.True(player.CashAmount == 1500, string.Format("Player {0} started with {1}", player.Token, player.CashAmount));
            }
        }
    }
}
