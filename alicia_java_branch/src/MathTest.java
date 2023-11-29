import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.*;

class MathTest {

    @org.junit.jupiter.api.Test
    @DisplayName("Add two numbers")
    void add() {
        assertEquals(4, Math.add(2, 2));
    }


    @org.junit.jupiter.api.Test
    @DisplayName("Test split rows from input")
    void splitInput() {
        String input = "161487713\n" +
                "057937213";
        int[][] output = {{1, 6, 1, 4, 8, 7, 7, 1, 3},{0, 5, 7, 9, 3, 7, 2, 1, 3}};
        assertTrue(Arrays.deepEquals(output, Math.splitInput(input)));
       // assertSame({{16   , 14   ,  8  ,  7  ,  7 , 13 , 18  , 13  ,  13}}, Math.splitInput("16   14   8   7    7  13  18  13   13"));
    }


    @org.junit.jupiter.api.Test
    @DisplayName("Test iterating Matrix")
    void iteratingMatrix() {
        String input2 = "16148\n" +
                       "05793"; // 0,1,3  are low points
        assertEquals(4, Math.iteratingMatrix(input2));
    }
}