using System.Xml;
using tests.ben.Common;

namespace tests.ben.Y2023.D01;

public class BusinessLogicPartOne
{
    public static int GetFirstDigit(string line)
    {
        foreach (char c in line)
        {
            if (char.IsAsciiDigit(c))
                return int.Parse(c.ToString());
        }

        // No digits on this line, so throw.
        throw new Exception($"No digits on line \"{line}\"");
    }

    public static int GetLastDigit(string line)
    {
        // Start from the end of the string, since we want the last digit
        foreach (char c in line.Reverse())
        {
            if (char.IsAsciiDigit(c))
                return int.Parse(c.ToString());
        }

        // No digits on this line, so throw.
        throw new Exception($"No digits on line \"{line}\"");
    }

    public static int DecryptLine(string s)
    {
        int first_digit = GetFirstDigit(s);
        int last_digit = GetLastDigit(s);
        return int.Parse(first_digit.ToString() + last_digit.ToString());
    }

    public static IEnumerable<int> DecryptLines(string example_data)
    {
        var lines = InputDataParser.ToLines(example_data);
        foreach (var l in lines)
        {
            yield return DecryptLine(l);
        }
    }

    public static int Solution(string example_data)
    {
        return DecryptLines(example_data).Sum();
    }
}