

namespace MonopolySimulation
{
    public class Player
    {
        public string Token { get; private set; }
        public int CashAmount { get; set; }
        public Square CurrentSquare { get; set; }

        public Player(Square currentSquare, string token)
        {
            Token = token;
            CashAmount = 1500;
            CurrentSquare = currentSquare;
        }

        public void TakeTurn(Die die1, Die die2)
        {
            die1.Roll();
            die2.Roll();
            var numOfSquares = die1.FaceValue + die2.FaceValue;

            for (int i = 0; i < numOfSquares; i++) {
                this.CurrentSquare = this.CurrentSquare.Next;

            }

            this.CurrentSquare.LandedOn(this);
        }
    }
}