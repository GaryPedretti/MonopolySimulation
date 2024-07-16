namespace MonopolySimulation
{
    public interface IDie
    {
        int FaceValue { get; }

        void Roll();
    }
}