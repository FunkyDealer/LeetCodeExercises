/*
Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

Return the indices of the two numbers index1 and index2, each incremented by one, as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.

Your solution must use only constant extra space.
*/

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int left = 0; int right = numbers.Length - 1;
        int sum = numbers[right] + numbers [left]; //sum of the two numbers

        if (sum == target) return new int[] {left+1, right+1};

        while (sum != target) { //while the sum isn't equal to the target
            if (sum > target) right--; //if the current sum is BIGGER than the target, then decrease the right number
            else left++; //if the current sum is SMALLER than the target, then increase the left number
            
            sum = numbers[right] + numbers[left];
            if (sum == target) return new int[] {left+1, right+1}; 
        }

        return new int [] {left+1, right+1};
    }
}