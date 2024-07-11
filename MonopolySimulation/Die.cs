using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class Die
    {
        int _faceValue;
        static readonly Random _random = new();

        public int FaceValue {
            get
            {
                return _faceValue;
            }
        }
        
        public void Roll() {
            _faceValue = _random.Next(1, 7);
        }
    }
}
