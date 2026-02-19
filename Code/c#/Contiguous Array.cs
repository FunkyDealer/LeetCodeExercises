/*
Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.
*/


public class Solution {
    public int FindMaxLength(int[] nums) {
        
        int length = nums.Length;
        if (length < 2) return 0;    
        int numZero = 0; //number of zeros
        int numOne = 0; //number of ones
        int result = 0;

        Dictionary<int,int> diff = new Dictionary<int,int>(); //hash map

        for (int i = 0; i < length; i++) {

            if (nums[i] == 0) numZero++;
            else numOne++; 

            int r = numOne - numZero;
            if (!diff.ContainsKey(r)) diff.Add(r, i);


            if (numOne == numZero) result = numOne + numZero;
            else {
                int index = diff[r];
                result = Math.Max(result, i-index);
            }
        }        
        return result;
    }
}