/*
Given an integer numRows, return the first numRows of Pascal's triangle.

In Pascal's triangle, each number is the sum of the two numbers directly above
*/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {        
        IList<IList<int>> triangle = new List<IList<int>>(); //triangle creation
        if (numRows > 0) {
        IList<int> firstlayer = new List<int>(); //first layer
        firstlayer.Add(1);
        triangle.Add(firstlayer);

        if (numRows > 1) {            
            for (int x = 1; x < numRows; x++)   //Itterate through layers    
            {
             IList<int> layer = new List<int>(); //new layer
                for (int y = 0; y <= x; y++) { //go through each value in layer
                int number = 1; //default

                if (y > 0 && y < x) { //if slot is bigger than 0 and less than the last slot
                    number = triangle[x-1][y] + triangle[x-1][y-1]; //add the two slots on top
                }
                layer.Add(number);
             }
             triangle.Add(layer);
          }
        }        
        }
    return triangle;
    }
}