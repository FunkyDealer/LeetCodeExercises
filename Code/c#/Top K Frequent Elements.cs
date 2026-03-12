//Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {      
        //create a hashmap for each value where the key is the value and the value is the frequency
        Dictionary<int,int> hashMap = new Dictionary<int,int>();

        foreach (int n in nums) {
            //if the hashmap contains the key, increase its value
            if (hashMap.ContainsKey(n)) hashMap[n]++;
            //if not, the create the key with default value of 1
            else hashMap.Add(n, 1);
        }  

        //use priorityQueue to create a minHeap
        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
    
        //go through each entry in the hashMap
        foreach (var entry in hashMap) 
        {        
            //place new entry in the minheap     
            minHeap.Enqueue(entry.Key, entry.Value);
            //if the meanheap has more than k values, remove the lowest
            if (minHeap.Count > k) {
                minHeap.Dequeue();
            }
        }

        //return the minheap converted into an array
        return minHeap.UnorderedItems.Select(x => x.Element).ToArray();
    }
}