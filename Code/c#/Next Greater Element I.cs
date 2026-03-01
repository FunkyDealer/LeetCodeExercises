/*
The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.

You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.

For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2. If there is no next greater element, then the answer for this query is -1.

Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.
*/

public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int size1 = nums1.Length;
        int size2 = nums2.Length;
        int[] ans = new int[size1]; //answer array

        //lookup dictionary to store nums1 with index
        Dictionary<int,int> numberIndex = new Dictionary<int,int>();
        //lets go through nums1
        //create ans with all values at -1 as default
        //create a look up hashmap for nums1 so that we can easily get values
        for (int i = 0; i < size1; i++)
        {
            ans[i] = -1;
            if (!numberIndex.ContainsKey(nums1[i])) numberIndex.Add(nums1[i], i);
        }

        //create the stack
         Stack<int> stack = new Stack<int>();

            //lets go through the nums2         
            for (int j = 0; j < size2; j++) {

                //if the stack has memebers
                //and the number is larger than the top of the stack                
                while (stack.Count > 0 && nums2[j] > stack.Peek())
                {       
                    //pop top till we find a smaller number
                    //save the popped number                
                    int popped = stack.Pop();
                    //if the popped number in in nums1
                    if (numberIndex.ContainsKey(popped))
                    {
                        //lets get its index
                        int idx = numberIndex[popped];
                        //and add the current number as the next greater element
                        ans[idx] = nums2[j];
                    }                     
                }

                //push in
                if (numberIndex.ContainsKey(nums2[j])) stack.Push(nums2[j]);
            }         

        return ans;
    }
}