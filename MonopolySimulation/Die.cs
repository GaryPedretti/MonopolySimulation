using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    internal class Die
    {
        int _faceValue;
        public int FaceValue {
            get
            {
                return _faceValue;
            }
        }
        private static Random _random = new Random();

        public virtual void roll()
        {
            
        }
        public void Roll() {
            _faceValue = _random.Next(1, 7);
        }
    }
}
