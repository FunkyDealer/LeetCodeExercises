/*
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
        ListNode resultList = null;
        if (l1 == null && l2 == null) return resultList;

        //simulate addition by hand     
        ListNode result = new ListNode(); //create result list
        ListNode resultHead = result; //save result head

        int rest = 0; //set rest default 0
        resultList = new ListNode(); //create first node in result
        while (l1 != null || l2 != null) //go through both lists until they are both null
        {
        int val1 = 0;
        int val2 = 0;

        if (l1 != null) val1 = l1.val; //get val 1
        if (l2 != null) val2 = l2.val; //get val 2

        int n = val1 + val2 + rest;
        rest = 0;
        if (n > 9) { //calculate rest
            rest = 1;
            n = n - 10;
        }

        result.val = n;
        //check if the node is not null, and then check if the next node is also not null
        if ((l1 != null && l1.next != null) || (l2 != null && l2.next != null)) {            
            result.next = new ListNode();
            result = result.next;
         }

        if (l1 != null) l1 = l1.next;
        if (l2 != null) l2 = l2.next;                 
        }
        
        if (rest > 0) {
            result.next = new ListNode(rest, null);
        }    

        return resultHead;
    }
}