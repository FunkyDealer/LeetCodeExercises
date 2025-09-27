/*
Given two binary strings a and b, return their sum as a binary string.
*/

public class Solution {
    public string AddBinary(string a, string b) {        
        int countA = a.Length;
        int countB = b.Length;

        int highestCount;
        string highest;
        int lowestCount;
        string lowest;

        //get biggest number to put on top
        if (countA > countB) { highestCount = countA; highest = a; lowestCount = countB; lowest = b; }
        else { highestCount = countB; highest = b; lowestCount = countA; lowest = a; }

        //example
        //    1 1  <- rest
        //  1 0 0 1 <- biggest
        //+     1 1 <- smaller
        //= 1 1 0 0 <- result

        int y = lowestCount - 1; //get last digit of smaller
        int rest = 0; //reset rest to 0
        string result = ""; //initiate result string
        for (int x = highestCount - 1; x >= 0; x--) //iterrate through biggest number in reverse
        {
            int n1 = highest[x] - '0'; //convert character to int
            int n2 = 0;
            if (y >= 0) n2 = lowest[y] - '0'; //if we're still on a valid slot in the lowest number

            int nResult = n1 + n2 + rest; //add everything
            rest = 0; //reset rest after it was used
            if (nResult > 1) { //if the result is bigger than 1
                nResult = nResult - 2; //reduce it by 2, 2 becomes 0, 3 becomes 1
                rest = 1; //add rest for next round                
            }

            result = nResult + result; //add result in front of string
            y--; //go down on the lowest number
        }
        
        if (rest > 0) result = '1' + result; //if at the end there is still a rest, then add another 1 in front of string.
        
        return result;
    }
}