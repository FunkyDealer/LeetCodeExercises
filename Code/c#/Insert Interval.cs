/*
You are given an array of non-overlapping intervals intervals where intervals[i] = [starti, endi] represent the start and the end of the ith interval and intervals is sorted in ascending order by starti. You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

Insert newInterval into intervals such that intervals is still sorted in ascending order by starti and intervals still does not have any overlapping intervals (merge overlapping intervals if necessary).

Return intervals after the insertion.

Note that you don't need to modify intervals in-place. You can make a new array and return it.
*/



/*
Explanation:
Intead of trying to insert the new interval and then merging it with the ones in front,
we instead make the new interval absorve the intervals it overlaps with, and only then do the we insert it, before a bigger interval
*/
public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = new List<int[]>();
        bool inserted = false;

        for (int i = 0; i < intervals.Length; i++)
        {            
            //check if newInterval can be placed in this position        
            //can we insert the new interval before this one
            if (newInterval[1] < intervals[i][0]) {
            if (!inserted)
                {    
                res.Add(newInterval);
                inserted = true;
                }
            res.Add(intervals[i]);
            }
            //if the new interval is bigger than the curent interval
            else if (newInterval[0] > intervals[i][1]) {
                //just add in the current interval
                res.Add(intervals[i]);
            }
            else
            {   //Merge current Interval with new Interval to make it bigger and then add it back
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            }
        }      
    
        //if it was never inserted, insert at the end
        if (!inserted) {
            res.Add(newInterval);
        }      

        //return result list converted into an array
        return res.ToArray();
    }
}