/*
Given two integers, num and t. A number x is achievable if it can become equal to num after applying the following operation at most t times:

    Increase or decrease x by 1, and simultaneously increase or decrease num by 1.

Return the maximum possible value of x.
*/

public class Solution {
    public int TheMaximumAchievableX(int num, int t) {
        
        //t is the number of times you increase or decrease
        return num + t * 2;
    }
}