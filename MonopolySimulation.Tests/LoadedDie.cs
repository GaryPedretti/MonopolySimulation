
namespace MonopolySimulation.Tests
{
    internal class LoadedDie : Die
    {
        private Queue<int> _rollSequence = new();

        public LoadedDie(int[] loadedValues)
        {
            foreach (var loadedValue in loadedValues)
            {
                _rollSequence.Enqueue(loadedValue);
            }
        }

        public override void Roll()
        {
            _faceValue = _rollSequence.Dequeue();
            _rollSequence.Enqueue(_faceValue);
        }
    }
}