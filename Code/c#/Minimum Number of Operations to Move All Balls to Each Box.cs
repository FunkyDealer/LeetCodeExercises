/*
You have n boxes. You are given a binary string boxes of length n, where boxes[i] is '0' if the ith box is empty, and '1' if it contains one ball.

In one operation, you can move one ball from a box to an adjacent box. Box i is adjacent to box j if abs(i - j) == 1. Note that after doing so, there may be more than one ball in some boxes.

Return an array answer of size n, where answer[i] is the minimum number of operations needed to move all the balls to the ith box.

Each answer[i] is calculated considering the initial state of the boxes.
*/

public class Solution {
    public int[] MinOperations(string boxes) {        
        int count = boxes.Length;//get ammount of boxes
        int[] ans = new int[count]; //create answer, size is the same as size of boxes
        for (int x = 0; x < count; x++) //itterate through boxes 
        {
            int operations = 0; //setup number of operation for this slot
            for (int y = 0; y < count; y++) //itterate again through boxes to get number of operations required
            {
                if (x == y) continue; //skip if slot is the same
                if (boxes[y].Equals('1'))  operations += Math.Abs(x - y); //if the box has a ball, calculate number of operations required and add to total
            }
            ans[x] = operations;
        }
        return ans;
    }
}