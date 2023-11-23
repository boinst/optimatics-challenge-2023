namespace tests.ben.Day06;

/// <summary>
/// This class captures the business logic for the problem
/// https://adventofcode.com/2021/day/6
/// Part 1
/// </summary>
public class BusinessLogicPartTwo
{
    public static ulong[] ConvertPartOnePuzzleDataToPartTwoFormat(int[] part_one_data)
    {
        var new_state = new ulong[9];
        foreach (var fish in part_one_data)
        {
            new_state[fish]++;
        }

        return new_state;
    }

    public static ulong CountFishes(ulong[] state)
    {
        ulong count = 0;
        for (var i = 0; i < 9; i++)
        {
            count += state[i];
        }

        return count;
    }

    public ulong[] OneDayPasses(ulong[] old_state)
    {
        if (old_state.Length != 9)
            throw new ArgumentException($"Expected parameter \"{nameof(old_state)}\" to have exactly 9 elements, but it has {old_state.Length} elements.", nameof(old_state));

        var new_state = new ulong[9];


        // decrement the internal counter for any other fish.
        for (var i = 1; i < 9; i++)
        {
            new_state[i - 1] = old_state[i];   
        }

        // Record the number of baby fish spawned
        var number_of_baby_fish = old_state[0];
        new_state[8] = number_of_baby_fish;

        // And reset the parents, too
        new_state[6] += number_of_baby_fish;
        
        return new_state;
    }

    
    public ulong[] MultipleDaysPass(ulong[] initialState, int days)
    {
        var state = initialState.ToArray();
        for (var i = 0; i < days; i++)
        {
            state = OneDayPasses(state);
        }
        return state;
    }
}