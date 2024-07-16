
namespace MonopolySimulation
{
    public class Player
    {
        public IList<string> _tokens;
        public string Token { get; set; }

        public Player(int tokenId)
        {
            Square token = new();
            _tokens = token.Tokens;

            Token = _tokens[tokenId];
        }
    }
}