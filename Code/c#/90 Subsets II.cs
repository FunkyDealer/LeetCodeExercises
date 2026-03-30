/*
Given an integer array nums that may contain duplicates, return all possible (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.
*/

public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
    
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        IList<int> current = new List<int>();

        Backtracking(0, nums, result, current);

        return result;
    }

    //recursive function
    void Backtracking(int index, int[] nums, List<IList<int>> result, IList<int> current)
    {
        //index exceeds array length, add current to results
        if (index == nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        //include current element in the subset
        current.Add(nums[index]);
        Backtracking(index + 1, nums, result, current);

        //remove current element for backtracking
        int removed = current[current.Count - 1];
        current.RemoveAt(current.Count - 1);

        //skip all duplicates
        while (index + 1 < nums.Length && nums[index + 1] == removed)
        {
            index++;
        }

        Backtracking(index + 1, nums, result, current);
    }
}