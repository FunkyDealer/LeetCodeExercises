/*Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "". */


public class Solution {
    public string LongestCommonPrefix(string[] strs) {        
        int count = strs.Count(); //count number of words
        
        string prefix = strs[0]; //set first word as prefix
        int currentLength = prefix.Length;
        for(int x = 1; x < count; x++) //lets go through each word, starting at the second word
        {
            string newPrefix = ""; //set new prefix as nothing
            string temp = strs[x];
            int tempLength = temp.Length;

        for (int y = 0; y < tempLength; y++) //compare the previous prefix to the new word
        {
            if (currentLength <= y) break; //if the new word is bigger, stop comparing
            else {
                if (temp[y] == prefix[y]) newPrefix = newPrefix + temp[y].ToString(); //if the characters are the same, place the character in the new prefix
                else {break;} //if the characters aren't the same, stop comparing
            }
        }
        prefix = newPrefix; //after comparing the words, update the new prefix information
        currentLength = prefix.Length;
        }      

        return prefix;
    }
}