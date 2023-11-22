namespace tests;

[TestClass]
public class PassADay : code.PassADay
{

    [TestMethod]
    public void firstBusinessRule()
    {
        int internalValue = 3;

        internalValue = passADay(internalValue);

        Assert.AreEqual(2, internalValue);
    }


    //After another day, its internal timer would reset to 6, and it would create a new lanternfish with an internal timer of 8.

    [TestMethod]
    public void secondBusinessRule()
    {
        int[] fishes = new int[] { 0 };

        var expectedFishes = passADay(fishes);

        CollectionAssert.AreEqual(new int[] { 6, 8 }, expectedFishes);
    }

    // after 18 days, there are a total of 26 fish.
    [TestMethod]
    public void afterOneDay()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = passDays(1, fishes);

        CollectionAssert.AreEqual(new int[] { 2, 3, 2, 0, 1 }, expectedFishes);
    }

    [TestMethod]
    public void afterTwoDay()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = passDays(2, fishes);

        CollectionAssert.AreEqual(new int[] { 1, 2, 1, 6, 0, 8 }, expectedFishes);
    }

    [TestMethod]
    public void after3Day()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = passDays(3, fishes);

        CollectionAssert.AreEqual(new int[] { 0, 1, 0, 5, 6, 7, 8 }, expectedFishes);
    }

    // after 18 days, there are a total of 26 fish.
    [TestMethod]
    public void after18Day()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = passDays(18, fishes);

        CollectionAssert.AreEqual(new int[] { 6, 0, 6, 4, 5, 6, 0, 1, 1, 2, 6, 0, 1, 1, 1, 2, 2, 3, 3, 4, 6, 7, 8, 8, 8, 8 }, expectedFishes);
    }

    
    // after 80 days, 
    [TestMethod]
    public void after80Day()
    {
 }


}