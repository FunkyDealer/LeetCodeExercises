/*

You are given an integer array nums.

Start by selecting a starting position curr such that nums[curr] == 0, and choose a movement direction of either left or right.

After that, you repeat the following process:

    If curr is out of the range [0, n - 1], this process ends.
    If nums[curr] == 0, move in the current direction by incrementing curr if you are moving right, or decrementing curr if you are moving left.
    Else if nums[curr] > 0:
        Decrement nums[curr] by 1.
        Reverse your movement direction (left becomes right and vice versa).
        Take a step in your new direction.

A selection of the initial position curr and movement direction is considered valid if every element in nums becomes 0 by the end of the process.

Return the number of possible valid selections.


*/

public class Solution {
    public int CountValidSelections(int[] nums) {
        
        int size = nums.Length;
        if (size == 1 && nums[0] == 0) return 2;
        int solutions = 0;
        int[] prefix = new int[size];

        //calculate prefix array
        //the prefix array is the sum of all slot up until that slot
        prefix[0] = nums[0]; 
        for (int i = 1; i < size; i++) 
        {            
           prefix[i] = nums[i] + prefix[i-1];            
        }

        if (prefix[size -1] == 0) return size * 2;        

        for (int i = 0; i < size; i++) {
            //Console.Write($" {prefix[i]} ");
            if (nums[i] == 0) {
                int right = 0;
                int left = size - 1;

                //Calculate ammount to the right, which is the last slot minus the slot next to this zero
                right = prefix[size - 1] - prefix[i];

                if (i == 0) {
                    if (right == 1) { solutions++; continue; }
                    else continue;
                }

                left = prefix[i-1];

                if (i == size - 1) {
                    if (left == 1) { solutions++; continue; }
                    else continue;
                }              
                
                //if the slot next to this is the final slot, just make right that ammount
                if (i + 1 == size - 1) right = nums[i + 1];

                //left side is on the prefix   
                int diff = Math.Abs(right - left);
                
                if (diff < 2) solutions += (2 - diff);
 
            }   
        }

        return solutions;

    }
}