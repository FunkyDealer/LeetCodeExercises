/*
You are given an m x n integer matrix matrix with the following two properties:

    Each row is sorted in non-decreasing order.
    The first integer of each row is greater than the last integer of the previous row.

Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.
*/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int lowX = 0;
        int highX = matrix.GetLength(0) - 1;

        //binary search on matrix
        while (lowX <= highX)
        {
            int mid = lowX + (highX - lowX) / 2;

            int row = IsInRow(matrix[mid], target);

            if (row == target) return true;

            if (row > target) {
                highX = mid - 1;
            }
            
            if (row < target) {
                lowX = mid + 1;
            }
        }

        return false;
    }

    //binary search each row
    public int IsInRow(int[] row, int target) {

        int low = 0;
        int high = row.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (row[mid] == target) return target;

            if (row[mid] > target) {
                high = mid - 1;
            }

            if (row[mid] < target) {
                low = mid + 1;
            }
        }
        
        if (target > row[row.Length-1]) return row[row.Length-1];
        return row[0];
    }
}