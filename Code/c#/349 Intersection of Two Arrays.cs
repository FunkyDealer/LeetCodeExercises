/*
Given two integer arrays nums1 and nums2, return an array of their . Each element in the result must be unique and you may return the result in any order.
*/

public class Solution {

    //input: two arrays
    //go through first array, search in second array for element 
    //output: intersection of both arrays

    public int[] Intersection(int[] nums1, int[] nums2) {
        
        HashSet<int> seen = new HashSet<int>();
        List<int> res = new List<int>();
        Array.Sort(nums2); //sort for binary search

        for (int i = 0; i < nums1.Length; i++)
        {            
            if (seen.Contains(nums1[i]))  continue;
            //binary search second array     

            int low = 0;
            int high = nums2.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums2[mid] == nums1[i])
                {
                    res.Add(nums1[i]);
                    break;
                } 

                if (nums1[i] > nums2[mid]) low = mid + 1;
                if (nums1[i] < nums2[mid]) high = mid - 1;
            }
            seen.Add(nums1[i]);
        }
        return res.ToArray();
    }
}