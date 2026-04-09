/*
You are given a 0-indexed integer array nums and a target element target.

A target index is an index i such that nums[i] == target.

Return a list of the target indices of nums after sorting nums in non-decreasing order. If there are no target indices, return an empty list. The returned list must be sorted in increasing order.
*/

public class Solution {
    //input: array and target integer
    //process: sort array, then use binary search to search
    //output: list of INDEXES where number equal target (after sorting array)
    public IList<int> TargetIndices(int[] nums, int target) 
    {
        List<int> res = new List<int>();
        if (nums.Length == 1) {
            if (nums[0] == target) res.Add(0);            
            return res;
        } 
        Array.Sort(nums);
        //binary search
        int low = 0;
        int high = nums.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;            
            if (nums[mid] == target) {
                 res.Add(mid);              

                low = mid - 1;
                while (low >= 0 && nums[low] == target) {
                    res.Add(low);
                    low--;
                }

                high = mid + 1;
                while (high < nums.Length && nums[high] == target){
                    res.Add(high);
                    high++;
                }
                 break;
            }

            if (target > nums[mid]) low = mid + 1;
            if (target < nums[mid]) high = mid - 1;
        }

        res.Sort();

        return res;
    }
}