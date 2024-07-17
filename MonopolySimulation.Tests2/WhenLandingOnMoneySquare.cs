using System.Runtime.CompilerServices;

namespace MonopolySimulation.Tests2
{
    public class WhenLandingOnMoneySquare
    {
        private MonopolyGame _game;
        string[] _tokens;
        IList<Player> _players;
        int _numOfPlayers;

        public WhenLandingOnMoneySquare()
        {
            _game = new();
            _tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];
            _numOfPlayers = 8;
            _game.Setup(_numOfPlayers);
            _players = _game.Players;
        }

        [Fact]
        public void ShouldGet200WhenLandingOnGo()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Park Place to start
            Player player = new Player(board.Squares[37], "BLAH");
            int amountBefore = player.CashAmount;

            // 3 squares beyond Park Place is Go
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);
            
            //act
            player.TakeTurn(die1, die2); 

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore + 200, amountAfter);
        }

        [Fact]
        public void ShouldGet200WhenPassingGo()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Park Place to start
            Player player = new Player(board.Squares[37], "BLAH");
            int amountBefore = player.CashAmount;

            // 4 squares beyond Park Place is Meditteranean Ave
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2); 

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore + 200, amountAfter);
        }
        [Fact]
        public void ShouldNotDoubleDipOnGo()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Park Place to start
            Player player = new Player(board.Squares[37], "BLAH");
            int amountBefore = player.CashAmount;

            // 3 squares beyond Park Place is Go
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(1);

            // first take a turn to land on Go:
            player.TakeTurn(die1, die2); 

            //act
            // now move beyond Go
            player.TakeTurn(die1, die2);
            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore + 200, amountAfter);
        }
        [Fact]
        public void ShouldPay75onLuxurySquare()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Short Line RR to start
            Player player = new Player(board.Squares[35], "BLAH");
            int amountBefore = player.CashAmount;

            // 3 squares beyond ShortLine is Lux Tax
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(1);

            //act
            player.TakeTurn(die1, die2); 

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore - 75, amountAfter);
        }
        [Fact]
        public void ShouldNotPay75WhenPassingLuxurySquare()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Short Line RR to start
            Player player = new Player(board.Squares[35], "BLAH");
            int amountBefore = player.CashAmount;

            // 4 squares beyond ShortLine is Boardwalk
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2); 

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore, amountAfter);
        }
        [Fact]
        public void ShouldPay200OnIncomeTaxSquareWhenRich()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Go to start
            Player player = new Player(board.Squares[0], "BLAH");
            int amountBefore = 2500;
            player.CashAmount = amountBefore;

            // 4 squares beyond Go is Income Tax
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2); 

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore - 200, amountAfter);
        }
        [Fact]
        public void ShouldPay10PercentOnIncomeTaxSquareWhenPoor()
        {
            //arrange
            MonopolyBoard board = new MonopolyBoard();
            // player setup on Go to start
            Player player = new Player(board.Squares[0], "BLAH");
            int amountBefore = 980;
            player.CashAmount = amountBefore;

            // 4 squares beyond Go is Income Tax
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);

            //act
            player.TakeTurn(die1, die2);

            //assert
            int amountAfter = player.CashAmount;
            Assert.Equal(amountBefore - 98, amountAfter);
        }

    }
}