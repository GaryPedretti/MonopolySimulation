
namespace MonopolySimulation
{
    public class CSVDataAdapter : ISquareDataAdapter
    {
        private readonly List<List<string>> _csvData;

        public CSVDataAdapter() : this("squares.csv")
        {

        }

        public CSVDataAdapter(string csvFileName)
        {
            string csvContent = File.ReadAllText(csvFileName);
            this._csvData = csvContent.Split(Environment.NewLine).Select(line => line.Split(',').ToList()).ToList();
        }

        public IList<Square> CreateAllSquares()
        {
            return _csvData.Select(line => (Square)(line[1] switch
                {
                    "Go" => new GoSquare(line[0]),
                    "IncomeTax" => new IncomeTaxSquare(line[0]),
                    "LuxuryTax" => new LuxuryTaxSquare(line[0]),
                    _ => new PropertySquare(line[0]),
                })).ToList();
        }
    }
}