
namespace MonopolySimulation
{
    public class Player
    {
        public Player (string token)
        {
            _token = token;
        }
        private string _token;
        public string Token { get { return _token; } }


    }
}