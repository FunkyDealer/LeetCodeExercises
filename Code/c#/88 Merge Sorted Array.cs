/*
You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
*/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
    
        int p1 = 0;
        int p2 = 0;

        while (p1 < nums1.Length && p2 < n)
        {
            if (nums1[p1] > nums2[p2]) //if p1 is bigger
            {
                //place p2 in p1, everything in num1 gets moved forward
                InsertNumber(nums1, nums2[p2], p1);                
                p1++;
                p2++;
                m++;
            }
            else if (p1 >= m && nums1[p1] == 0) //if pointer 1 is biggers that the length of array 1, and it finds a 0
            {
                //we place the pointer 2 number in there
                nums1[p1] = nums2[p2];
                p1++;
                p2++;
            }
            else //if p2 is bigger
            {
                p1++;
            }           
        }
    }

    void InsertNumber(int[] nums, int n, int slot)
    {
        int previous = n;
        for (int i = slot; i < nums.Length; i++)
        {
            int temp = nums[i];
            nums[i] = previous;
            previous = temp;    
        }
    }
}

