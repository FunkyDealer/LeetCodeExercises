/*
Given a m x n matrix grid which is sorted in non-increasing order both row-wise and column-wise, return the number of negative numbers in grid.
*/

public class Solution {

    //input - Grid
    //wants to count negative numbers in grid
    //output integer of ammount of negative numbers

    //bruteforece: 2 loops, go through each grid element and count negative
    //optimization 1: go throught grid in reverse

    public int CountNegatives(int[][] grid) {
        int res = 0;

        if (grid[grid.Length - 1][grid[0].Length - 1] >= 0) return 0;        

        for (int x = grid.Length - 1; x >= 0; x--)
        {
            if (grid[x][grid[0].Length - 1] >= 0) continue;
            
            for (int y = grid[0].Length - 1; y >= 0; y--)
            {
                //Console.Write($" {grid[x][y]} ");
                if (grid[x][y] < 0) res++;
                else { break; }
            }
            //Console.WriteLine();
        }

        return res;
    }
}