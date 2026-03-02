/*
Given an array of integers temperatures represents the daily temperatures,
return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature.
If there is no future day for which this is possible, keep answer[i] == 0 instead.
*/



public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] ans = new int[temperatures.Length];
        Stack<int> stack = new Stack<int>();

        //go through all temperatures
        for (int i = 0; i < temperatures.Length; i++)
        {            
            //remove smaller elements
            //if the stack has elements, and while the incoming element is bigger than the top element
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                //pop the top until we find a smaller temperature
                //get the temperature that is being popped
                int stackPop = stack.Pop();

                //the temperature that we popped is smaller, so we now have the day when 
                //temperature will be higher
                //so we can just calculate how many days by subtracting the current day minus that day
                //so, on the day that was popped, we put in the difference between the current day 
                //and the popped day
                ans[stackPop] = i - stackPop;
            }

            //place current day on stack
            stack.Push(i);
        }        

        return ans;
    }
}