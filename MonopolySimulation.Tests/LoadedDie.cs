
namespace MonopolySimulation.Tests
{
    internal class LoadedDie : Die
    {
        private int faceValue;

        internal LoadedDie(int value)
        {
            this.faceValue = value;
        }

        public override int FaceValue => this.faceValue;
    }
}