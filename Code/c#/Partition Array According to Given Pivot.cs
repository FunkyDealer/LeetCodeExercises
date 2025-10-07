/*
You are given a 0-indexed integer array nums and an integer pivot. Rearrange nums such that the following conditions are satisfied:

    Every element less than pivot appears before every element greater than pivot.
    Every element equal to pivot appears in between the elements less than and greater than pivot.
    The relative order of the elements less than pivot and the elements greater than pivot is maintained.
        More formally, consider every pi, pj where pi is the new position of the ith element and pj is the new position of the jth element. If i < j and both elements are smaller (or larger) than pivot, then pi < pj.

Return nums after the rearrangement.
*/

public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {        
        int count = nums.Length;

        List<int> smallThan = new List<int>();
        List<int> equal = new List<int>();
        List<int> greaterThan = new List<int>();

        foreach (int n in nums)
        {
            if (n > pivot) greaterThan.Add(n);
            else if (n < pivot) smallThan.Add(n);
            else equal.Add(n);
        }
        
        int countSmall = smallThan.Count;
        int countEqual = equal.Count;
        int countGreater = greaterThan.Count;                

        int i = 0;        
        for (int s = 0; s < countSmall; s++) {
            nums[i] = smallThan[s];
            i++;
        }    
        for (int e = 0; e < countEqual; e++) {
            nums[i] = equal[e];
            i++;
        }
        for (int g = 0; g < countGreater; g++) {
            nums[i] = greaterThan[g];
            i++;
        }       
        
        return nums;
    }
}