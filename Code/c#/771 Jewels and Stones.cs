/*
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".
*/

public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int res = 0;

        for (int i = 0; i < stones.Length; i++) {

            if (IsJewel(stones[i], jewels)) {
                res++;
            } 
        }

        return res;
    }

    bool IsJewel(char c, string jewels){

        foreach(char j in jewels) {
            if (j.Equals(c)) return true;
        }
        return false;
    }
}