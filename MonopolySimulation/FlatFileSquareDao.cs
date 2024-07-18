
namespace MonopolySimulation;

public class FlatFileSquareDao(string filename)
{

    public string GetSquareName(int position)
    {
        var names = File.ReadAllText(filename);
        var array = names.Split(",");
        var trimmedArray = array.Select(x => x.Trim().Trim('"')).ToArray();
        return trimmedArray[position];
    }
}