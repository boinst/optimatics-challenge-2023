using System.Text;

namespace tests.ben.Common;

/// <summary>
/// Used for testing things that write to a TextWriter.
/// </summary>
public class MockWriter : TextWriter
{
    public override Encoding Encoding => Encoding.UTF8;
    private readonly StringBuilder buffer = new();
    public string Content => buffer.ToString();

    public override void WriteLine(string? line)
    {
        buffer.AppendLine(line);
    }
}