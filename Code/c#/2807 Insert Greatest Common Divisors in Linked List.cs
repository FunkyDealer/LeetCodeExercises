/*
Given the head of a linked list head, in which each node contains an integer value.

Between every pair of adjacent nodes, insert a new node with a value equal to the greatest common divisor of them.

Return the linked list after insertion.

The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.
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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        
        ListNode curr = head;

        //go throught list until curr's next null (final node)
        while (curr.next != null)
        {
               int gcd = GCD(curr.val, curr.next.val); //calculate greatest common divisor of current and next

                ListNode newNode = new ListNode(gcd, curr.next);
                curr.next = newNode;
                curr = newNode.next;  //jump to next
        }

        return head;
    }

    int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}