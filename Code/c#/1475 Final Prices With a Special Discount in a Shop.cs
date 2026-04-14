/*
You are given an integer array prices where prices[i] is the price of the ith item in a shop.

There is a special discount for items in the shop. If you buy the ith item, then you will receive a discount equivalent to prices[j] where j is the minimum index such that j > i and prices[j] <= prices[i]. Otherwise, you will not receive any discount at all.

Return an integer array answer where answer[i] is the final price you will pay for the ith item of the shop, considering the special discount.
*/

public class Solution {
    public int[] FinalPrices(int[] prices) {
        
        //monotonic stack
        Stack<int> stack = new Stack<int>();

        //go throught the array
        for (int i = 0; i < prices.Length; i++)
        {
            //pop elements that are bigger or equal than the current element
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i]) 
            {
                //pop bigger element
                //remove current element from it
               prices[stack.Pop()] -= prices[i]; 
            }          

            stack.Push(i); //place current element on top
        }       

        return prices;
    }
}