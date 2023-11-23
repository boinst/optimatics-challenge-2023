using System.Collections;

namespace tests.ben.Common;

public static class VerboseCollectionAssert
{
    public static void AreEqual(ICollection expected, ICollection actual)
    {
        AreEqualInternal(Console.Out, expected, actual);
    }

    internal static void AreEqualInternal(TextWriter textWriter, ICollection expected, ICollection actual)
    {
        try
        {
            CollectionAssert.AreEqual(expected, actual);
        }
        catch (AssertFailedException)
        {
            textWriter.WriteLine("Expected:");
            DebugPrint(textWriter, expected);
            textWriter.WriteLine("Actual:");
            DebugPrint(textWriter, actual);
            throw;
        }
    }

    private static void DebugPrint(TextWriter sink, ICollection expected)
    {
        sink.WriteLine(string.Join(',', new ArrayList(expected).ToArray()));
    }
}