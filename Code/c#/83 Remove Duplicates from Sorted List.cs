/*
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
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
    public ListNode DeleteDuplicates(ListNode head)
    {        
        if (head == null || head.next == null) return head;
        ListNode prev = head;
        ListNode curr = head.next;

        while (curr != null) { //go throught list

            if (curr.val == prev.val) //if the current value is the same as the previous
            {
                //delete it by making the previous node's next the current's next
                prev.next = curr.next;                
            }
            else
            { //else, proceed as normal and make previous into current
                prev = curr;
            }
            curr = curr.next; //finally, make current into the next
        }
        return head; //return the head at the end
    }
}