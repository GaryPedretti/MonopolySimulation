
using System;

namespace MonopolySimulation.Tests2
{
    internal class LoadedDie : Die
    {
        //private int faceValue;

        public LoadedDie(int value)
        {
            FaceValue = value;
        }

        public override void Roll()
        {
            // loaded die, never changing
        }


    }
}