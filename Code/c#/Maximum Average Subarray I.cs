/*
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.
*/

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        
        int size = nums.Length; 
        if (size == 1) return nums[0]; //if the array is just 1 element, return that element
        if (size < k) k = size; //if the array is smaller than k, change k to be as big as the array
        double maxAverage = Double.MinValue;

        //compute the first window
        double windowSum = 0; //setup sum for window
        double windowAverage = 0; //setup average for window
        for (int i = 0; i < k; i++) {
            windowSum += nums[i]; //sum up the values in the window
            windowAverage = windowSum/k;
            maxAverage = windowAverage;
        }

        // Compute sums of remaining windows by
        // removing first element of previous
        // window and adding last element of
        // current window.
        for (int i = k; i < size; i++) {
            windowSum += nums[i] - nums[i - k]; //add the current value, and remove the value that comes before the window
            windowAverage = windowSum / k;
            maxAverage = Math.Max(maxAverage, windowAverage);
        }

        //Console.WriteLine("Max: " + maxAverage);
        return maxAverage;
    }
}