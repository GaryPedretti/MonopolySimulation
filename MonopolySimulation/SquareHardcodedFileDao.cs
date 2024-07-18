using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation
{
    public class SquareHardcodedFileDao : ISquareFileDao
    {
        private static readonly int _positionOfGoSquare = 0;
        private static readonly int _positionOfIncomeTaxSquare = 4;
        private static readonly int _positionOfLuxuryTaxSquare = 38;

        private static IList<string> _propertyNames = new List<string>();

        //public SquareHardcodedFileDao() : this(new SquareHardcodedFileDao()) { }

        //private ISquareFileDao _squareFileDao;
        //public SquareHardcodedFileDao(ISquareFileDao squareFileDao)
        //{
        //    _squareFileDao = squareFileDao;   
        //}

        public SquareHardcodedFileDao()
        {
            ReadCsvFile();
        }

        public void ReadCsvFile()
        {
            using (var reader = new StreamReader(@"C:\VSTS\MonopolySimulation\propertySquares\PropertySquaresName.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    for(int i=0;i<values.Length; i++)
                    {
                        values[i] = values[i].Replace("\"","").Trim();
                    }
                    _propertyNames = values.ToList();   
                }
            }
        }

        public Square CreateSquare(int position)
        {
            if (position == _positionOfGoSquare)
            {
                return new GoSquare() { Name = _propertyNames[position] };
            }
            else if (position == _positionOfLuxuryTaxSquare)
            {
                return new LuxuryTaxSquare() { Name = _propertyNames[position] };
            }
            else if (position == _positionOfIncomeTaxSquare)
            {
                return new IncomeTaxSquare() { Name = _propertyNames[position] };
            }
            else
            {
                return new Square() { Name = _propertyNames[position] };
            }
        }



    }
}
