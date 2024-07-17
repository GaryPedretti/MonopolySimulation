using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class SquareHardcodedDao : ISquareDao
    {
        private static readonly int _positionOfGoSquare = 0;
        private static readonly int _positionOfIncomeTaxSquare = 4;
        private static readonly int _positionOfLuxuryTaxSquare = 38;

        private static readonly string[] _propertyNames = { "Go", "Mediterranean Avenue", 
            "Community Chest", "Baltic Avenue", "Income Tax", "Reading Railroad", 
            "Oriental Avenue", "Chance", "Vermont Avenue", "Connecticut Avenue",
            "Jail", "St. Charles Place", "Electric Company", "States Avenue",
            "Virginia Avenue", "Pennsylvania Railroad", "St. James Place", 
            "Community Chest", "Tennessee Avenue", "New York Avenue", "Free Parking",
            "Kentucky Avenue", "Chance", "Indiana Avenue", "Illinois Avenue",
            "B & O Railroad", "Atlantic Avenue", "Ventor Avenue", "Water Works",
            "Marvin Gardens", "Go To Jail", "Pacific Avenue", "North Carolina Avenue",
            "Community Chest", "Pennsylvania Avenue", "Short Line Railroad", 
            "Chance", "Park Place", "Luxury Tax", "Boardwalk"};

        public Square CreateSquare(int position)
        {
            if (position == _positionOfGoSquare)
            {
                return new GoSquare();
            }
            else if (position == _positionOfLuxuryTaxSquare)
            {
                return new LuxuryTaxSquare();
            }
            else if (position == _positionOfIncomeTaxSquare)
            {
                return new IncomeTaxSquare();
            }
            else
            {
                return new Square() { Name = _propertyNames[position] };
            }
        }
    }
}
