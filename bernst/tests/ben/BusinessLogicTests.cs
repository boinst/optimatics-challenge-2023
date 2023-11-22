namespace tests.ben;

[TestClass]
public class BusinessLogicTests
{
    // So, suppose you have a lanternfish with an internal timer value of 3:
    // After one day, its internal timer would become 2.
    [TestMethod]
    public void FirstBusinessRule()
    {
        // So, suppose you have a lanternfish with an internal timer value of 3:
        var startState = new[] { 3 };

        // After one day
        var stateAfterOneDay = new tests.ben.BusinessLogic().OneDayPasses(startState).ToArray();

        // its internal timer would become 2.
        var expected = new[] { 2 };
        CollectionAssert.AreEqual(expected, stateAfterOneDay);
    }
}
