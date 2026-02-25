/*
Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.
*/


public class Solution {
    public int SubarraySum(int[] nums, int k) {
        
                     
        int size = nums.Length;
        if (size < 1) return 0; 
         int r = 0;  

        // Dictionary to store prefix sums frequencies
        Dictionary<int,int> prefixSum = new Dictionary<int,int>();
        int currSum = 0;

        for (int i = 0; i < size; i++) {

            // Add current element to sum so far
            currSum += nums[i];

            // If currSum is equal to desired sum
            // then a new subarray is found
            if (currSum == k) r++;
                
            // Check if the difference exists
            // in the prefixSums dictionary
            if (prefixSum.ContainsKey(currSum - k)) {
                r += prefixSum[currSum - k];
            }

            // Add currSum to the dictionary of prefix sums
            if (!prefixSum.ContainsKey(currSum)) {
                prefixSum[currSum] = 0;                
            }
            prefixSum[currSum]++;

            /*Console.Write(i + " " + r);
            foreach (var l in prefixSum) {
                Console.Write($" - [{l.Key} / {l.Value}]");
            }
            Console.WriteLine();
            */
          
        }    

        return r;
    }
}