/*

Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

Can you solve it without sorting?

*/

//optimal solution using a minheap
public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
        //create minHeap using c#'s priority queue
        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
        
        //go throught the array 
        foreach (int n in nums)
        {          
            //if the minheap has less than k elements, add new lement to it
            if (minHeap.Count < k) { minHeap.Enqueue(n,n); }
            //else lets add it only if the new element is larger than the largest element in the heap
           else if (minHeap.Peek() < n)
           {
            //dequeue removes the element with the lowest priority value.
                minHeap.Dequeue();
                //enqueue adds the value
                minHeap.Enqueue(n,n);
           }
        }

        //return minHeap's minimal value
        return minHeap.Peek();
    }
}


//not optimal
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        Array.Sort(nums);

        return nums[nums.Length-k];
    }
}