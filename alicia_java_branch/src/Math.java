import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Math {
   static int a, b;
    static int[][] matrix;
    static int[][] numbersArray;
    //    Math(int a, int b) {
//        Math.a = a;
//        Math.b = b;
//    }
    public static int add(int i, int i1) {
          return i + i1;
//        return a + b;
    }


    public static void main(String[] args) {

    }
    public static int[][] splitInput(String inputString){

        String[] rows = inputString.split("\n");
         matrix = new int[rows.length][];
        try{

            int r = 0;
            for (String row : rows) {
                String[] items = row.replaceAll("\\[", "").replaceAll("\\]", "").replaceAll("\\s", "").split("");
                int[] results = new int[items.length];

                for (int i = 0; i < items.length; i++) {
                    try {
                        results[i] = Integer.parseInt(items[i]);
                    } catch (NumberFormatException ignored) {

                    };
                }

                matrix[r++] = results;
            }

        } catch(NumberFormatException ignored){

                }

        System.out.println(Arrays.deepToString(matrix));


        return matrix;
    }


    public static int iteratingMatrix(String input){

        int[][] matrix = splitInput(input);

        int sum=0;
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[0].length; j++) {
                boolean isLowPoint = isLowPoint( i, j);
                if (isLowPoint) {
                    sum = sum + matrix[i][j]+1;
                }

            }
        }
        return sum;
    }



    // Function to check whether position is valid or not
    static boolean isValidPos(int rowIndex, int columnIndex, int rowSize, int columnSize)
    {
        if (rowIndex < 0 || columnIndex < 0 || rowIndex > rowSize - 1 || columnIndex > columnSize- 1) {
            return false;
        }
        return true;
    }

    static List<Integer>
    getAdjacent(int i, int j)
    {
        // Size of given 2d array
        int n = matrix.length;
        int m = matrix[0].length;

        // Initialising a array list where adjacent element
        // will be stored
        List<Integer> adjacents = new ArrayList<>();

        // Checking for all the possible adjacent positions

        if (isValidPos(i - 1, j, n, m)) {

            adjacents.add(matrix[i-1][j]);
        }

        if (isValidPos(i, j - 1, n, m)) {

            adjacents.add(matrix[i][j-1]);
        }
        if (isValidPos(i, j + 1, n, m)) {

            adjacents.add(matrix[i][j+1]);
        }

        if (isValidPos(i + 1, j, n, m)) {

            adjacents.add(matrix[i+1][j]);
        }


        // Returning the arraylist of adjacents
        return adjacents;
    }

    public static boolean comparetoAdjacents(List<Integer> adjacents,int rowIndex, int columnIndex ){
        boolean isLowpoint=false;
        for (Integer adjacent : adjacents) {
            if (adjacent > matrix[rowIndex][columnIndex]) {
                isLowpoint = true;

            } else {
                isLowpoint = false;
            }

        }

        return isLowpoint;

    }


    private static boolean isLowPoint( int rowIndex, int columnIndex) {

        int sum=0;
        List<Integer> adjacents= getAdjacent(rowIndex, columnIndex);

//            sum = sum + matrix[rowIndex][columnIndex]+1;
            return comparetoAdjacents(adjacents,rowIndex, columnIndex);



//        boolean isLowPoint = false;
//
//
//
//        if (rowIndex == 0){
//
//        }else {
//            if(rowIndex < lastRowIndex-1){
//                IsSmallerThanAboveValue(element, rowIndex, columnIndex)
//            } {
//                isLowPoint = true;
//            }else if(IsSmallerThanBelowValue(element, rowIndex, columnIndex)) {
//                isLowPoint = true;
//            }
//        }
//
//
//
//        if (rowIndex == 0) {
//
//        } else {
//            if (IsSmallerThanAboveValue(element, rowIndex, columnIndex)) {
//                System.out.println(element + "=TRue");
//                isLowPoint = true;
//            } else {
//                System.out.println(element + "=False");
//                isLowPoint = false;
//            }
//        }
//
//        if (columnIndex == 0) {
//
//        } else {
//
//
//            if (IsSmallerThanLeftValue(element, rowIndex, columnIndex)) {
//                System.out.println(element + "=TRue");
//                isLowPoint = true;
//            } else {
//                System.out.println(element + "=False");
//                isLowPoint = false;
//            }
//        }
//
//        if (columnIndex != lastColumnIndex - 1) {
//            if (IsSmallerThanRightValue(element, rowIndex, columnIndex) && IsSmallerThanBelowValue(element, rowIndex, columnIndex)) {
//                System.out.println(element + "=TRue");
//                isLowPoint = true;
//            } else {
//
//                isLowPoint = false;
//            }
//        } else {
//
//            if (rowIndex != lastRowIndex -1 ) {
//                if (IsSmallerThanBelowValue(element, rowIndex, columnIndex)) {
//                    System.out.println(element + "=TRue");
//                    isLowPoint = true;
//                } else isLowPoint = false;
//
//            }
//
//        }
//
//        return isLowPoint;
    }






    private static boolean IsSmallerThanAboveValue(int element, int rowIndex, int columnIndex) {
        try {
            return element < matrix[rowIndex - 1][columnIndex];
        } catch (NumberFormatException ignored) {
            return true;
        }


    }

    private static boolean IsSmallerThanBelowValue(int element, int rowIndex, int columnIndex) {
        try {
            return element < matrix[rowIndex + 1][columnIndex];
        } catch (NumberFormatException ignored) {
            return true;
        }


    }

    private static boolean IsSmallerThanLeftValue(int element, int rowIndex, int columnIndex) {

        try {
            return element < matrix[rowIndex][columnIndex - 1];
        } catch (NumberFormatException ignored) {
            return true;
        }


    }

    private static boolean IsSmallerThanRightValue(int element, int rowIndex, int columnIndex) {

        try {
            return element < matrix[rowIndex][columnIndex + 1];
        } catch (NumberFormatException ignored) {
            return true;
        }

    }


}