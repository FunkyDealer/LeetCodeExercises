/*
Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.
*/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        //start by sorting the array using the first interval
        //the comparer compares the first value of both intervals, meaning: the start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));        
        //create a result list where we place the merged intervals
        //in this case, its a list of arrays
        List<int[]> res = new List<int[]>();

        //start by adding the first interval
        res.Add(intervals[0]);
        
        //and then we go throught each one of the other intervals
        for (int i = 1; i < intervals.Length; i++) {            
            
            //if the current interval we're on's start time is less or equal than the last 
            //merged interval on the results
            if (intervals[i][0] <= res[res.Count-1][1] ) {
                //we merge
                //by setting the result's end time with the current interval's end time.
                //max is necessary in case that the result's end time is higher than the current
                //interval's time
                res[res.Count-1][1] = Math.Max(res[res.Count-1][1],intervals[i][1]);
            }
            else {
                //don't merge
                //instead add the current interval to results to merge with the next intervals
                res.Add(intervals[i]);
            }
        }
        
        //return the list by converting it into an array
        return res.ToArray();
    }
}