/*
Given an array of integers arr.

We want to select three indices i, j and k where (0 <= i < j <= k < arr.length).

Let's define a and b as follows:

    a = arr[i] ^ arr[i + 1] ^ ... ^ arr[j - 1]
    b = arr[j] ^ arr[j + 1] ^ ... ^ arr[k]

Note that ^ denotes the bitwise-xor operation.

Return the number of triplets (i, j and k) Where a == b.
*/

public class Solution {
    public int CountTriplets(int[] arr)
    {        
        int len = arr.Length;
        int res = 0;

        for (int i = 0; i < len - 1; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                for (int k = j; k < len; k++) 
                {
                    int a = 0;
                    int b = 0;

                    for (int o = i; o < j; o++) 
                    {
                        a = a ^ arr[o]; 
                    }                    
                 
                    for (int p = j; p <= k; p++)
                    {
                        b = b ^ arr[p];
                    }

                    if (a == b)
                    {
                        // Console.WriteLine($"a: {a}, b: {b} - i: {i} j: {j} k: {k}");
                        res++;
                    }

                    //Console.WriteLine($"i: {i} j: {j} k: {k}");
                }   
            }            
        }

        return res;
    }
}