/*Two Sum

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.*/


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int totalnums = nums.Count();
        int[] indices = {0,0};

        int current = 0;
        for (int x = 0; x < totalnums; x++) 
        {
              for (int y = 0; y < totalnums; y++) {
                if (x == y) continue;
                else {
                    if (nums[x] + nums[y] == target) {
                        indices[0] = x;
                        indices[1] = y;    
                        break;                    
                    }
                }
              }
        }
return indices;
    }
}