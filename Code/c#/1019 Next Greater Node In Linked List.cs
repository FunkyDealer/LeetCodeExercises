/*
You are given the head of a linked list with n nodes.

For each node in the list, find the value of the next greater node. That is, for each node, find the value of the first node that is next to it and has a strictly larger value than it.

Return an integer array answer where answer[i] is the value of the next greater node of the ith node (1-indexed). If the ith node does not have a next greater node, set answer[i] = 0.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public int[] NextLargerNodes(ListNode head) {

        List<int> res = new List<int>();
        Stack<int> stack = new Stack<int>();

        //explode the linked list
        while (head != null) {
            res.Add(head.val); //add value to result

            while (stack.Count > 0 && res[stack.Peek()] < head.val)
            {
                //pop top
                res[stack.Pop()] = head.val;
            }

            stack.Push(res.Count - 1);

            head = head.next;
        }       

        //remove elements that are still in the stack, they have no next greater element
        while (stack.Count > 0) {
            int i = stack.Pop();
            res[i] = 0;
        } 

        return res.ToArray();
    }
}