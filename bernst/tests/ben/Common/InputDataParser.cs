namespace tests.ben.Common;

/// <summary>
/// It parses the input data.
/// </summary>
public class InputDataParser
{
    public int[] Parse(string startData)
    {
        return startData
            .Split(',')
            .Select(int.Parse)
            .ToArray();
    }
}