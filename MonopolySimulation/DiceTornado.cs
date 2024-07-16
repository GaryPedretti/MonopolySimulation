using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class DiceTornedo
    {
        public int Spin(int numOfDice)
        {
            if (numOfDice <= 0) { throw new System.ArgumentException(); }
            //return numOfDice;
            int spinToltal = 0;
            Die d = new Die();
            for (int i = 0; i < numOfDice; i++)
            {
                d.Roll();
                spinToltal = d.FaceValue;
            }
            return spinToltal;
        }
    }
}
