/*
Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.
*/

public class Solution {

    Dictionary<int, string> map = new Dictionary<int, string> { 
        { 2, "abc" },
        { 3, "def" },
        { 4, "ghi" },
        { 5, "jkl" },
        { 6, "mno" },
        { 7, "pqrs" },
        { 8, "tuv" },
        { 9, "wxyz" }
     };

    public IList<string> LetterCombinations(string digits)
    { 
        List<string> result = new List<string>(); //result list
        string current = ""; //current path
        Backtrack(0, digits, result, current);
        return result;
    }

    //recursive backtracking
    void Backtrack(int depth, string digits, List<string> result, string current) {
        if (depth >= digits.Length) {
            result.Add(current);
            return;
        }

        //covert digit to int
        int digit = digits[depth] - '0';
        //after getting the digit, go throught possible chars from the map
        for (int i = 0; i < map[digit].Length; i++)
        {
            //add the char to the current path
            current = current + map[digit][i];     
            //go to the next depth with this char
            Backtrack(depth + 1, digits, result, current);
            current = current.Remove(current.Length - 1);
        }
    }
}