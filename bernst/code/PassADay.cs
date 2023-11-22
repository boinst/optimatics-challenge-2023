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
        for (int i = 0; i < internalValue.Length; i++)
        {
            if (internalValue[i] == 0)
            {
                //internalValue[i] = 6;
                returnValues.Add(6);
                returnValues.Add(8);
            }
            else
            {
                returnValues.Add(internalValue[i] - 1);
            }
        }

        return returnValues.ToArray();
    }
}
