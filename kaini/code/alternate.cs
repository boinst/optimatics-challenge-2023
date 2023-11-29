// namespace code;

// public class Alternative
// {
//     public static bool isSmallest(int currentPoint, int[] neighbors)
//     {
//         if( IsEqualToNeighbours(currentPoint, neighbors))
//             return false;
//         return IsSmallerThanNeighbours(currentPoint, neighbors);
//     }


//     public static bool IsSmallerThanNeighbours(int currentPoint, int[] neighbors)
//     {
//         foreach (int neighbor in neighbors)
//         {
//             if (neighbor < currentPoint)
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
       
//     public static bool IsEqualToNeighbours(int currentPoint, int[] neighbors)
//     {
//         foreach (int neighbor in neighbors)
//         {
//             if (neighbor != currentPoint)
//             {
//                 return false;
//             }
//         }
//         return true;
//     }

//     public static bool HasLeftNeighbour(int[,] heightMap, int col)
//     {
//         return col - 1 >= 0;
//     }
//     //get all the neighbors of a point
//     public static List<int> getNeighbors(int[,] heightMap, int row, int col)
//     {
//         // dynamic length array for neighbors
//         List<int> neighbors = new List<int>();
//         int numRows = heightMap.GetLength(0);
//         int numCols = heightMap.GetLength(1);

//         //up
//         if (row - 1 >= 0)
//         {
//             neighbors.Add(heightMap[row - 1, col]);
//         }

//         //down
//         if (row + 1 < numRows)
//         {
//             neighbors.Add(heightMap[row + 1, col]);
//         }

//         //left
//         if (HasLeftNeighbour(heightMap, col))
//         {
//             neighbors.Add(heightMap[row, col - 1]);
//         }

//         //right
//         if (col + 1 < numCols)
//         {
//             neighbors.Add(heightMap[row, col + 1]);
//         }

//         return neighbors;
//     }

//     public static List<int> Results(int[,] heightMap)
//     {
//         int numRows = heightMap.GetLength(0);
//         int numCols = heightMap.GetLength(1);
//         List<int> result = new List<int>();

//         for (int row = 0; row < numRows; row++)
//         {
//             for (int col = 0; col < numCols; col++)
//             {
//                 if(HasLowerOrEqualLeftNeighbour(heightMap, row, col)) continue;
//                 if(HasLowerOrEqualRightNeighbour(heightMap, row, col)) continue;
//                 if(HasLowerOrEqualUpNeighbour(heightMap, row, col)) continue;
//                 if(HasLowerOrEqualDownNeighbour(heightMap, row, col)) continue;
//                 result.Add(heightMap[row, col]);
//             }
//         }
//         return result;
//     }
// }
// public static bool HasLowerOrEqualLeftNeighbour(heightMap,row,col){
//     //We consider everything outside the grid to be infinite height
//     if(!HasLeftNeighbour(heightMap, col))
//         return false;
//     return heightMap[row, col - 1] <= heightMap[row, col];
// }
