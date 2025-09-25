/*
Given a triangle array, return the minimum path sum from top to bottom.

For each step, you may move to an adjacent number of the row below.
More formally, if you are on index i on the current row, you may move to either index i or index i + 1 on the next row.
*/

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) 
    {        
        int layerCount = triangle.Count; //triangle layer count

        int[] minPathSum = new int[layerCount + 1]; //minPath sum for each number on the bottom row
        
        for (int x = layerCount - 1; x >= 0; x--) //go through each layer in reverse
        {
            int ammount = triangle[x].Count; //amount of values in layer

            for (int y = 0; y < ammount; y++) //go through each value in layer 
            {
                minPathSum[y] = Math.Min(minPathSum[y], minPathSum[y + 1]) + triangle[x][y]; //get the minimum and add it 
            }
        }
        return minPathSum[0];
    }
}