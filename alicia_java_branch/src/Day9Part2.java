public class Day9Part2 {
    //DFS wrapper, Time O(m*n), Space O(m*n), m is number of rows, n is number of columns
    public static int numOfBasins(int[][] mat) {
        int m = mat.length, n = mat[0].length;
        if (mat == null || m == 0 || n == 0)
            return 0;
        int count = 0;
        boolean[][] visited = new boolean[m][n]; //as memo
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 1) {
                    count++;
                    dfs(mat, i, j, visited);
                }
            }
        }
        return count;
    }

    //DFS + memoization, Time O(4) ~ O(1), Space O(1), 4 directions is constant
    private static void dfs(int[][] mat, int i, int j, boolean[][] visited) {
        int m = mat.length,  n = mat[0].length;
        if (i < 0 || j < 0 || i > m-1 || j > n-1 || visited[i][j])
            return;
        if (mat[i][j] != 1)
            return;
        mat[i][j] = 0;
        visited[i][j] = true;
        dfs(mat, i-1, j, visited); //left
        dfs(mat, i+1, j, visited); //right
        dfs(mat, i, j-1, visited); //upper
        dfs(mat, i, j+1, visited); //lower
    }

    public static void SplitInput(String input) {

        int[][] matrix = {{0,1,0,1,0},
                {0,1,0,0,1},
                {0,1,1,0,1}
        };
        System.out.println("number of Basins: " + numOfBasins(matrix));
    }

}
