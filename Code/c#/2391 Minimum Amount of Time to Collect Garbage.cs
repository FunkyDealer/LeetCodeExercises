/*
You are given a 0-indexed array of strings garbage where garbage[i] represents the assortment of garbage at the ith house. garbage[i] consists only of the characters 'M', 'P' and 'G' representing one unit of metal, paper and glass garbage respectively. Picking up one unit of any type of garbage takes 1 minute.

You are also given a 0-indexed integer array travel where travel[i] is the number of minutes needed to go from house i to house i + 1.

There are three garbage trucks in the city, each responsible for picking up one type of garbage. Each garbage truck starts at house 0 and must visit each house in order; however, they do not need to visit every house.

Only one garbage truck may be used at any given moment. While one truck is driving or picking up garbage, the other two trucks cannot do anything.

Return the minimum number of minutes needed to pick up all the garbage.
*/

public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        int res = 0;        
        int[] travelPrefix = new int[travel.Length];

        //prefix sum
        travelPrefix[0] = travel[0];
        for (int i = 1; i < travel.Length; i++) {
            travelPrefix[i] = travel[i] + travelPrefix[i - 1];
        }

        //garbage types (Metal, Paper, Garbage)
        int[] types = new int[3] {0, 0, 0};
        //go throught each garbage string in reverse
        for (int i = garbage.Length - 1; i >= 1; i--) {

            //if the string contains M, P or G, add max travel time
            if (garbage[i].Contains("M")) {
                types[0] = Math.Max(types[0], travelPrefix[i - 1]);
            }
            if (garbage[i].Contains("P"))
            {
                types[1] = Math.Max(types[1], travelPrefix[i - 1]);
            }
            if (garbage[i].Contains("G"))
            {
                types[2] = Math.Max(types[2], travelPrefix[i - 1]);
            }
          
          //add ammount of characters to the result
          res += garbage[i].Length;
        }

        //dont forget to add ammount of characters in first element
        res+= garbage[0].Length;

        //final answer is total ammount of garbage + travel time of each type
        return res + types[0] + types[1] + types[2];  
    }
}