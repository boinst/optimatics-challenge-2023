namespace tests.ben.Day06;

/// <summary>
/// This class captures the business logic for the probelm
/// https://adventofcode.com/2021/day/6
/// Part 1
/// </summary>
public class BusinessLogicPartOne
{
    public IEnumerable<int> OneDayPasses(IEnumerable<int> state)
    {
        var number_of_baby_fish = 0;
        foreach (var item in state)
        {
            if (item == 0)
            {
                // Reset the current lanternfish to 6
                yield return 6;

                // Record the fact that a new fish needs to spawn
                ++number_of_baby_fish;
            }
            else
            {
                yield return item - 1;
            }
        }

        // Return any new fish that have spawned
        for (var i = 0; i < number_of_baby_fish; i++)
        {
            yield return 8;
        }
    }

    
    public IEnumerable<int> MultipleDaysPass(IEnumerable<int> initialState, int days)
    {
        var state = initialState.ToArray();
        for (int i = 0; i < days; i++)
        {
            state = OneDayPasses(state).ToArray();
        }
        return state;
    }
}