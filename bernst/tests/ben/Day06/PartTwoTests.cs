using tests.ben.Common;
namespace tests.ben.Day06;

[TestClass]
public class PartTwoTests
{
    // So, suppose you have a lanternfish with an internal timer value of 3:
    // After one day, its internal timer would become 2.
    [TestMethod]
    public void OneFishAfterOneDay()
    {
        // So, suppose you have a lanternfish with an internal timer value of 3:
        var start_state = new ulong[] { 0, 0, 0, 1, 0, 0, 0, 0, 0 };

        // After one day
        var state_after_one_day = new BusinessLogicPartTwo().OneDayPasses(start_state).ToArray();

        // its internal timer would become 2.
        var expected = new ulong[] { 0, 0, 1, 0, 0, 0, 0, 0, 0 };
        CollectionAssert.AreEqual(expected, state_after_one_day);
    }

    // After another day, its internal timer would become 1.
    [TestMethod]
    public void OneFishAfterTwoDays()
    {
        var start_state = new ulong[] { 0, 0, 1, 0, 0, 0, 0, 0, 0 };

        // After the second day
        var state_after_the_second_day = new BusinessLogicPartTwo().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        var expected = new ulong[] { 0, 1, 0, 0, 0, 0, 0, 0, 0 };
        VerboseCollectionAssert.AreEqual(expected, state_after_the_second_day);
    }

    // After another day, its internal timer would become 1.
    [TestMethod]
    public void OneFishAfterThreeDays()
    {
        var start_state = new ulong[] { 0, 1, 0, 0, 0, 0, 0, 0, 0 };

        // After the second day
        var state_after_the_second_day = new BusinessLogicPartTwo().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        var expected = new ulong[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 };
        CollectionAssert.AreEqual(expected, state_after_the_second_day);
    }


    // After another day, its internal timer would become 1.
    [TestMethod]
    public void OneFishAfterTheFourthDay()
    {
        var start_state = new ulong[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 };

        // After the second day
        var state_after_the_fourth_day = new BusinessLogicPartTwo().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        var expected = new ulong[] { 0, 0, 0, 0, 0, 0, 1, 0, 1 };
        VerboseCollectionAssert.AreEqual(expected, state_after_the_fourth_day);
    }

    /// <summary>
    /// Initial state: 3,4,3,1,2
    /// After  1 day:  2,3,2,0,1
    /// </summary>
    [TestMethod]
    public void ExampleDataAfterOneDay()
    {
        // var start_state = new[] { 3, 4, 3, 1, 2 };
        var start_state = new ulong[] { 0, 1, 1, 2, 1, 0, 0, 0, 0 };

        // After the second day
        var after_one_day = new BusinessLogicPartTwo().OneDayPasses(start_state).ToArray();

        // its internal timer would become 1.
        // var expected = new ulong[] { 0, 1, 1, 2, 1, 0, 0, 0, 0, 0 };
        var expected = new ulong[] { 1, 1, 2, 1, 0, 0, 0, 0, 0 };
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
        // var after_one_day = new[] { 2, 3, 2, 0, 1 };
        var after_one_day = new ulong[] { 1, 1, 2, 1, 0, 0, 0, 0, 0 };

        // After the second day
        var after_two_days = new BusinessLogicPartTwo().OneDayPasses(after_one_day).ToArray();

        // from the example data, this is the expected data after two days. There is now
        // a "6" and an "8".
        // var expected = new[] { 1, 2, 1, 6, 0, 8 };
        var expected = new ulong[] { 1, 2, 1, 0, 0, 0, 1, 0, 1 };
        VerboseCollectionAssert.AreEqual(expected, after_two_days);
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
        // var initial_state = new[] { 3, 4, 3, 1, 2 };
        var initial_state = new ulong[] { 0, 1, 1, 2, 1, 0, 0, 0, 0 };

        // After the second day
        var after_eighteen_days = new BusinessLogicPartTwo().MultipleDaysPass(initial_state, 18).ToArray();

        // from the example data, this is the expected data after two days
        var expected = new[] { 6, 0, 6, 4, 5, 6, 0, 1, 1, 2, 6, 0, 1, 1, 1, 2, 2, 3, 3, 4, 6, 7, 8, 8, 8, 8 };
        Assert.AreEqual(expected.Length, after_eighteen_days.Sum(a => (int)a));
    }

    /// <summary>
    /// Check that the conversion from part one to part two works correctly.
    /// </summary>
    [TestMethod]
    public void ConvertToPartTwo()
    {
        var part_one = new[] { 3, 4, 3, 1, 2 };
        var expected = new ulong[] { 0, 1, 1, 2, 1, 0, 0, 0, 0 };

        var part_two = BusinessLogicPartTwo.ConvertPartOnePuzzleDataToPartTwoFormat(part_one);

        VerboseCollectionAssert.AreEqual(expected, part_two);
    }

