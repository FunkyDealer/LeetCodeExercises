/*
You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.
*/

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {

    public int FirstBadVersion(int n) {

    if (n == 1) return n;
    int result = n;    

    //binary search
    int low = 1;
    int high = n;

    // 1 2 3 <4 5>
    //binary search
    while (low <= high)
    {
        //get middle
        int mid = low + (high - low) / 2; //middle
        
        //if mid is bad
        if (IsBadVersion(mid)) 
        {            
            //return mid if the version before is good, which means that this version is the first bad one
            if (!IsBadVersion(mid-1)) return mid;

            //else, this version is bad, but so is the one before
            //so we need to search the half that comes before
            high = mid-1;

        }
        else //if mid is good
        {
            //return mid + 1 if the version after is bad
            if (mid < n && IsBadVersion(mid+1)) return mid+1;

            //else, this version is good, but so is the one next
            //so we need to search the versions after
            low = mid + 1;
        }
    }       
    
        return n; 
    }
}



