using System.Xml;

namespace tests.ben.Day09;

public class BusinessLogicPartOne
{
    public static int CalculateRiskLevel(int i)
    {
        return i + 1;
    }

    /// <summary>
    /// Count the number of low points in a given data set.
    /// </summary>
    public static int CountLowPoints(int[] data)
    {
        var count = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (IsLowPoint(data, i))
                ++count;
        }

        return count;
    }

    public static bool IsLowPoint(int[] data, int i)
    {
        if (i > 0 && data[i - 1] < data[i]) return false;
        if (i < data.Length - 1 && data[i + 1] < data[i]) return false;
        return true;
    }
}