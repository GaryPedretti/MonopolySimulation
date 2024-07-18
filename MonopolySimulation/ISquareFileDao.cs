using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public interface ISquareFileDao
    {
        Square CreateSquare(int position);

    }
}
