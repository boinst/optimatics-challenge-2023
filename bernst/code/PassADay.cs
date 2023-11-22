namespace code;

public class PassADay
{
    public static int passADay(int internalValue)
    {
        return internalValue - 1;
    }

    public static int[] passADay(int[] internalValue)
    {
        var returnValues = new List<int>();
        int newFishCount = 0;
        for (int i = 0; i < internalValue.Length; i++)
        {
            if (internalValue[i] == 0)
            {
                //internalValue[i] = 6;
                returnValues.Add(6);
                newFishCount++;
            }
            else
            {
                returnValues.Add(internalValue[i] - 1);
            }
        }
        for (int j = 0; j < newFishCount; j++)
        {
            returnValues.Add(8);
        }

        return returnValues.ToArray();
    }


    public static int[] passDays(int days, int[] fishes)
    {

        for (int i = 0; i < days; i++)
        {
            fishes = passADay(fishes);
        }

        return fishes;
    }
}
