namespace tests;

[TestClass]
public class CompareTest : code.Compare
{
    [TestMethod]
    public void compareTest()
    {
        int currentPoint = 0;
        int[] neighbors = { 1, 2, 3 };

        bool expected = true;
        bool actual = code.Compare.isSmallest(currentPoint, neighbors);
        Assert.AreEqual(expected, actual);
    }
}
