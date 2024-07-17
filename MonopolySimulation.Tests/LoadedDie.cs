
namespace MonopolySimulation.Tests
{
    internal class LoadedDie : Die
    {
        public LoadedDie(int loadedValue)
        {
            _faceValue = loadedValue;   
        }

        public override void Roll()
        {
        }
    }
}