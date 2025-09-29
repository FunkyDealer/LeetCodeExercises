/*
You are given a string s. The score of a string is defined as the sum of the absolute difference between the ASCII values of adjacent characters.

Return the score of s.
*/

public class Solution {
    public int ScoreOfString(string s) {        
        int count = s.Length; //get string length

        int total = 0;
        for (int x = 0; x < count - 1; x++) { //itterate through string until second last slot
            int value1 = s[x]; //string into ascii value of current slot
            int value2 = s[x+1]; //string into ascii value of next slot

            int subtraction = Math.Abs(value1 - value2); //remember to make it the absolute value (positives only)
            total = total + subtraction; //add subtraction to total
        }

    return total; //return total
    }
}