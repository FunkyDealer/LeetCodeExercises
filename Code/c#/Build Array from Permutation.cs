/*
Given a zero-based permutation nums (0-indexed), build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.

A zero-based permutation nums is an array of distinct integers from 0 to nums.length - 1 (inclusive).
*/

public class Solution {
    public int[] BuildArray(int[] nums) {
        
        int count = nums.Length;
        int[] ans = new int[count];

        for( int x = 0; x < count; x++) {
            ans[x] = nums[nums[x]];
        }

        return ans;
    }
}