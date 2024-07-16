
namespace MonopolySimulation
{
    public class DiceTornado
    {
        public int Spin(int numOfDice)
        {
            if (numOfDice <= 0) { throw new System.ArgumentException(); }
            
            int spinTotal = 0;
            IDie d = new Die();
            for (int i = 0; i < numOfDice; i++)
            {
                d.Roll();
                spinTotal += d.FaceValue;
            }
            return spinTotal;
        }
    }
}