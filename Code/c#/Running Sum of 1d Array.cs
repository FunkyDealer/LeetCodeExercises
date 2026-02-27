/*
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums.
*/

public class Solution {
    public int[] RunningSum(int[] nums) {
        
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i-1];
        }

        return nums;
    }
}
