/*
You are given an image represented by an m x n grid of integers image, where image[i][j] represents the pixel value of the image. You are also given three integers sr, sc, and color. Your task is to perform a flood fill on the image starting from the pixel image[sr][sc].

To perform a flood fill:

    1.	Begin with the starting pixel and change its color to color.
    2.	Perform the same process for each pixel that is directly adjacent (pixels that share a side with the original pixel, either horizontally or vertically) and shares the same color as the starting pixel.
    3.	Keep repeating this process by checking neighboring pixels of the updated pixels and modifying their color if it matches the original color of the starting pixel.
    4.	The process stops when there are no more adjacent pixels of the original color to update.

Return the modified image after performing the flood fill.
*/



public class Solution {
    
    int rows = 0;
    int collums = 0;

    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        rows = image.Length;
        collums = image[0].Length;

        BFSFill(sr, sc, color, ref image);

        return image;
    }

    void BFSFill(int x, int y, int color, ref int[][] image) {


        Queue<(int x, int y)> q = new Queue<(int x, int y)>();
        HashSet<(int x, int y)> visited = new HashSet<(int x, int y)>();   

        q.Enqueue((x,y));
        visited.Add((x,y));
        int OGColor = image[x][y];

        while (q.Count > 0) {

            (int x, int y) pixel = q.Dequeue();

            //process pixel
            image[pixel.x][pixel.y] = color;

            //queue neighbours
            AddPixel(pixel.x + 1, pixel.y, OGColor, image, ref q, ref visited);
            AddPixel(pixel.x - 1, pixel.y, OGColor, image, ref q, ref visited);
            AddPixel(pixel.x, pixel.y + 1, OGColor, image, ref q, ref visited);
            AddPixel(pixel.x, pixel.y - 1, OGColor, image, ref q, ref visited);
        }    
    }

    void AddPixel(int x, int y, int OGColor, int[][] image, ref Queue<(int x, int y)> q, ref HashSet<(int x, int y)> visited) {
        if (IsInsideGrid(x, y) && !visited.Contains((x, y)) && image[x][y] == OGColor) {
            q.Enqueue((x,y));
            visited.Add((x,y));
        }        
    }

    bool IsInsideGrid(int x, int y) {
        return (x >= 0 && y >= 0 && x < rows && y < collums);
    }
}