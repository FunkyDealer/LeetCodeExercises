/*
Given an integer array nums, handle multiple queries of the following type:

    Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
*/

public class NumArray {
    private int[] prefix;

    public NumArray(int[] nums) {        
        //prefix sum
        int n = nums.Length;
        this.prefix = new int[n];
        this.prefix[0] = nums[0]; //first elements at the same

        for (int i = 1; i<n; i++) {
            this.prefix[i] = nums[i] + this.prefix[i-1]; //element i is equal to nums[i] and the comulative sum till then
        }
    }
    
    public int SumRange(int left, int right) {
        
        int rightSum = this.prefix[right];
        
        int leftSum = 0;
        if (left > 0) leftSum = this.prefix[left - 1];

        return rightSum - leftSum; //return the sum
    }
}
