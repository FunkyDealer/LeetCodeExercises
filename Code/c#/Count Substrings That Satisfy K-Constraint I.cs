/*
You are given a binary string s and an integer k.

A binary string satisfies the k-constraint if either of the following conditions holds:

    The number of 0's in the string is at most k.
    The number of 1's in the string is at most k.

Return an integer denoting the number of of s that satisfy the k-constraint.

*/

public class Solution {
    public int CountKConstraintSubstrings(string s, int k) {
        
        int res = 0;        
        int left = 0;
        int[] count = new int[2] {0,0}; //ammount of 0s, ammount of 1s

        //use a sliding window 
        for (int i = 0; i < s.Length; i++) {
            
			//get numeric value of right char
            int S = (int)char.GetNumericValue(s[i]);
            count[S]++; //increase count 

			//if one of the counts is bigger than k, we remove the left character
			//until each count is less or equal
            while (count[0] > k && count[1] > k) {
                int L = (int)char.GetNumericValue(s[left]);
                count[L]--;
                left++;
            }  
			
			//the result is right minus left plus one
            res += i - left + 1;
        } 
        return res;
    }
}