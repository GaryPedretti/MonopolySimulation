namespace MonopolySimulation
{
    public class Board
    {
        public Board() {
            for (int i = 0; i < 40; i++)
            {
                var square = new Square(); 
                Squares.Add(square);
            }
        }
        public IList<Square> Squares { get; set; } = [];
    }
}