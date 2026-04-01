/*
You are given a string allowed consisting of distinct characters and an array of strings words. A string is consistent if all characters in the string appear in the string allowed.

Return the number of consistent strings in the array words.
*/

public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        
        HashSet<char> allowedSet = new HashSet<char>(allowed);
        int res = 0;

        foreach (string word in words){
            res += GoodString(word, allowedSet);
        }

        return res;
    }

    int GoodString(string s, HashSet<char> allowed) {

        foreach (char c in s)
        {
            if (!allowed.Contains(c)) return 0;
        }
        return 1;
    }
}