    /// <summary>
    /// Using the test data, run the simulation for 256 days.
    /// </summary>
    [TestMethod]
    public void TestDataAfter80Days()
    {
        // From the example data, this is the state after one day
        var initial_state = new[] { 3, 5, 3, 5, 1, 3, 1, 1, 5, 5, 1, 1, 1, 2, 2, 2, 3, 1, 1, 5, 1, 1, 5, 5, 3, 2, 2, 5, 4, 4, 1, 5, 1, 4, 4, 5, 2, 4, 1, 1, 5, 3, 1, 1, 4, 1, 1, 1, 1, 4, 1, 1, 1, 1, 2, 1, 1, 4, 1, 1, 1, 2, 3, 5, 5, 1, 1, 3, 1, 4, 1, 3, 4, 5, 1, 4, 5, 1, 1, 4, 1, 3, 1, 5, 1, 2, 1, 1, 2, 1, 4, 1, 1, 1, 4, 4, 3, 1, 1, 1, 1, 1, 4, 1, 4, 5, 2, 1, 4, 5, 4, 1, 1, 1, 2, 2, 1, 4, 4, 1, 1, 4, 1, 1, 1, 2, 3, 4, 2, 4, 1, 1, 5, 4, 2, 1, 5, 1, 1, 5, 1, 2, 1, 1, 1, 5, 5, 2, 1, 4, 3, 1, 2, 2, 4, 1, 2, 1, 1, 5, 1, 3, 2, 4, 3, 1, 4, 3, 1, 2, 1, 1, 1, 1, 1, 4, 3, 3, 1, 3, 1, 1, 5, 1, 1, 1, 1, 3, 3, 1, 3, 5, 1, 5, 5, 2, 1, 2, 1, 4, 2, 3, 4, 1, 4, 2, 4, 2, 5, 3, 4, 3, 5, 1, 2, 1, 1, 4, 1, 3, 5, 1, 4, 1, 2, 4, 3, 1, 5, 1, 1, 2, 2, 4, 2, 3, 1, 1, 1, 5, 2, 1, 4, 1, 1, 1, 4, 1, 3, 3, 2, 4, 1, 4, 2, 5, 1, 5, 2, 1, 4, 1, 3, 1, 2, 5, 5, 4, 1, 2, 3, 3, 2, 2, 1, 3, 3, 1, 4, 4, 1, 1, 4, 1, 1, 5, 1, 2, 4, 2, 1, 4, 1, 1, 4, 3, 5, 1, 2, 1 };
        var state_part_two = BusinessLogicPartTwo.ConvertPartOnePuzzleDataToPartTwoFormat(initial_state);

        // After the second day
        var after_80_days = new BusinessLogicPartTwo().MultipleDaysPass(state_part_two, 80).ToArray();

        // this is the puzzle answer
        Assert.AreEqual(365862u, BusinessLogicPartTwo.CountFishes(after_80_days));
    }

    /// <summary>
    /// Using the test data, run the simulation for 256 days.
    /// </summary>
    [TestMethod]
    public void ExampleDataAfter256Days()
    {
        // From the example data, this is the initial state
        var part_one = new[] { 3, 4, 3, 1, 2 };
        var state_part_two = BusinessLogicPartTwo.ConvertPartOnePuzzleDataToPartTwoFormat(part_one);

        // After 256 days
        var after_256_days = new BusinessLogicPartTwo().MultipleDaysPass(state_part_two, 256).ToArray();

        // this is the puzzle answer
        Assert.AreEqual(26984457539u, BusinessLogicPartTwo.CountFishes(after_256_days));
    }

    /// <summary>
    /// Using the test data, run the simulation for 256 days.
    /// </summary>
    [TestMethod]
    public void TestDataAfter256Days()
    {
        // From the example data, this is the state after one day
        var initial_state = new[] { 3, 5, 3, 5, 1, 3, 1, 1, 5, 5, 1, 1, 1, 2, 2, 2, 3, 1, 1, 5, 1, 1, 5, 5, 3, 2, 2, 5, 4, 4, 1, 5, 1, 4, 4, 5, 2, 4, 1, 1, 5, 3, 1, 1, 4, 1, 1, 1, 1, 4, 1, 1, 1, 1, 2, 1, 1, 4, 1, 1, 1, 2, 3, 5, 5, 1, 1, 3, 1, 4, 1, 3, 4, 5, 1, 4, 5, 1, 1, 4, 1, 3, 1, 5, 1, 2, 1, 1, 2, 1, 4, 1, 1, 1, 4, 4, 3, 1, 1, 1, 1, 1, 4, 1, 4, 5, 2, 1, 4, 5, 4, 1, 1, 1, 2, 2, 1, 4, 4, 1, 1, 4, 1, 1, 1, 2, 3, 4, 2, 4, 1, 1, 5, 4, 2, 1, 5, 1, 1, 5, 1, 2, 1, 1, 1, 5, 5, 2, 1, 4, 3, 1, 2, 2, 4, 1, 2, 1, 1, 5, 1, 3, 2, 4, 3, 1, 4, 3, 1, 2, 1, 1, 1, 1, 1, 4, 3, 3, 1, 3, 1, 1, 5, 1, 1, 1, 1, 3, 3, 1, 3, 5, 1, 5, 5, 2, 1, 2, 1, 4, 2, 3, 4, 1, 4, 2, 4, 2, 5, 3, 4, 3, 5, 1, 2, 1, 1, 4, 1, 3, 5, 1, 4, 1, 2, 4, 3, 1, 5, 1, 1, 2, 2, 4, 2, 3, 1, 1, 1, 5, 2, 1, 4, 1, 1, 1, 4, 1, 3, 3, 2, 4, 1, 4, 2, 5, 1, 5, 2, 1, 4, 1, 3, 1, 2, 5, 5, 4, 1, 2, 3, 3, 2, 2, 1, 3, 3, 1, 4, 4, 1, 1, 4, 1, 1, 5, 1, 2, 4, 2, 1, 4, 1, 1, 4, 3, 5, 1, 2, 1 };
        var state_part_two = BusinessLogicPartTwo.ConvertPartOnePuzzleDataToPartTwoFormat(initial_state);

        // After the second day
        var after_256_days = new BusinessLogicPartTwo().MultipleDaysPass(state_part_two, 256).ToArray();

        // this is the puzzle answer
        Assert.AreEqual(1653250886439u, BusinessLogicPartTwo.CountFishes(after_256_days));
    }
}