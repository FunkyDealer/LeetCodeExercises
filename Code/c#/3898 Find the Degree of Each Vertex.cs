/*
You are given a 2D integer array matrix of size n x n representing the adjacency matrix of an undirected graph with n vertices labeled from 0 to n - 1.

    matrix[i][j] = 1 indicates that there is an edge between vertices i and j.
    matrix[i][j] = 0 indicates that there is no edge between vertices i and j.

The degree of a vertex is the number of edges connected to it.

Return an integer array ans of size n where ans[i] represents the degree of vertex i.
*/

public class Solution {
    public int[] FindDegrees(int[][] matrix) {

        int[] ans = new int[matrix[0].Length];        

        for (int i = 0; i < matrix[0].Length; i++)
        {            
            int count = 0;
            if (matrix.Length > 1) {
            for (int j = 0; j < matrix[1].Length; j++)
            {
                if (matrix[i][j] == 1) count++;
            }
            }
            
            ans[i] = count;
        }

        return ans;
    }
}