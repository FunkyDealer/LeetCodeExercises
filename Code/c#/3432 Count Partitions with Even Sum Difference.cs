/*
You are given an integer array nums of length n.

A partition is defined as an index i where 0 <= i < n - 1, splitting the array into two non-empty subarrays such that:

    Left subarray contains indices [0, i].
    Right subarray contains indices [i + 1, n - 1].

Return the number of partitions where the difference between the sum of the left and right subarrays is even.
*/

public class Solution {
    public int CountPartitions(int[] nums) {
        
        int res = 0;

        //calculate prefix
        int[] prefix = new int[nums.Length];

        prefix[0] = nums[0]; //first element is the same
        for (int i = 1; i < nums.Length; i++) {

            prefix[i] = nums[i] + prefix[i - 1]; //prefix i element is nums element + previous prefix element
        }

        //partition 1 is prefix[i]
        //partition 2 is prefix's last element minus prefix[i]
        //if the difference is even, add to result
        for (int i = 0; i < nums.Length - 1; i++)  if ((prefix[i] - (prefix[nums.Length - 1] - prefix[i])) % 2 == 0) res++;

        return res;
    }
}