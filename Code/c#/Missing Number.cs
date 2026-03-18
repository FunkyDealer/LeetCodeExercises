//Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.




//not optimal
public class Solution {
    public int MissingNumber(int[] nums) {

        //invert the bit
        if (nums.Length == 1) return nums[0] ^= 1; 

        //sort for binary search
        Array.Sort(nums);  
        
        if (nums.Length > 2) 
        {
        for (int i = 0; i < nums.Length; i++)
        {
            int low = 0;
            int high = nums.Length - 1;
            bool found = false;

            //binary search for the current i
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == i) { found = true; break; }

                if (i > nums[mid]) low = mid + 1;

                if (i < nums[mid]) high = mid - 1;
            }
            if (!found) return i;
        }   
        }
        else
        {
            //linear search
            Console.WriteLine("Doing linear search");
            for (int i = 0; i < nums.Length; i++) {

                bool found = false;
                for (int x = 0; x < nums.Length; x++)
                {
                   
                    if (i == nums[x]) {
                         found = true;
                         break;
                          }               
                }

                if (!found) return i;
            }
        }


        return nums.Length;
    }
}