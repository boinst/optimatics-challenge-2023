using System.Xml;

namespace tests.ben.Day09;

public class BusinessLogicPartOne
{
    public static int CalculateRiskLevel(int i)
    {
        return i + 1;
    }

    /// <summary>
    /// Enumerate the low points in the heightmap.
    /// </summary>
    public static IEnumerable<int[]> enumerate_low_points(int[,] data)
    {
        // Index of the last element in the first dimension
        var x_max = Length_X(data);

        // Index of the last element in the second dimension
        var y_max = Length_Y(data);

        for (var x = 0; x < x_max; ++x)
        for (var y = 0; y < y_max; ++y)
        {
            var candidate = new[] { x, y };
            if (IsLowPoint(data, candidate))
                yield return candidate;
        }

    }

    /// <summary>
    /// Count the number of low points in a given data set.
    /// </summary>
    public static int CountLowPoints(int[,] data)
    {
        return enumerate_low_points(data).Count();
    }

    
    private const int index_of_y_dimension = 0;
    private const int index_of_x_dimension = 1;

    public static bool IsLowPoint(int[,] data, int[] coordinates)
    {
        var x = coordinates[0];
        var y = coordinates[1];

        // Index of the last element in the first dimension
        var x_max = Max_X_Index(data);

        // Index of the last element in the second dimension
        var y_max = Max_Y_Index(data);

        var element_under_test = data[y, x];

        // left element is smaller than the target element
        if (x > 0)
        {
            var left_element = data[y, x - 1];
            if (left_element < element_under_test) 
                return false;

         //   if (left_element == element_under_test)
        //        throw new Exception(
        //            $"Unexpected! At coordinates ({x},{y}), the item to the left is identical to the element under test.");
        }

        // right element is smaller than the target element
        if (x < x_max)
        {
            var right_element = data[y, x + 1];
            if (right_element < element_under_test) 
                return false;
        }
        
        // element above is smaller than the target element
        if (y > 0)
        {
            var above_element = data[y - 1, x];
            if (above_element < element_under_test) 
                return false;
        }
        
        // element below is smaller than the target element
        if (y < y_max)
        {
            var below_element = data[y + 1, x];
            if (below_element < element_under_test) 
                return false;
        }
        
        return true;
    }

    public static int Max_X_Index(int[,] data)
    {
        // Index of the last element in the first dimension
        return data.GetLength(index_of_x_dimension) - 1;
    }

    public static int Max_Y_Index(int[,] data)
    {
        return data.GetLength(index_of_y_dimension) - 1;
    }
    
    public static int Length_X(int[,] data)
    {
        return data.GetLength(index_of_x_dimension);
    }
    public static int Length_Y(int[,] data)
    {
        return data.GetLength(index_of_y_dimension);
    }

    /// <summary>
    /// Parse the input data
    /// </summary>
    public static int[,] ParseData(string s)
    {
        var lines = s.Split("\r\n");
        var n_lines = lines.Length;
        var n_chars = lines[0].Length;

        var result = new int[n_lines, n_chars];

        for (var x = 0; x < n_chars; ++x)
        for (var y = 0; y < n_lines; ++y)
        {
            var str_val = lines[y].ToCharArray()[x];
            var str2_val = str_val.ToString();
            var int_val = int.Parse(str2_val);

            result[y, x] = int_val;
        }

        return result;
    }

    /// <summary>
    /// Given a height map, cancl
    /// </summary>
    /// <param name="height_map"></param>
    /// <returns></returns>
    public static int SumOfRiskLevelOfAllLowPoints(int[,] height_map)
    {
        var low_points = enumerate_low_points(height_map);
        return low_points.Sum(p => CalculateRiskLevel(height_map[p[1],p[0]]));
    }
}