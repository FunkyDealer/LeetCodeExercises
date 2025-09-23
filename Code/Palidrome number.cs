/*Palindrome Number

Given an integer x, return true if x is a , and false otherwise.*/



public class Solution {
    public bool IsPalindrome(int x) {
    if (x < 0) return false; 
    if (x < 10) return true;   

    List<int> listOfInts = new List<int>();
    while(x > 0)
    {
        listOfInts.Add(x % 10);
        x = x / 10;
    }
    listOfInts.Reverse();

    int totalDigits = listOfInts.Count();
    int sideDigits = totalDigits;
    if (totalDigits % 2 == 1) sideDigits--;
    
        int trueCount = 0;
        for (x = 0; x < sideDigits / 2; x++) {
            if (listOfInts[x] == listOfInts[totalDigits-1-x]) trueCount++;
        }
        if (trueCount == sideDigits / 2) return true;

    return false;
    }
}