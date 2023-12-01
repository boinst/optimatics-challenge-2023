using tests.ben.Common;

namespace tests.ben.Y2023.D01;

[TestClass]
public class PartOneTests
{
    [TestMethod]
    public void ToLines()
    {
        var lines = InputDataParser.ToLines("00\r\n11");
        Assert.AreEqual(2, lines.Length);
    }
    
    /// <summary>
    /// Find the first digit on a line
    /// </summary>
    [TestMethod]
    public void FirstDigit()
    {
        var first_digit = BusinessLogicPartOne.GetFirstDigit("0011");
        Assert.AreEqual(0, first_digit);
    }
    /// <summary>
    /// Find the last digit on a line
    /// </summary>
    [TestMethod]
    public void LastDigit()
    {
        var last_digit = BusinessLogicPartOne.GetLastDigit("0011");
        Assert.AreEqual(1, last_digit);
    }

    [TestMethod]
    public void DecryptLine()
    {
        var decrypted = BusinessLogicPartOne.DecryptLine("pqr3stu8vwx");
        Assert.AreEqual(38, decrypted);
    }

    
    [TestMethod]
    public void DecryptLines()
    {
        var decrypted = BusinessLogicPartOne.DecryptLines(TestData.ExampleData);
        Assert.AreEqual(4, decrypted.Count());
    }
    [TestMethod]
    public void Solution()
    {
        var solution = BusinessLogicPartOne.Solution(TestData.ExampleData);
        Assert.AreEqual(142, solution);
    }

    [TestMethod]
    public void SolutionMyData()
    {
        var solution = BusinessLogicPartOne.Solution(TestData.MyData);
        Assert.AreEqual(55834, solution);
    }
}