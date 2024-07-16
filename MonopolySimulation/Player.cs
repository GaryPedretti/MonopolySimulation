
namespace MonopolySimulation
{
    public class Player
    {
        public IList<string> _tokens;
        public string Token { get; set; }
        public int CurrentPosition { get; set; }

        public Player(int tokenId)
        {
            Token token = new();
            _tokens = token.Tokens;
            CurrentPosition = 0;

            Token = _tokens[tokenId];
        }
    }
}