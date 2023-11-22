namespace code;

public class DayTwo
{
    public static int[] dayTwo(int days, int[] fishes)
    {
        var compressedFishes = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        for (int i = 0; i < fishes.Length; i++)
        {
            switch (fishes[i])
            {
                case 0:
                    compressedFishes[0]++;
                    break;
                case 1:
                    compressedFishes[1]++;
                    break;
                case 2:
                    compressedFishes[2]++;
                    break;
                case 3:
                    compressedFishes[3]++;
                    break;
                case 4:
                    compressedFishes[4]++;
                    break;
                case 5:
                    compressedFishes[5]++;
                    break;
                case 6:
                    compressedFishes[6]++;
                    break;
                case 7:
                    compressedFishes[7]++;
                    break;
                case 8:
                    compressedFishes[8]++;
                    break;
                default:
                    break;
            }
        }
        for (int j = 0; j < days; j++)
        {
            int firstElement = compressedFishes[0];

            // each fish shifts a position after one day, from 8 to 0 reducing 1
            compressedFishes[0] = compressedFishes[1];
            compressedFishes[1] = compressedFishes[2];
            compressedFishes[2] = compressedFishes[3];
            compressedFishes[3] = compressedFishes[4];
            compressedFishes[4] = compressedFishes[5];
            compressedFishes[5] = compressedFishes[6];
            compressedFishes[6] = firstElement + compressedFishes[7]; // 0 becomes 6, state 7 becomes state 6
            compressedFishes[7] = compressedFishes[8]; // state 8 becomes state 7
            compressedFishes[8] = firstElement; // new state 8 from state 0
        }
        
        return compressedFishes;
    }



    public static int count(int[] fishes)
    {
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += fishes[i];
        }
        return sum;
    }
}