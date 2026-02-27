/*
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.
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
    public ListNode MiddleNode(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;     

        //slow pointer goes 1 node at a time, fast pointer goes 2 at a time
        // if the fast pointer can't go further, we are at the end of the list
        // and the slow pointer will be at the middle
        while (fast.next != null && fast.next.next != null) 
        {
            slow = slow.next;
            fast = fast.next.next;      
        }  

        //to determine if the list has a odd or even number of nodes
        //if its even, then the fast pointer will stop 1 node before the end
        //if its odd, it will have stopped at the last node      
        if (fast.next != null) return slow.next;
        else return slow;
    }
}