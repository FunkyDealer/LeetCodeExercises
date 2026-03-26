/*
You are given row x col grid representing a map where grid[i][j] = 1 represents land and grid[i][j] = 0 represents water.

Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells).

The island doesn't have "lakes", meaning the water inside isn't connected to the water around the island. One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.
*/

//Depth-First Search DFS Version
public class Solution {

    HashSet<(int x, int y)> visited = new HashSet<(int x, int y)>();

    int rows = 0;
    int collums = 0;

    public int IslandPerimeter(int[][] grid) {
        
        rows = grid.Length;
        collums = grid[0].Length;        
        //1 is land 0 is water
        //find a land
        //traverse lands
        //count number of connections that aren't connected to another land

        for (int x = 0; x < rows; x++){
            for (int y = 0; y < collums; y++)
            {
                if (grid[x][y] == 1) return DFSPerimeterSum(x, y, grid);
            }
        }

        return 0;
    }

    int DFSPerimeterSum(int x, int y, int[][] grid) {

        if (IsOutsideGrid(x, y) || grid[x][y] == 0) { //if its outside grid or is water
            return 1; //return 1 to count as a border
        }
        else if (visited.Contains((x,y))) return 0; //if its a land we already visited, return no border

        visited.Add((x,y));
        return DFSPerimeterSum(x + 1 , y, grid) + DFSPerimeterSum(x - 1, y , grid) + DFSPerimeterSum(x ,y + 1, grid) + DFSPerimeterSum(x ,y - 1, grid);
    }  

    bool IsOutsideGrid(int x, int y)
    {
        if (x < 0 || y < 0 || x >= rows || y >= collums) return true;        
        return false;
    }
}


//Breadth-First Search (BFS) Version
public class Solution {

    Queue<(int x, int y)> q = new Queue<(int x, int y)>();
    HashSet<(int x, int y)> visited = new HashSet<(int x, int y)>();

    int rows = 0;
    int collums = 0;

    public int IslandPerimeter(int[][] grid) {
        
        rows = grid.Length;
        collums = grid[0].Length;        
        //1 is land 0 is water
        //find a land
        //traverse lands
        //count number of connections that aren't connected to another land

        for (int x = 0; x < rows; x++){
            for (int y = 0; y < collums; y++)
            {
                if (grid[x][y] == 1) return BFSPerimeterSum(x, y, grid, 0);
            }
        }

        return 0;
    }

    int BFSPerimeterSum(int x, int y, int[][] grid, int perimeter) {
        
        q.Enqueue((x, y));
        visited.Add((x,y));

        while (q.Count > 0)
        {
            //dequeue node
            (int x,int y) land = q.Dequeue();
            //process it
            //enqueue and place neighbours in visited list
            perimeter += ProcessCell(land.x - 1, land.y, grid);
            perimeter += ProcessCell(land.x + 1, land.y, grid);
            perimeter += ProcessCell(land.x, land.y - 1, grid);
            perimeter += ProcessCell(land.x, land.y + 1, grid);
        }

        return perimeter;
    }

    int ProcessCell(int x, int y, int[][] grid) {

        if (IsValidN(x, y))
        {           
            if (grid[x][y] == 1) //land
            {
                if (!visited.Contains((x, y)))
                {
                q.Enqueue((x, y));
                visited.Add((x,y));
                }
                return 0;
            }
            else  //water
            {
                return 1;
            }
        }

        return 1;
    }    

    bool IsValidN(int x, int y)
    {
        if (x >= 0 && x < rows && y >= 0 && y < collums) return true;        
        return false;
    }
}