using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public interface ISquareDao
    {
        Square CreateSquare(int position);
        Square CreateSquare(int position, string name, int price, int rent);

    }
}
