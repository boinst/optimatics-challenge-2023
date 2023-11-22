namespace tests;

[TestClass]
public class PassADay : code.PassADay
{

    [TestMethod]
    public void passADay()
    {
        int internalValue = 3;

        internalValue= passADay(internalValue);

        Assert.AreEqual(2, internalValue);
    }
}