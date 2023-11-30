import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Day9Part2 {

    static int[][] heightmapMatrix;
    static int basinSize = 0;
    static List<Integer> basinSizeArr = new ArrayList<>();


    public static void getBasins(int[][] matrix) {
        int m = matrix.length, n = matrix[0].length;
        if (matrix == null || m == 0 || n == 0)
            return;
        int count = 0;
        boolean[][] visited = new boolean[m][n]; //as memo
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (matrix[i][j] != 9) {
                    count++;
                    basinSize = 0;
                    dfs(matrix, i, j, visited);
                    basinSizeArr.add(basinSize);
                }
            }
        }

    }


    private static void dfs(int[][] matrix, int i, int j, boolean[][] visited) {

        int m = matrix.length, n = matrix[0].length;
        if (i < 0 || j < 0 || i > m - 1 || j > n - 1 || visited[i][j])
            return;
        if (matrix[i][j] == 9)
            return;

        matrix[i][j] = 9;
        visited[i][j] = true;
        basinSize++;
        dfs(matrix, i - 1, j, visited); //left
        dfs(matrix, i + 1, j, visited); //right
        dfs(matrix, i, j - 1, visited); //upper
        dfs(matrix, i, j + 1, visited); //lower

    }


    public static int iteratingMatrix(String inputString) {

        heightmapMatrix = Main.splitInput(inputString);
        getBasins(heightmapMatrix);
        basinSizeArr.sort(Collections.reverseOrder());
        int multiplyResult = 1;
        for (int i = 0; i < basinSizeArr.size(); i++) {
            if (i < 3) multiplyResult *= basinSizeArr.get(i);
        }

        return multiplyResult;
    }


}