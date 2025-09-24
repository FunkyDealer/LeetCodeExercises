/* Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack. */

public class Solution {
    public int StrStr(string haystack, string needle) {
        int needleCount = needle.Count(); //get ammount of characters in needle
        int hayCount = haystack.Count();    //get ammount of characters in hayStack  
    if (needleCount > hayCount) return -1; //if the needle is bigger than the haycstack, its not possible

        for (int x = 0; x < hayCount; x++)  //go through the haystack
        {
            if (x + needleCount > hayCount) return -1; //check to see if the needle is bigger than the rest of the haystack
            if (haystack[x] == needle[0]) {
                int correct = 0; //amount of correct letters                
                for (int y = 0; y < needleCount;) { //go through the haystack again, lets check the letters that come after
                    if (haystack[x + y] == needle[y]) {
                        correct++;  
                        if (correct == needleCount) { //we found all letters in needle
                            return x; //return the index where we started
                        }
                        y++;                       
                    }
                    else { //the letter next is not the same, lets get out of the loop
                        break;
                    }
                }
            }
        }
    return -1;
    }
}