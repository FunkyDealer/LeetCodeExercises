/*
A string is good if there are no repeated characters.

Given a string s​​​​​, return the number of good substrings of length three in s​​​​​​.

Note that if there are multiple occurrences of the same substring, every occurrence should be counted.

A substring is a contiguous sequence of characters in a string.
*/

public class Solution {
    public int CountGoodSubstrings(string s) {
        int res = 0;
        const int k = 3;
        if (s.Length < k) return 0;
        string window = "";

        bool unique = true;
        //window start
        for (int i = 0; i < k; i++)
        {
            if (window.Contains(s[i])) unique = false;
            window = window + s[i];            
        }
        if (unique) res++;

        //sliding window
        for (int i = k; i < s.Length; i++) 
        {
            //remove first letter
            window = window.Remove(0, 1);
            //add new to end
            if (window[0] != window[1] && !window.Contains(s[i])) { res++; }
            window = window + s[i];
            Console.WriteLine(window);
        }

        return res;
    }
}