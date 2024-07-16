
namespace MonopolySimulation
{
    public class Player
    {
        public Player (string token, Square currentSquare)
        {
            _token = token;
            CashAmount = 1500;
            CurrentSquare = currentSquare;
        }
        private string _token;
        public string Token { get { return _token; } }
        public int CashAmount { get; private set; }
        public Square CurrentSquare { get; set; }

    }
}