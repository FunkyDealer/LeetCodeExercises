/*
Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.
*/

public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int result = 0;
        
        //n, pos dict
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        //itterate throught array
        for (int i = 0; i < nums.Length; i++) {
            
            //if the number inst in the array
            if (!dict.ContainsKey(nums[i])) {
                //create list of positions
                List<int> l = new List<int>();
                l.Add(i);
                //add number and list to list
                dict.Add(nums[i], l);
            }
            else 
            {
                //result is ammount of times the number appears
                result += dict[nums[i]].Count; 
                dict[nums[i]].Add(i);                               
            }
        }
        return result;
    }
}