namespace code;

public class Calculator
{

    public static int sum (List<int> lowPoints)
    {
        int sum = 0;
        foreach (int lowPoint in lowPoints)
        {
            int value = lowPoint+1;
            sum += value;
        }
        return sum;
    }
}