/*

Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.

*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
 
 //optimal
 public class Solution {
    public bool HasCycle(ListNode head) {
        
        if (head == null) return false; //head was null, list is empty, no cycle

        //start fast and slow pointer at head (position 0)
        ListNode slowPointer = head; 
        ListNode fastPointer = head;

        //go forward with the fast pointer
        //check if the fast pointer isn't null and if the next isn't null either
        while (fastPointer != null && fastPointer.next != null) {

            //send the fastPointer foward 2 positions
            fastPointer = fastPointer.next.next;
            //send the slowpointer forward 1 position
            slowPointer = slowPointer.next;

            //if the fast pointer if now with the slow pointer, we have a cycle
            if (fastPointer == slowPointer) return true;

        }

        //if everything else failed, then there is no cycle
        return false;
    }
}
 
 
 //not optimal
public class Solution {
    public bool HasCycle(ListNode head) {
        
        if (head == null) return false; //head was null, list is empty, no cycle
        if (head.next == null) return false; //head lead to nowhere, list only has 1 element, no cucle

        //start fast and slow pointer at head (position 0)
        ListNode slowPointer = head; 
        ListNode fastPointer = head;

        //send fast pointer 2 positions up
        for (int i = 0; i < 2; i++) {
            if (fastPointer.next == null) return false;
            fastPointer = fastPointer.next;
        }

        //check if there is a cycle by checking if the fast pointer arrived at the same pos as the slow
        if (fastPointer == slowPointer) return true;

        //start moving the pointers forward until they either reach the end or reach each others
        while (fastPointer != slowPointer) {
            
            //move slow pointer forward 1 position
            if (slowPointer.next == null) return false;
            else {
                slowPointer = slowPointer.next;
            }

            //move fast pointer forward 2 positions;
            for (int i = 0; i < 2; i++) {
            if (fastPointer.next == null) return false;
            fastPointer = fastPointer.next;
            }

            //check if fast and slow pointer are now is the same position
            if (fastPointer == slowPointer) return true;
        }

        //if everything else failed, then there is no cycle
        return false;
    }
}