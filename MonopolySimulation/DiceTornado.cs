namespace MonopolySimulation
{
    public class DiceTornado
    {
        public int Spin(int numOfDice)
        {
            Die die = new ();
            int sum = 0;

            for (int i = 0; i < numOfDice; i++)
            {
                die.Roll();
                sum += die.FaceValue;
            }

            return sum;
        }
    }
}