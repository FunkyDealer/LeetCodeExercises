/*
You are given a 0-indexed integer array nums of size n.

Define two arrays leftSum and rightSum where:

    leftSum[i] is the sum of elements to the left of the index i in the array nums. If there is no such element, leftSum[i] = 0.
    rightSum[i] is the sum of elements to the right of the index i in the array nums. If there is no such element, rightSum[i] = 0.

Return an integer array answer of size n where answer[i] = |leftSum[i] - rightSum[i]|.
*/

//Close to optimal
public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        
        /*
            By getting the total, and then subtracting the current nums[i], we get the sum that is to the right
            because the sum to the right is total minus everything to its left
            
            the sum of the left is the adition of all the positions to the left of i
        */
        int size = nums.Length;
        if (size < 2) return new int[] { 0 };
        
        int[] res = new int[size]; //result

        int leftSum = 0;
        int rightSum = 0; 

        //start by calculating the total
        for (int x = 0; x < size; x++) 
         {
            rightSum += nums[x];
        }

        for (int i = 0; i < size; i++) {
            leftSum += nums[i]; //leftsum is now all the positions
            //we later remove the current posisition to get the sum of all values to the left         
            rightSum -= nums[i]; //subtract current num from total

            //calculate result, 
            res[i] = Math.Abs((leftSum - nums[i]) - rightSum);
        }  

        return res;
    }
}




//not optimal
public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        
        int size = nums.Length;
        if (size < 2) return new int[] { 0 };

        int[] res = new int[size]; //result

        for (int i = 0; i < size; i++) {
            int rightSum = 0; //adding up the right sum
            int leftSum = 0;

            //calculate left
            if (i != 0)
            {
            int l = i - 1; //start l (left) at current position minus 1
                while (l > -1) { 
                    leftSum += nums[l];
                    l--;
                }
            }

            //calculate right
            if (i != size - 1) 
            {
                int r = i + 1; //start r (Right) at current position plus 1 
                while (r < size) {
                    rightSum += nums[r]; //add r
                    r++;
                }
            }
            //calculate result
            res[i] = Math.Abs(leftSum - rightSum);
        }  

        return res;
    }
}