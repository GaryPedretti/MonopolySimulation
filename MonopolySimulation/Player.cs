

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
        public int CashAmount { get;  set; }
        public Square CurrentSquare { get; set; }

        public void TakeTurn(Die die1, Die die2)
        {
            int steps = die1.FaceValue + die2.FaceValue;
            for (int i = 0; i < steps; i++)
            {
                CurrentSquare = CurrentSquare.NextSquare;
                CurrentSquare.PassedBy(this);
            }
            CurrentSquare.LandedOn(this);

        }
        
    }
}