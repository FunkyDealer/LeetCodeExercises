/*
You have a bomb to defuse, and your time is running out! Your informer will provide you with a circular array code of length of n and a key k.

To decrypt the code, you must replace every number. All the numbers are replaced simultaneously.

    If k > 0, replace the ith number with the sum of the next k numbers.
    If k < 0, replace the ith number with the sum of the previous -k numbers.
    If k == 0, replace the ith number with 0.

As code is circular, the next element of code[n-1] is code[0], and the previous element of code[0] is code[n-1].

Given the circular array code and an integer key k, return the decrypted code to defuse the bomb!
*/

public class Solution {
    public int[] Decrypt(int[] code, int k) {
        
        int[] res = new int[code.Length];
        if (k == 0) return res;

        if (k > 0) return SlideForward(code, k, res);
        if (k < 0) return SlideBackwards(code, k, res);

        return res;
    }

    int[] SlideForward(int[] code, int k, int[] res) {
        int sum = 0;
        
        //initial window
        for (int i = 1; i <= k; i++) {
            sum += code[i];
        }

        res[0] = sum;
        //slide window forward
        for (int i = 1; i < code.Length; i++) {
            int j = i + k;
            if (j >= code.Length) j -= code.Length;

            sum += code[j] - code[i]; 
            res[i] = sum;
        }

        return res;
    }

    int[] SlideBackwards(int[] code, int k, int[] res) {
        int sum = 0;
        //initial window
        for (int i = code.Length - 1; i >= code.Length + k; i--) 
        {
            sum += code[i];
        }
        res[0] = sum;

        //slide window forward        
        for (int i = 1; i < code.Length; i++) {
            int j = i + (k-1);
            if (j < 0) j += (code.Length);
            sum += code[i-1] - code[j];

            res[i] = sum;
        } 

        return res;
    }
}