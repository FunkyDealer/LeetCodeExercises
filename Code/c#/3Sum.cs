/*
Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.
*/

public class Solution {
    /*for this problem, we will basically use 3 pointers.
    it's a 2 pointer solution, but we're adding an extra pointer.
    the extra pointer is itterating through the array,
    while the other 2 pointers are trying to meet each others
    in the slots that are in front of the third pointer
    by the end we will have checked all possible combinations
    */
    
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        int size = nums.Length; //size of array
        List<IList<int>> r = new List<IList<int>>(); //result is an list of lists
        
        Array.Sort(nums); //sort the array
        
        // -4, -1, -1, 0, 1, 2        
        //first number is "i", we will itterate through the array until the end minus 2, to make space for the left and right
        for (int i = 0; i < size-2; i++) {
            //check for duplicates, if the next number is the same, skip it
            if (i > 0 && nums[i] == nums[i-1]) continue; //skip duplicates            

            int left = i+1; //left is the slot after "i", which is the first number
            int right = size-1; //right is the last array slot     

            while (left < right) //lets change left and right until left meets right or vice versa
            {
                 int sum = nums[i] + nums[left] + nums[right];  //sum up the 3 pointers

                if (sum == 0) //if the sum is 0 which is what the problem asks for
                {
                    //Console.WriteLine($"found {nums[i]}, {nums[left]}, {nums[right]} ");
                    r.Add(new List<int> { nums[i], nums[left], nums[right] }); //add the triple to the list
                    while (left < right && nums[left] == nums[left+1]) left++; //skip duplicate left numbers
                    while (left < right && nums[right] == nums[right-1]) right--; //skip duplicate left numbers

                    left++; //increase left
                    right--; //decrease right
                } 
                else if (sum < 0){
                    left++; //if the sum is less than 0, increase left
                }
                else
                {
                    right--; //else decrease right
                }

            }
        }                  
     
        return r;
    }
}