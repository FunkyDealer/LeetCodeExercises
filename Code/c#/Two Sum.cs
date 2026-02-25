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


//Solution 2
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        /*
        We go through each number in the array
        for each number, we store how much is missing to get the target number
        for example, if the number is 2, and the target is 9
        we need 7, so we store 7 in the dictionary with the index corresponding to 2
        when we get to the other numbers, we check the dictionary to see if the new number can be found in there
        */

        int size = nums.Length;
        //create a dictionary that stores the missing ammount of each number
        Dictionary<int,int> missingMap = new Dictionary<int,int>();

        for (int i = 0; i < size; i++)
        {
            int missing = target - nums[i];

            //check if the comlement exists in the dictionary
            if (missingMap.ContainsKey(missing)) {
                //return the indices of the two numbers that add up to the target
                return new int[] {missingMap[missing], i};
            }

            // add the current number and its index to the dictionary
            if (!missingMap.ContainsKey(nums[i])) {
                missingMap.Add(nums[i], i);
            }            
        } 

        // no solution found, return empty array
        return new int[0];
    }
}