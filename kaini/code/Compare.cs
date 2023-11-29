namespace code;

public class Compare
{
    public static bool isSmallest(int currentPoint, int[] neighbors)
    {
        foreach (int neighbor in neighbors)
        {
            if (neighbor < currentPoint)
            {
                return false;
            }
        }
        return true;
    }
}
