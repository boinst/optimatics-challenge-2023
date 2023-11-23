namespace tests.ben.Day06;

[TestClass]
public class PartOneTests
{
    // So, suppose you have a lanternfish with an internal timer value of 3:
    // After one day, its internal timer would become 2.
    [TestMethod]
    public void OneFishOneDay()
    {
        // So, suppose you have a lanternfish with an internal timer value of 3:
        var start_state = new[] { 3 };

        // After one day
        var state_after_one_day = new BusinessLogicPartOne().OneDayPasses(start_state).ToArray();

        // its internal timer would become 2.
        var expected = new[] { 2 };
        CollectionAssert.AreEqual(expected, state_after_one_day);
    }

    // After another day, its internal timer would become 1.
    [TestMethod]
    public void OneFishAfterTwoDays()
    {
        var start_state = new[] { 2 };
        
        // After the second day
        var state_after_the_second_day = new BusinessLogicPartOne().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        var expected = new[] { 1 };
        CollectionAssert.AreEqual(expected, state_after_the_second_day);
    }
    
    // After another day, its internal timer would become 1.
    [TestMethod]
    public void OneFishAfterThreeDays()
    {
        var start_state = new[] { 1 };
        
        // After the second day
        var state_after_the_second_day = new BusinessLogicPartOne().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        var expected = new[] { 0 };
        CollectionAssert.AreEqual(expected, state_after_the_second_day);
    }

    
    // After another day, its internal timer would become 1.
    [TestMethod]
    public void OneFishAfterTheFourthDay()
    {
        var start_state = new[] { 0 };
        
        // After the second day
        var state_after_the_fourth_day = new BusinessLogicPartOne().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        var expected = new[] { 6, 8 };
        CollectionAssert.AreEqual(expected, state_after_the_fourth_day);
    }

    [TestMethod]
    public void ExampleData()
    {
        var start_state = new[] { 3, 4, 3, 1, 2 };

        // After the second day
        var after_one_day = new BusinessLogicPartOne().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        var expected = new[] { 2, 3, 2, 0, 1 };
        CollectionAssert.AreEqual(expected, after_one_day);
    }

    /// <summary>
    /// Initial state: 3,4,3,1,2
    /// After  1 day:  2,3,2,0,1
    /// After  2 days: 1,2,1,6,0,8
    /// </summary>
    [TestMethod]
    public void ExampleDataAfterTwoDays()
    {
        // From the example data, this is the state after one day
        var after_one_day = new[] { 2, 3, 2, 0, 1 };

        // After the second day
        var after_two_days = new BusinessLogicPartOne().OneDayPasses(after_one_day).ToArray();

        // from the example data, this is the expected data after two days
        var expected = new[] { 1, 2, 1, 6, 0, 8 };
        CollectionAssert.AreEqual(expected, after_two_days);
    }

    /// <summary>
    /// Using the example data, run the simulation for 18 days.
    /// Initial state: 3,4,3,1,2
    /// After 18 days: 6,0,6,4,5,6,0,1,1,2,6,0,1,1,1,2,2,3,3,4,6,7,8,8,8,8
    /// </summary>
    [TestMethod]
    public void ExampleDataAfterEighteenDays()
    {
        // From the example data, this is the state after one day
        var initial_state = new[] { 3, 4, 3, 1, 2 };

        // After the second day
        var after_eighteen_days = new BusinessLogicPartOne().MultipleDaysPass(initial_state, 18).ToArray();

        // from the example data, this is the expected data after two days
        var expected = new[] { 6, 0, 6, 4, 5, 6, 0, 1, 1, 2, 6, 0, 1, 1, 1, 2, 2, 3, 3, 4, 6, 7, 8, 8, 8, 8 };
        CollectionAssert.AreEqual(expected, after_eighteen_days);
    }

    /// <summary>
    /// Using the test data, run the simulation for 256 days.
    /// </summary>
    [TestMethod]
    public void TestDataAfter80Days()
    {
        // From the example data, this is the state after one day
        var initial_state = new[] { 3, 5, 3, 5, 1, 3, 1, 1, 5, 5, 1, 1, 1, 2, 2, 2, 3, 1, 1, 5, 1, 1, 5, 5, 3, 2, 2, 5, 4, 4, 1, 5, 1, 4, 4, 5, 2, 4, 1, 1, 5, 3, 1, 1, 4, 1, 1, 1, 1, 4, 1, 1, 1, 1, 2, 1, 1, 4, 1, 1, 1, 2, 3, 5, 5, 1, 1, 3, 1, 4, 1, 3, 4, 5, 1, 4, 5, 1, 1, 4, 1, 3, 1, 5, 1, 2, 1, 1, 2, 1, 4, 1, 1, 1, 4, 4, 3, 1, 1, 1, 1, 1, 4, 1, 4, 5, 2, 1, 4, 5, 4, 1, 1, 1, 2, 2, 1, 4, 4, 1, 1, 4, 1, 1, 1, 2, 3, 4, 2, 4, 1, 1, 5, 4, 2, 1, 5, 1, 1, 5, 1, 2, 1, 1, 1, 5, 5, 2, 1, 4, 3, 1, 2, 2, 4, 1, 2, 1, 1, 5, 1, 3, 2, 4, 3, 1, 4, 3, 1, 2, 1, 1, 1, 1, 1, 4, 3, 3, 1, 3, 1, 1, 5, 1, 1, 1, 1, 3, 3, 1, 3, 5, 1, 5, 5, 2, 1, 2, 1, 4, 2, 3, 4, 1, 4, 2, 4, 2, 5, 3, 4, 3, 5, 1, 2, 1, 1, 4, 1, 3, 5, 1, 4, 1, 2, 4, 3, 1, 5, 1, 1, 2, 2, 4, 2, 3, 1, 1, 1, 5, 2, 1, 4, 1, 1, 1, 4, 1, 3, 3, 2, 4, 1, 4, 2, 5, 1, 5, 2, 1, 4, 1, 3, 1, 2, 5, 5, 4, 1, 2, 3, 3, 2, 2, 1, 3, 3, 1, 4, 4, 1, 1, 4, 1, 1, 5, 1, 2, 4, 2, 1, 4, 1, 1, 4, 3, 5, 1, 2, 1 };

        // After the second day
        var after_80_days = new BusinessLogicPartOne().MultipleDaysPass(initial_state, 80).ToArray();

        // this is the puzzle answer
        Assert.AreEqual(365862, after_80_days.Length);
    }
}
