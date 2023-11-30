import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.*;

class Day9Part2Test extends Main {

    @Test
    @DisplayName("Test count number of Basins")
    void numOfBasins() {
    }


    @org.junit.jupiter.api.Test
    @DisplayName("Test split rows from input")
    void splitInput() {
//        String input = "161487713\n" +
//                        "057937213";
//        int[][] output = {{1, 6, 1, 4, 8, 7, 7, 1, 3},{0, 5, 7, 9, 3, 7, 2, 1, 3}};
//        assertTrue(Arrays.deepEquals(output, Main.splitInput(input)));

        String input = "01010\n" +
                        "01001\n"+
                        "01101";

        int[][] output = {{0, 1, 0, 1, 0},{0,1,0,0,1} ,{0,1,1,0,1}};
        assertTrue(Arrays.deepEquals(output, Main.splitInput(input)));


    }

//    @Test
//    @DisplayName("Test 1D Matrix")
//    void iterating1DMatrix() {
//        String input = "019876"; //   basin1 =[0,1]   basin2=[8,7,6]
//        assertEquals(8, Day9Part2.iteratingMatrix(input));
//    }
//
//
//    @Test
//    @DisplayName("Test 2D Matrix")
//    void iterating2DMatrix() {
//        String input = "019876\n" +
//                "402564"; // 0,0,4 are low points
//        assertEquals(7, Day9Part2.iteratingMatrix(input));
//    }
}