/*
You are given an integer n.

Define its mirror distance as: abs(n - reverse(n))​​​​​​​ where reverse(n) is the integer formed by reversing the digits of n.

Return an integer denoting the mirror distance of n​​​​​​​.

abs(x) denotes the absolute value of x.
*/

public class Solution {
    public int MirrorDistance(int n) {
        
        return Math.Abs(n - reverse(n));
    }

    int reverse(int n)
    {
        int result = 0;

        while (n > 0) 
        {
            result = result * 10 + n % 10;
            n /= 10;
        }

        return result;
    }
}