/*
You are given a string s consisting of lowercase English letters.

Return an integer denoting the maximum number of you can split s into such that each substring starts with a distinct character (i.e., no two substrings start with the same character).
*/

public class Solution {
    public int MaxDistinct(string s) {
        
        HashSet<char> used = new HashSet<char>();
        

        for (int i = 0; i < s.Length; i++) {
            if (!used.Contains(s[i])) {
                used.Add(s[i]);

            }

        }


        return used.Count;
    }
}