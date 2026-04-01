/*
You are given an integer array nums of size n. For each index i where 0 <= i < n, define a nums[start ... i] where start = max(0, i - nums[i]).

Return the total sum of all elements from the subarray defined for each index in the array.
*/

public class Solution {
    public int SubarraySum(int[] nums) {

        int sum = nums[0], i, j, start;

        for (i = 1; i < nums.Length; i++)
        {
            start = Math.Max(0, i - nums[i]);
            for (j = start; j <= i; j++) {
                sum += nums[j];
            }
        }

        return sum;
    }
}