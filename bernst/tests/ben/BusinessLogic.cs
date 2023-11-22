namespace tests.ben;

// This class captures the business logic for the probelm
public class BusinessLogic
{
    public IEnumerable<int> OneDayPasses(IEnumerable<int> state)
    {
        foreach (var item in state)
        {
            if (item == 0)
            {
                yield return 6;
                yield return 8;
            }
            else
            {
                yield return item - 1;
            }
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