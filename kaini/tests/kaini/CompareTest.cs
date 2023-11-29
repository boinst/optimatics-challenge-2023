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


    [TestMethod]
    public void getNeighborsTest()
    {
        int[,] heightMap = { { 1, 2, 3 }, { 4, 5, 6 } };
        int row = 0;
        int col = 0;

        List<int> expected = new List<int> { 4, 2 };
        List<int> actual = code.Compare.getNeighbors(heightMap, row, col);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void iteratorTest()
    {
        int[,] heightMap = { { 1, 2, 3 } };
        List<int> expected = new List<int> { 1 };
        List<int> actual = code.Compare.iterator(heightMap);
        CollectionAssert.AreEqual(expected, actual);
    }
}
