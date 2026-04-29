/*
You are given the head of a linked list.

Remove every node which has a node with a greater value anywhere to the right side of it.

Return the head of the modified linked list.
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
    public ListNode RemoveNodes(ListNode head) {
        
        ListNode curr = head;

        Stack<ListNode> stack = new Stack<ListNode>(); //monotonic stack

        while (curr != null) {
            
            //remove smaller elements from stack
            while (stack.Count > 0 && curr.val > stack.Peek().val) {

                if (stack.Pop() != head)
                {
                    stack.Peek().next = curr; //set the next of the value before to current to close connection
                }
                else {
                    head = curr;
                }
            }       

            stack.Push(curr);
            curr = curr.next;
        }

        return head;
    }
}