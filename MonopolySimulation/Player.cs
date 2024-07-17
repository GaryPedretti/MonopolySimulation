



namespace MonopolySimulation
{
    public class Player
    {
        public Player(string token, Square firstSquare, int initialFunds)
        {
            Token = token;
            CurrentSquare = firstSquare;
            Funds = initialFunds;
        }

        public string Token { get; set; }
        public Square CurrentSquare { get; set; }
        public int Funds { get; set; }

        public void TakeTurn(Die die1, Die die2)
        {
            die1.Roll();
            die2.Roll();

            int numSpaces = die1.FaceValue + die2.FaceValue;

            for (int move = 0; move < numSpaces; move++)
            {
                CurrentSquare = CurrentSquare.NextSquare;
            }

            if (die1.FaceValue == die2.FaceValue)
            {
                TakeTurn(die1, die2);
            }
        }
    }
}