/*
You are given a string s consisting of lowercase English letters ('a' to 'z').
Your task is to:

    Find the vowel (one of 'a', 'e', 'i', 'o', or 'u') with the maximum frequency.
    Find the consonant (all other letters excluding vowels) with the maximum frequency.

Return the sum of the two frequencies.

Note: If multiple vowels or consonants have the same maximum frequency, you may choose any one of them. If there are no vowels or no consonants in the string, consider their frequency as 0.
The frequency of a letter x is the number of times it occurs in the string. 
*/

public class Solution {
    public int MaxFreqSum(string s) {
        int count = s.Length;

        Dictionary<char, int> frequencyVowel = new Dictionary<char,int>();
        Dictionary<char, int> frequencyConsonant = new Dictionary<char,int>();

        int maxVowel = 0;
        int maxConsonant = 0;

        foreach (var l in s) {   
            if ("aeiou".IndexOf(l) >= 0)  
            {       
                
                 if (!frequencyVowel.ContainsKey(l)) 
                 {
                     frequencyVowel.Add(l, 1);
                     if (frequencyVowel[l] > maxVowel) maxVowel = frequencyVowel[l];
                 }
                 else 
                 {
                     frequencyVowel[l] = frequencyVowel[l] + 1;                     
                        if (frequencyVowel[l] > maxVowel) maxVowel = frequencyVowel[l];
                  }
            }
            else {
                
                    if (!frequencyConsonant.ContainsKey(l))                     
                    {
                         frequencyConsonant.Add(l, 1); 
                         if (frequencyConsonant[l] > maxConsonant) maxConsonant = frequencyConsonant[l];
                         }
                    else {
                        frequencyConsonant[l] = frequencyConsonant[l] + 1;
                        if (frequencyConsonant[l] > maxConsonant) maxConsonant = frequencyConsonant[l];
                    } 
            }
        }

        return maxVowel + maxConsonant;
    }
}