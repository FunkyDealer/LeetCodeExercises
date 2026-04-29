/*
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {               
        
        ListNode res = SortedMerge(list1, list2);    

        return res;
    }

    ListNode SortedMerge(ListNode node1, ListNode node2)
    {
        if (node1 == null) return node2;
        if (node2 == null) return node1;

        if (node1.val <= node2.val)
        {
            node1.next = SortedMerge(node1.next, node2);
            return node1;
        }
        else
        {
            node2.next = SortedMerge(node1, node2.next);
            return node2;
        }
    }
}