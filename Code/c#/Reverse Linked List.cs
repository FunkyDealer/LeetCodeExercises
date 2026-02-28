//Given the head of a singly linked list, reverse the list, and return the reversed list.

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
    public ListNode ReverseList(ListNode head) {        
        ListNode curr = head;
        ListNode prev = null;
        ListNode next = null;

        while (curr != null) {
            //temporality store current's next
            next = curr.next;
            //reverse current's direction
            curr.next = prev;

            //before moving on,
            //set previous to current
            prev = curr;

            //move current forward
           curr = next;             
        }       
        
        //return previous, which is now at the end of the list, which is now the start
        return prev;
    }
}