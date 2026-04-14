/*
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.
*/

public class Solution {

    //Input: Array of heights
    //problem, find the area with most capacity (area = width * height
    //solution
    //Use two pointer approach to go throught the array and calculate areas
    //return maximum area (single int)

    public int MaxArea(int[] height) {

        int res = 0; //result
        int left = 0; //initiate left pointer
        int right = height.Length - 1; //initiate right pointer

        //lets use the pointers to explore the array
        while (left <= right) //while left is less or equal to right
        {
            int difference = right - left; //get width by calculation difference
            int area = Math.Min(height[left], height[right]) * difference; //calculate the area by multiplying the width by the smallest of the two pointers
            
            res = Math.Max(res, area); //compare area with the current result

            //move the smaller pointer towards the other, only 1 pointer moves at a time.
            if (height[left] < height[right]) left++;
            else right--;
        }
        return res;
    }
}