/*
Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

Specifically, ans is the concatenation of two nums arrays.

Return the array ans.
*/

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int count = nums.Length; //count nums
        int[] ans = new int[count * 2]; //create ans, which should be double the size of nums

        for (int y = 0; y < 2; y++) //go through length of num, Twice
        {  
           for (int x =  0; x < count; x++) //go through length of nums
              { 
                 ans[x + count * y] = nums[x];    //insert nums[x] in ans[x plus the count time y]      
              }
        }
        return ans;
    }
}