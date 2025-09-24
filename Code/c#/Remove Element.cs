/*
Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

    Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
    Return k.
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {        
        int count = nums.Length; //count total ammount of numbers in array

        int total = 0;
        for (int x = 0; x < count; x++)  //count number of occurence of bad number
        {            
            if (nums[x] == val)
             {
                total++;;
            }            
        }

    for (int p = 0; p < total; p++) { //go through array 1 time for each bad number
        for (int x = 0; x < count-1; x++)  //go through the array and send bad number to back
        {            
            if (nums[x] == val) //found bad number
             {
                int y = x;
                while (y < count-1) { //send the bad number to the back

                    int temp = nums[y]; //put number in front in temp
                    nums[y] = nums[y+1]; //put number in front in this slot
                    nums[y+1] = temp; //put this number in the next slot
                    y++;
                }
            }            
        }
    }
    total = count - total; //number of good numbers = total number minus ammount of bad numbers
        return total;
    }
}