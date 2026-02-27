//Given a string s, find the length of the longest substring without duplicate characters.

public class Solution {
    public int LengthOfLongestSubstring(string s) {           
           
        int size = s.Length;
        if (size < 1) return 0; //if the size is 0, there are no character substrings
        if (size == 1) return 1; //if the size is 1, the only character substring is size 1

        //go through the string, find the first window's length, stop when you find a duplicate
        List<Char> chars = new List<Char>(); //list of characters
        chars.Add(s[0]); //add the very first character

        int left = 0; //set left pointer
        int right = 0; //set right pointer
        int maxLength = 1; //set max length to 1 because we already have 1 character in

        while (right < size - 1) //lets move the right pointer through the list till we reach the last position
        {            
            right++; //move forward            
            if (chars.Contains(s[right])) //found repeat character
             {
                //remove characters from the hash set until the duplicate is remove
                while (chars.Contains(s[right])) {
                    left++; //move the left pointer up
                    chars.RemoveAt(0); //remove the character from the list                
                }
                chars.Add(s[right]); //add the new character now that the duplicate was removed
                maxLength = Math.Max(maxLength, (right+1) - left); //calculate new length
            }
            else //if the new character is not a duplicate
            {
                chars.Add(s[right]); //just add it to the hash set 
                maxLength = Math.Max(maxLength, (right+1) - left);
            }   
     
        }
        return maxLength;
    }
}