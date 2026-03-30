/*
Given an integer array nums of unique elements, return all possible (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.
*/

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        //result list
        List<IList<int>> result = new List<IList<int>>();
        //list of current subset
        List<int> current = new List<int>();
        //recursively explore the array
        BackTrackSubset(0, nums, result, current);
        return result;
    }

    //recursive function to explore the array
    void BackTrackSubset(int index,int[] nums, List<IList<int>> result, List<int> current)
    {   
        //if the index is the last, add current subset to results and go back
        if (index == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }
        //Create subsets without this index
        BackTrackSubset(index + 1, nums, result, current);

        //Create subsets with this index
        current.Add(nums[index]);
        BackTrackSubset(index + 1, nums, result, current);

        //basckTrack
        current.RemoveAt(current.Count - 1);
    }
}