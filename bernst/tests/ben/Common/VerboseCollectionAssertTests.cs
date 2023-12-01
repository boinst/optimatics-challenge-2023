using System.Collections;

namespace tests.ben.Common;

[TestClass]
public class VerboseCollectionAssertTests
{
    private readonly ICollection a = new[] { 4, 5, 6 };
    private readonly ICollection b = new[] { 7, 8, 9 };
    private readonly ICollection c = new[] { 4, 5, 6 };

    /// <summary>
    /// When the assertion succeeds, nothing is written to the buffer and no exception is thrown.
    /// </summary>
    [TestMethod]
    public void AreEqual()
    {
        var text_writer = new MockWriter();

        // will not throw
        VerboseCollectionAssert.AreEqualInternal(text_writer, a, c);

        Assert.AreEqual(string.Empty, text_writer.Content);
    }

    /// <summary>
    /// When the assertion fails, the expected and actual values are written to the buffer and an exception is thrown.
    /// </summary>
    [TestMethod]
    public void AreNotEqual()
    {
        var text_writer = new MockWriter();

        // will not throw
        VerboseCollectionAssert.AreEqualInternal(text_writer, a, c);

        try
        {
            VerboseCollectionAssert.AreEqualInternal(text_writer, a, b);
            Assert.Fail("An exception should have been thrown");
        }
        catch (AssertFailedException)
        {
            Assert.AreEqual("Expected:\r\n4,5,6\r\nActual:\r\n7,8,9\r\n", text_writer.Content);
        }
    }
}