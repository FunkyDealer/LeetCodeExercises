/*
You are given two integer arrays nums1 and nums2 sorted in non-decreasing order and an integer k.

Define a pair (u, v) which consists of one element from the first array and one element from the second array.

Return the k pairs (u1, v1), (u2, v2), ..., (uk, vk) with the smallest sums.
*/

public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {        
         List<IList<int>> result = new List<IList<int>>();
         PriorityQueue<(int sum, int num1, int num2, int idx2), int> minHeap = new PriorityQueue<(int, int, int, int), int>();

         // Initialize the min heap with the first element in nums2 combined with every element in nums1
        for (int i = 0; i < Math.Min(nums1.Length, k); i++) {
            int sum = nums1[i] + nums2[0];
            minHeap.Enqueue((sum, nums1[i], nums2[0], 0), sum);
        }
                
        // Extract the smallest pairs
        while (k-- > 0 && minHeap.Count > 0) {
            var curr = minHeap.Dequeue();
            result.Add(new List<int> { curr.num1, curr.num2 });
            
            // If there is a next pair in the row, add it to the heap
            if (curr.idx2 == nums2.Length - 1) {
                continue;
            }
            int newSum = curr.num1 + nums2[curr.idx2 + 1];
            minHeap.Enqueue((newSum, curr.num1, nums2[curr.idx2 + 1], curr.idx2 + 1), newSum);
        }        

        return result;        
    }
}