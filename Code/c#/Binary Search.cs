/*
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution {
    public int Search(int[] nums, int target)
    {        
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] == target) return mid;

            //if the target is bigger than the mid
            if (target > nums[mid]) 
            {
                //move the low to mid minus 1 because target is AFTER the mid
                low = mid + 1;
            }

            //if target is less than mid
            if (target < nums[mid]) {
                //move the high to the mid minus 1 because the target is BEFORE the mid
                high = mid - 1;
            }
        }

        return -1;
    }
}