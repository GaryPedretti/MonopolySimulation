using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation.Tests
{
    public class FlatFileSquareDaoTests
    {
        const string filename = @"..\..\..\..\chicagoMonopoly.txt";


        [Fact]
        public void WhenGettingFirstPostionName_GetsFirstStringInCsv()
        {
            FlatFileSquareDao squareDao = new FlatFileSquareDao(filename);

            string squareName = squareDao.GetSquareName(0);

            Assert.Equal("Go", squareName);
        }


        // when constructing square
        // should use name at position in file for square name


    }
}
