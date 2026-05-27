/*The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
 A P L S I I G
  Y   I   R

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);
*/

public class Solution {
    public string Convert(string s, int numRows) {
        
        if (numRows == 1) return s; //edge case, if rows is 1, return the same string

        // Create an array of StringBuilders, one for each row
        StringBuilder[] rows = new StringBuilder[numRows];
        for (int i = 0; i < numRows; i++)
        {
            rows[i] = new StringBuilder();
        }

        int currentRow = 0;
        int dir = -1; //direction //-1 is up, 1 is down

        foreach (char c in s) {

            rows[currentRow].Append(c);

            // Change direction when reaching the top or bottom row
            if (currentRow == 0 || currentRow == numRows - 1)
            {
                dir = -dir;
            }

            // Move to the next row based on current direction
            currentRow += dir;
        }

        StringBuilder res = new StringBuilder();
        foreach (StringBuilder r in rows) {
            res.Append(r);
        }

        return res.ToString();
    }
}