namespace tests.prateek._2021D6;

[TestClass]
public class PartOneTests
{
    [TestMethod]
    public void getLowPoint()
    {
        int startState = 0;
        var expected = 0;

        int actual = new D9().getLowPoint(startState);
        Assert.AreEqual(expected, actual);
    }

}

