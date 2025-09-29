/*
You are given positive integers n and m.

Define two integers as follows:

    num1: The sum of all integers in the range [1, n] (both inclusive) that are not divisible by m.
    num2: The sum of all integers in the range [1, n] (both inclusive) that are divisible by m.

Return the integer num1 - num2.
*/

public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int num1 = 0;
        int num2 = 0;

        for (int x = 1; x <= n; x++) {
            
            if (x % m == 0) {
                 num2 = num2 + x;
            }
            else {
                num1 = num1 + x;                 
            }           
        }

        return num1 - num2;
    }
}