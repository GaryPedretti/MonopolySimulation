namespace MonopolySimulation
{
    public class Die
    {
        int _faceValue;
        public int FaceValue {
            get
            {
                return _faceValue;
            }
            set { _faceValue = value; }
        }
        private static Random _random = new Random();

        public Die()
        {
            Roll();
        }

        public virtual void Roll()
        {
            _faceValue = _random.Next(1, 7);
        }
    }
}
