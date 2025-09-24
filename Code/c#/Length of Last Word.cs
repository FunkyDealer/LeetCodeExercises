/* Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal
consisting of non-space characters only. */

public class Solution {
    public int LengthOfLastWord(string s) {
        
        int count = s.Length;

        string myWord = ""; //set up word storage
        for (int x = count-1; x >= 0; x--) { //go through the string in reverse
            if (s[x] == ' ') {
                if (myWord.Length > 0) { //if we found a space and the captured word length is more than 0
                    return myWord.Length; //return the length of the word
                } 
            }
            else { //else if we found a letter
                myWord = myWord + s[x]; //place the letter that we found in the word storage
            }

            if (x == 0 && s[x] != ' ') return myWord.Length; //if we are at the end of end of the string and the word has letters in it, return the word length
        }

        return myWord.Length;
    }
}

/* Slower Version */

public class Solution {
    public int LengthOfLastWord(string s) {
        
        List<string> words = new List<string>();
        int count = s.Length;

        string myWord = "";
        for (int x = count-1; x >= 0; x--) {
            if (s[x] == ' ') {
                if (myWord.Length > 0) {
                    words.Add(myWord);
                    myWord = "";
                } 
            }
            else {
                myWord = myWord + s[x];
            }

            if (x == 0 && s[x] != ' ') words.Add(myWord);
        }

        return words[0].Count();
    }
}