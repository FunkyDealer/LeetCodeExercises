/*
Given an n x n binary matrix image, flip the image horizontally, then invert it, and return the resulting image.

To flip an image horizontally means that each row of the image is reversed.

    For example, flipping [1,1,0] horizontally results in [0,1,1].

To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0.

    For example, inverting [0,1,1] results in [1,0,0].

*/

public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        //iterate though rows
        for (int x = 0; x < image.Length; x++)
        {            
            int left = 0; //set left pointer to 0
            int right = image[0].Length - 1; //set right pointer to row's size minus one

            while (left < right)
            {                
                int temp = image[x][left]; //temporarily store left
                image[x][left] = 1 - image[x][right]; //place the invertion of right in left
                image[x][right] = 1 - temp; //place the invertion of temp in right

                left++; //increase left pointer
                right--; //decrease right pointer
            }

            //if the row is odd, we have to invert the middle value now
            if (image[0].Length % 2 == 1) image[x][left] = 1 - image[x][left];
        }

        return image;
    }
}