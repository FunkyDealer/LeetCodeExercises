/*
In the town of Digitville, there was a list of numbers called nums containing integers from 0 to n - 1. Each number was supposed to appear exactly once in the list, however, two mischievous numbers sneaked in an additional time, making the list longer than usual.

As the town detective, your task is to find these two sneaky numbers. Return an array of size two containing the two numbers (in any order), so peace can return to Digitville.
*/

public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int[] res = new int[2];
        HashSet<int> numbers = new HashSet<int>();

        int n = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!numbers.Contains(nums[i]))
            {
                numbers.Add(nums[i]);
            }
            else
            {
                res[n] = nums[i];
                n++;
            }
        }
        return res;
    }
}