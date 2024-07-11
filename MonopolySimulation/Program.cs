// See https://aka.ms/new-console-template for more information
using MonopolySimulation;

Die d = new Die();

for (int i = 0; i < 10; i++)
{
    d.Roll();
    Console.WriteLine("Die was rolled, result is: " + d.FaceValue);
}
Console.ReadLine();
