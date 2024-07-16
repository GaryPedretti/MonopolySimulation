
namespace MonopolySimulation
{
    public class Token
    {
        private IList<string> _tokens;
        public IList<string> Tokens => _tokens;

        public Token()
        {
            _tokens = new List<string> {
                "Battleship",
                "Race Car",
                "Top Hat",
                "Thimble",
                "Scottish Terrier",
                "Cat",
                "Penguin",
                "Rubber Ducky"
            };
        }

    }
}