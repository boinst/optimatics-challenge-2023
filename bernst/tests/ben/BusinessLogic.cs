namespace tests.ben;

// This class captures the business logic for the probelm
public class BusinessLogic
{
    public IEnumerable<int> OneDayPasses(IEnumerable<int> state)
    {
        foreach (var item in state)
        {
            yield return item - 1;
        }
    }
}