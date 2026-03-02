/*
Given a circular integer array nums (i.e., the next element of nums[nums.length - 1] is nums[0]), return the next greater number for every element in nums.

The next greater number of a number x is the first greater number to its traversing-order next in the array,
which means you could search circularly to find its next greater number. If it doesn't exist, return -1 for this number.
*/

public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        
        //create result
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++) {
            res[i] = -1; //default result value is -1;
        }        
        //create stack
        Stack<int> stack = new Stack<int>();

        //go throught the array twice backwards
        for (int i = 2 * nums.Length - 1; i >= 0; i--) {
            int curr = i % nums.Length;            

            // Pop elements from stack that are less than or equal to current element
            // These cannot be the next greater element for any future element
            while (stack.Count > 0 && nums[curr] >= nums[stack.Peek()]) {
                
                stack.Pop();             
            }

            // If stack is not empty, top element is the next greater element
            // Only update result in the first pass (when i < n)
            if (stack.Count > 0 && i < nums.Length) {
                res[curr] = nums[stack.Peek()];
            }

            // Push current element to stack for future comparisons
            stack.Push(curr);
        }

        return res;
    }
}