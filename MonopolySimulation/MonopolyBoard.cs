using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class MonopolyBoard
    {
        public IList<Square> Squares { get; set; }
        public MonopolyBoard() 
        {
            Squares = new List<Square>();
            for (int i = 0; i < Squares.Count; i++)
            {
                Squares.Add(Squares[i]);
            }
        }


    }
}
