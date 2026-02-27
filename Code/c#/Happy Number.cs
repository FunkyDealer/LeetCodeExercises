/*
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

    Starting with any positive integer, replace the number by the sum of the squares of its digits.
    Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    Those numbers for which this process ends in 1 are happy.

Return true if n is a happy number, and false if not.
*/

public class Solution {
    public bool IsHappy(int n) {   

        //start slow and fast numbers
        int slow = calculateNext(n);
        int fast = calculateNext(slow);
        
        //while fast isn't 1 and slow and fast aren't the same
        //if fast is 1, then it's a happy number
        //if slow and fast are the same, they are endlessly looping
        while (fast != 1 && slow != fast) {
            
            //slow goes 1 calculation at a time
            slow = calculateNext(slow);            
            //fast goes 2 calculations at a time
            fast = calculateNext(calculateNext(fast));     

            //Console.WriteLine($"Slow: {slow}  - fast: {fast}");       
        }

        return fast == 1;
    }
	
	//max speed calculation
    private int calculateNext(int n) {       
		
		//split the number into digits and add it's square to the total
        int total = 0;
        while (n > 0)
        {
            total += ((n % 10) * (n % 10));
            n /= 10;             //remove last digit
        }
		
		//return the total at the end
        return total;
    }    
}