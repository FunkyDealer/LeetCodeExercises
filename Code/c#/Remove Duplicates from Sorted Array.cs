/*
Remove Duplicates from Sorted Array

Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

    Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
    Return k.
*/

public class Solution {   
    public int RemoveDuplicates(int[] nums) {
        int count = nums.Length;
        Dictionary<int, int> myNumbers = new Dictionary<int,int>();

        for (int x = 0; x < count; x++)
        {
            if (myNumbers.ContainsKey(nums[x]))
            {
                myNumbers[nums[x]]++;
            }
            else {
                myNumbers.Add(nums[x], 1);
            }
        }
        
        int total = 0;
        foreach (var n in myNumbers) {
            if (n.Value > 1) {
                for (int m = 0; m < n.Value - 1; m++) //go through the array the number of times the number repeats
                {  
                for (int x = 0; x < count-1; x++)  //go through the array and send bad number to back
                  {            
                      if (nums[x] == n.Key) //found bad number
                       {
                            for (int y = x; y < count-1; y++) //send to back
                             {
                                int temp = nums[y]; //put number in front in temp
                                nums[y] = nums[y+1]; //put number in front in this slot
                                nums[y+1] = temp; //put this number in the next slot
                            }
                            break; //Don't keep going through the array
                        }            
                     }
                }
            total = total + (n.Value - 1);
            }
        }
        return count - total;
    }
}