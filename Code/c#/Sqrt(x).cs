/*
Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator..

	*/
	
public class Solution {
    public int MySqrt(int x) {
        
        if (x == 0 || x == 1) return x;
        int left = 1;
        int right = x;
        int mid = -1;
        int result = 0;

        //binary search 
        while (left <= right) {
            //calculate middle point
            mid = left + ((right - left) / 2); //m == midValue

            // if the square of midle is greater than x, move end to left
            if ((long) mid * mid > (long) x) {
                right = mid - 1;
            }
            else if (mid + mid == x){
                //if square of mid == x, we found a perfect square
                return mid;
            }
            else {
             //if the square of the middle value is less than x, move left to the right
                left = mid + 1;
            }
        }

        return right;
    }
}