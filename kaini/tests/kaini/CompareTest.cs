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

    // 1D string
    [TestMethod]
    public void iteratorTest1()
    {
        int[,] heightMap = { { 1, 2, 3 } };
        List<int> expected = new List<int> { 1 };
        List<int> actual = code.Compare.iterator(heightMap);
        CollectionAssert.AreEqual(expected, actual);
    }

    // 2D string
    [TestMethod]
    public void iteratorTest2()
    {
        int[,] heightMap = { { 1, 2, 3 } ,{0, 2, 4}};
        List<int> expected = new List<int> { 0 };
        List<int> actual = code.Compare.iterator(heightMap);
        CollectionAssert.AreEqual(expected, actual);
    }

    // 2D string
    [TestMethod]
    public void iteratorTest3()
    {
        int[,] heightMap = code.InputHandler.readInput(
            @"2199943210
3987894921
9856789892
8767896789
9899965678");
        List<int> expected = new List<int> { 1,0,5,5 };
        List<int> actual = code.Compare.iterator(heightMap);
        CollectionAssert.AreEqual(expected, actual);
    }

    // get the sum 
    [TestMethod]
    public void sumTest()
    {
        List<int> lowPoints = new List<int> { 1,0,5,5};
        int expected = 15;
        int actual = code.Calculator.sum(lowPoints);
        Assert.AreEqual(expected, actual);
    }
}
