/* 
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.
*/

public class Solution {

    public int[] PlusOne(int[] digits) {        
        int count = digits.Length;       

        List<int> newDigits = new List<int>();      //create list   

        int add = 1; //add
        for (int x = count -1; x >= 0; x--) { //go through array in reverse
            
            int digit = digits[x] + add; //add to digit
            if (add > 0) add--; //lower add value
            if (digit >= 10) { //if the digit became 10
                digit = 0; //turn digit into 0
                add = 1; //add 1 for the next digit
            }

            newDigits.Insert(0, digit); //insert at top
            if (x == 0 && add > 0) newDigits.Insert(0, add); //in case we were at the first digit and it turned into 10, add another slot at the top for a 1
        }

    
    int[] Array = newDigits.ToArray();     //turn the list into array

    return Array;
    }
}