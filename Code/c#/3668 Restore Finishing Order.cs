/*
You are given an integer array order of length n and an integer array friends.

    order contains every integer from 1 to n exactly once, representing the IDs of the participants of a race in their finishing order.
    friends contains the IDs of your friends in the race sorted in strictly increasing order. Each ID in friends is guaranteed to appear in the order array.

Return an array containing your friends' IDs in their finishing order.
*/




public class Solution {
    //input: 2 arrays - 1 of orders, 1 of IDs, 
    //
    //output 1 array of IDs ordered according to orders

    public int[] RecoverOrder(int[] order, int[] friends) {
        
        int[] result = new int[friends.Length];

        int count = 0;
        for (int i = 0; i < order.Length; i++) {

            if (BinarySearchBool(order[i], friends)) {
                result[count] = order[i];
                count++;
            } 
        }

        return result;
    }

    bool BinarySearchBool(int n, int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high) {
            
            int mid = low + (high - low) / 2;

            if (arr[mid] == n) return true;
            if (n > arr[mid]) low = mid + 1;
            if (n < arr[mid]) high = mid - 1;
        }

        return false;
    }
}