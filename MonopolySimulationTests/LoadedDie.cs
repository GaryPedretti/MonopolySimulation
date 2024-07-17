using MonopolySimulation;

namespace MonopolySimulationTests
{
    internal class LoadedDie : Die
    {
        private int faceValue;

        public LoadedDie(int v)
        {
            this.faceValue = v;
        }
    }
}