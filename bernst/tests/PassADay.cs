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
}