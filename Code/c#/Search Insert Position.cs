/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.
*/

public class Solution {
    public int SearchInsert(int[] nums, int target) {        
        int count = nums.Length; //length of array

        int s = 0;     //default position for target   
        for (int x = 0; x < count; x++) {
            if (nums[x] == target) return x; //target found, return position
            if (nums[x] < target) s = x + 1; //this number is smaller, so the position where target should be is forward
        }
        return s; //return position where target should be
    }
}