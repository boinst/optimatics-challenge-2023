import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Main {
    static int sumOfLowPoints;
    static List<Integer> lowPointList = new ArrayList<Integer>();
    static int[][] heightmapMatrix;
    static int rowSize;
    static int columnSize;

    public static int iteratingMatrix(String input) {

        heightmapMatrix = splitInput(input);
        rowSize = heightmapMatrix.length;
        columnSize = heightmapMatrix[0].length;
        sumOfLowPoints = 0;

        for (int i = 0; i < heightmapMatrix.length; i++) {
            for (int j = 0; j < heightmapMatrix[0].length; j++) {

                boolean isLowPoint = isLowPoint(i, j);
                if (isLowPoint) {
                    lowPointList.add(heightmapMatrix[i][j]);
                    sumOfLowPoints = sumOfLowPoints + heightmapMatrix[i][j] + 1;
                }

            }
        }

        return sumOfLowPoints;
    }

    public static int[][] splitInput(String inputString) {

        String[] rowArray = inputString.split("\n");
        heightmapMatrix = new int[rowArray.length][];
        try {
            int r = 0;
            for (String row : rowArray) {
                String[] itemsArray = row.replaceAll("\\[", "").replaceAll("\\]", "").replaceAll("\\s", "").split("");
                int[] results = new int[itemsArray.length];

                for (int i = 0; i < itemsArray.length; i++) {
                    try {
                        results[i] = Integer.parseInt(itemsArray[i]);
                    } catch (NumberFormatException ignored) {

                    }
                    ;
                }

                heightmapMatrix[r++] = results;
            }

        } catch (NumberFormatException ignored) {

        }

        System.out.println(Arrays.deepToString(heightmapMatrix));

        return heightmapMatrix;
    }

    static List<Integer> getAdjacent(int rowIndex, int columnIndex) {

        List<Integer> adjacentsList = new ArrayList<>();

        if (rowIndex - 1 >= 0) {
            adjacentsList.add(heightmapMatrix[rowIndex - 1][columnIndex]);
        }

        if (columnIndex - 1 >= 0) {
            adjacentsList.add(heightmapMatrix[rowIndex][columnIndex - 1]);
        }

        if (columnIndex + 1 < columnSize) {
            adjacentsList.add(heightmapMatrix[rowIndex][columnIndex + 1]);
        }

        if (rowIndex + 1 < rowSize) {
            adjacentsList.add(heightmapMatrix[rowIndex + 1][columnIndex]);
        }

        // Returning the arraylist of adjacent
        return adjacentsList;
    }

    private static boolean isLowPoint(int rowIndex, int columnIndex) {

        List<Integer> adjacentList = getAdjacent(rowIndex, columnIndex);
        Integer minValue = Collections.min(adjacentList);

        return minValue > heightmapMatrix[rowIndex][columnIndex];
    }
}