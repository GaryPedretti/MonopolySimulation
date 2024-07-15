using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class Square
    {
        int _position;
        string _name;
        int _price;
        int _rent;
        public Square(int position, string name, int price, int rent) {
            _position = position;
            _name = name;
            _price = price;
            _rent = rent;
        }
    }
}
