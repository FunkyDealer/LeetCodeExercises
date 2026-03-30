//Given an array nums of distinct integers, return all the possible . You can return the answer in any order.



public class Solution {
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();
        bool[] visited = new bool[nums.Length];

        BackTracking(0, nums, current, visited, result);

        return result;
    }

    void BackTracking(int depth, int[] nums, List<int> current, bool[] visited, List<IList<int>> result) {
        if (depth >= nums.Length)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (!visited[i]) 
            {
                visited[i] = true;
                //add element to current permutation
                current.Add(nums[i]);          
                //recursively build the rest
                BackTracking(depth + 1, nums, current, visited, result);
                //backtrack
                current.RemoveAt(current.Count - 1);
                visited[i] = false;
            }
        }
    }
}