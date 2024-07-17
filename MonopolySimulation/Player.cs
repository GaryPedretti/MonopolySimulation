

namespace MonopolySimulation
{
    public class Player
    {
        public string Token { get; private set; }
        public int CashAmount { get; private set; }
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
            for (int i = 0; i < (die1.FaceValue + die2.FaceValue); i++)
            {
                CurrentSquare = CurrentSquare.NextSquare;
            }
        }
    }
}