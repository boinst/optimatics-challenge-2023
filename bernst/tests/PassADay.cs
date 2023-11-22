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

    // //After another day, {6,8}
    // [TestMethod]
    // public void secondBusinessRule()
    // {
    //     int[] fishes = new int[] { 0 };

    //     var expectedFishes = dayTwo(fishes);

    //     CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 1 }, expectedFishes);
    // }

    // after one day,  {2, 3, 2, 0, 1} change: {0,1,1,2,1,0,0,0,0}=>{ 1, 1, 2, 1, 0, 0, 0, 0, 0 }
    [TestMethod]
    public void afterOneDay()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = dayTwo(1, fishes);

        CollectionAssert.AreEqual(new int[] { 1, 1, 2, 1, 0, 0, 0, 0, 0 }, expectedFishes);
    }

    // { 1, 2, 1, 6, 0, 8 } change: {0,1,1,2,1,0,0,0,0}=> { 1,2,1,0,0,0,1,0,1 }
    [TestMethod]
    public void afterTwoDay()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = dayTwo(2, fishes);

        CollectionAssert.AreEqual(new int[] { 1, 2, 1, 0, 0, 0, 1, 0, 1 }, expectedFishes);
    }

    // { 0, 1, 0, 5, 6, 7, 8 }
    [TestMethod]
    public void after3Day()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = dayTwo(3, fishes);

        CollectionAssert.AreEqual(new int[] { 2, 1, 0, 0, 0, 1, 1, 1, 1 }, expectedFishes);
    }

    // after 18 days, { 6, 0, 6, 4, 5, 6, 0, 1, 1, 2, 6, 0, 1, 1, 1, 2, 2, 3, 3, 4, 6, 7, 8, 8, 8, 8 }
    [TestMethod]
    public void after18Day()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = dayTwo(18, fishes);

        CollectionAssert.AreEqual(new int[] { 3, 5, 3, 2, 2, 1, 5, 1, 4 }, expectedFishes);
    }



    // after 80 days, there would be a total of 5934.
    [TestMethod]
    public void after80Day()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2 };

        var expectedFishes = dayTwo(80, fishes);

        int number = count(expectedFishes);

        Assert.AreEqual(5934, number);

    }

    [TestMethod]
    public void afterSomeDay()
    {
        int[] fishes = new int[] { 3, 4, 3, 1, 2};

        var expectedFishes = dayTwo(256, fishes);

        int number = count(expectedFishes);

        Assert.AreEqual(26984457539, number);

    }

}