namespace tests.prateek._2021D6;

[TestClass]
public class PartOneTests
{
    // Given the height Map only has one number {0}
    // The low point would be the same number 0
    [TestMethod]
    public void getLowPoint1()
    {
        int[] startState = new int[] {0};
        var expected = 0;

        int actual = new D9().getLowPoint(startState);
        Assert.AreEqual(expected, actual);
    }

    // Given the height Map only has 2 numbers {0,1}
    // The low point would be 0
    [TestMethod]
    public void getLowPoint2()
    {
        int[] startState = new int[] {0,1};
        int expected = 0;

        int actual = new D9().getLowPoint(startState);
        Assert.AreEqual(expected, actual);
    }

}

