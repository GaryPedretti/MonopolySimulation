

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

        internal void TakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}