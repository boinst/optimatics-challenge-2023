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

    //get all the neighbors of a point
    public static List<int> getNeighbors(int[,] heightMap, int row, int col)
    {
        // dynamic length array for neighbors
        List<int> neighbors = new List<int>();
        int numRows = heightMap.GetLength(0);
        int numCols = heightMap.GetLength(1);

        //up
        if (row - 1 >= 0)
        {
            neighbors.Add(heightMap[row - 1, col]);
        }

        //down
        if (row + 1 < numRows)
        {
            neighbors.Add(heightMap[row + 1, col]);
        }

        //left
        if (col - 1 >= 0)
        {
            neighbors.Add(heightMap[row, col - 1]);
        }

        //right
        if (col + 1 < numCols)
        {
            neighbors.Add(heightMap[row, col + 1]);
        }


        return neighbors;
    }
}
