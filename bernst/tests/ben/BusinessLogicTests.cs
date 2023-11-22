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

    // After another day, its internal timer would become 1.
    [TestMethod]
    public void AfterTheSecondDay()
    {
        var startState = new[] { 2 };
        
        // After the second day
        var stateAfterTheSecondDay = new tests.ben.BusinessLogic().OneDayPasses(startState).ToArray();

        // its internal timer would become 1.
        var expected = new[] { 1 };
        CollectionAssert.AreEqual(expected, stateAfterTheSecondDay);
    }
    
    // After another day, its internal timer would become 1.
    [TestMethod]
    public void AfterTheThirdDay()
    {
        var startState = new[] { 1 };
        
        // After the second day
        var stateAfterTheSecondDay = new tests.ben.BusinessLogic().OneDayPasses(startState).ToArray();

        // its internal timer would become 1.
        var expected = new[] { 0 };
        CollectionAssert.AreEqual(expected, stateAfterTheSecondDay);
    }

    
    // After another day, its internal timer would become 1.
    [TestMethod]
    public void AfterTheFourthDay()
    {
        var startState = new[] { 0 };
        
        // After the second day
        var stateAfterTheFourthDay = new tests.ben.BusinessLogic().OneDayPasses(startState).ToArray();

        // its internal timer would become 1.
        var expected = new[] { 6, 8 };
        CollectionAssert.AreEqual(expected, stateAfterTheFourthDay);
    }
}
