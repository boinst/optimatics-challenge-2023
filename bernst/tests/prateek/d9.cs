using System.Runtime.InteropServices;

namespace tests.prateek._2021D6;

public class D9{
    public int getLowPoint(int[] heightMap){
        int lowPoint = -1;
        int currentPoint = -1;
        // Assuming Left, Right, Up, Down order in existingPoints
        int[] neighbouringPoint = new int[] {-1, -1, -1, -1};    
        bool[] existingNeighbouringPoint = new bool[] {false, false, false, false};

        if(heightMap.Length == 1){
            lowPoint = heightMap[0];
            return lowPoint;
        }

        for(int heightMapIndex = 0; heightMapIndex < heightMap.Length; heightMapIndex++){
            currentPoint = heightMap[heightMapIndex];

            // Checking if Right point exist
            if((heightMapIndex + 1) < heightMap.Length){
                existingNeighbouringPoint[1] = true;
                neighbouringPoint[1] = heightMap[heightMapIndex + 1];
            }

            // Checking if Left point exists
            if((heightMapIndex - 1) >= 0){
                existingNeighbouringPoint[0] = true;
                neighbouringPoint[0] = heightMap[heightMapIndex - 1];
            }

            // Setting lowPoint if it is lowest compared to its neighbors
            for(int neighbourIndex = 0; neighbourIndex < 4; neighbourIndex++){
                if(existingNeighbouringPoint[neighbourIndex]){
                    if(currentPoint < neighbouringPoint[neighbourIndex]){
                        lowPoint = currentPoint;
                    }
                }
            }
        }      
        return lowPoint;
    }
}