namespace tests;

[TestClass]
public class PassADay : code.DayTwo
{

    // [TestMethod]
    // public void firstBusinessRule()
    // {
    //     int internalValue = 3;

    //     internalValue = dayTwo(internalValue);

    //     Assert.AreEqual(2, internalValue);
    // }

    //After another day, {6,8}
    [TestMethod]
    public void secondBusinessRule()
    {
        int[] fishes = new int[] { 0 };

        var expectedFishes = dayTwo(1, fishes);

        CollectionAssert.AreEqual(new long[] { 0, 0, 0, 0, 0, 0, 1, 0, 1 }, expectedFishes);
    }

    // after one day,  {2, 3, 2, 0, 1} change: {0,1,1,2,1,0,0,0,0}=>{ 1, 1, 2, 1, 0, 0, 0, 0, 0 }
    [TestMethod]
    public void afterOneDay()
    {
        int[] fishes = [ 3, 4, 3, 1, 2 ];

        var expectedFishes = dayTwo(1, fishes);

        CollectionAssert.AreEqual(new long[] { 1, 1, 2, 1, 0, 0, 0, 0, 0 }, expectedFishes);
    }

    // { 1, 2, 1, 6, 0, 8 } change: {0,1,1,2,1,0,0,0,0}=> { 1,2,1,0,0,0,1,0,1 }
    [TestMethod]
    public void afterTwoDay()
    {
        int[] fishes = [3, 4, 3, 1, 2 ];

        var expectedFishes = dayTwo(2, fishes);

        CollectionAssert.AreEqual(new long[] { 1, 2, 1, 0, 0, 0, 1, 0, 1 }, expectedFishes);
    }

    // { 0, 1, 0, 5, 6, 7, 8 }
    [TestMethod]
    public void after3Day()
    {
        int[] fishes = [3, 4, 3, 1, 2 ];

        var expectedFishes = dayTwo(3, fishes);

        CollectionAssert.AreEqual(new long[] { 2, 1, 0, 0, 0, 1, 1, 1, 1 }, expectedFishes);
    }

    // after 18 days, { 6, 0, 6, 4, 5, 6, 0, 1, 1, 2, 6, 0, 1, 1, 1, 2, 2, 3, 3, 4, 6, 7, 8, 8, 8, 8 }
    [TestMethod]
    public void after18Day()
    {
        int[] fishes = [3, 4, 3, 1, 2];

        var expectedFishes = dayTwo(18, fishes);

        CollectionAssert.AreEqual(new long[] { 3, 5, 3, 2, 2, 1, 5, 1, 4 }, expectedFishes);
    }

    // after 80 days, there would be a total of 5934.
    [TestMethod]
    public void after80Day()
    {
        int[] fishes = [ 3, 4, 3, 1, 2 ];

        var expectedFishes = dayTwo(80, fishes);

        long number = count(expectedFishes);

        Assert.AreEqual(5934, number);

    }

// How many lanternfish would there be after 80 days?
// Your puzzle answer was 388419.
    [TestMethod]
    public void afterSomeDay1()
    {
        int[] fishes = [1,1,1,1,3,1,4,1,4,1,1,2,5,2,5,1,1,1,4,3,1,4,1,1,1,1,1,1,1,2,1,2,4,1,1,1,1,1,1,1,3,1,1,5,1,1,2,1,5,1,1,1,1,1,1,1,1,4,3,1,1,1,2,1,1,5,2,1,1,1,1,4,5,1,1,2,4,1,1,1,5,1,1,1,1,5,1,3,1,1,4,2,1,5,1,2,1,1,1,1,1,3,3,1,5,1,1,1,1,3,1,1,1,4,1,1,1,4,1,4,3,1,1,1,4,1,2,1,1,1,2,1,1,1,1,5,1,1,3,5,1,1,5,2,1,1,1,1,1,4,4,1,1,2,1,1,1,4,1,1,1,1,5,3,1,1,1,5,1,1,1,4,1,4,1,1,1,5,1,1,3,2,2,1,1,1,4,1,3,1,1,1,2,1,3,1,1,1,1,4,1,1,1,1,2,1,4,1,1,1,1,1,4,1,1,2,4,2,1,2,3,1,3,1,1,2,1,1,1,3,1,1,3,1,1,4,1,3,1,1,2,1,1,1,4,1,1,3,1,1,5,1,1,3,1,1,1,1,5,1,1,1,1,1,2,3,4,1,1,1,1,1,2,1,1,1,1,1,1,1,3,2,2,1,3,5,1,1,4,4,1,3,4,1,2,4,1,1,3,1];

        var expectedFishes = dayTwo(80, fishes);

        long number = count(expectedFishes);

        Assert.AreEqual(388419, number);

    }

    [TestMethod]
    public void afterSomeDay2()
    {
        int[] fishes = [ 1,1,1,1,3,1,4,1,4,1,1,2,5,2,5,1,1,1,4,3,1,4,1,1,1,1,1,1,1,2,1,2,4,1,1,1,1,1,1,1,3,1,1,5,1,1,2,1,5,1,1,1,1,1,1,1,1,4,3,1,1,1,2,1,1,5,2,1,1,1,1,4,5,1,1,2,4,1,1,1,5,1,1,1,1,5,1,3,1,1,4,2,1,5,1,2,1,1,1,1,1,3,3,1,5,1,1,1,1,3,1,1,1,4,1,1,1,4,1,4,3,1,1,1,4,1,2,1,1,1,2,1,1,1,1,5,1,1,3,5,1,1,5,2,1,1,1,1,1,4,4,1,1,2,1,1,1,4,1,1,1,1,5,3,1,1,1,5,1,1,1,4,1,4,1,1,1,5,1,1,3,2,2,1,1,1,4,1,3,1,1,1,2,1,3,1,1,1,1,4,1,1,1,1,2,1,4,1,1,1,1,1,4,1,1,2,4,2,1,2,3,1,3,1,1,2,1,1,1,3,1,1,3,1,1,4,1,3,1,1,2,1,1,1,4,1,1,3,1,1,5,1,1,3,1,1,1,1,5,1,1,1,1,1,2,3,4,1,1,1,1,1,2,1,1,1,1,1,1,1,3,2,2,1,3,5,1,1,4,4,1,3,4,1,2,4,1,1,3,1];
        var expectedFishes = dayTwo(256, fishes);

        long number = count(expectedFishes);

        Assert.AreEqual(1, number);

    }

}