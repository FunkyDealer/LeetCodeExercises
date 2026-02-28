/*

Given the head of a singly linked list and two integers left and right where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.

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
 
 //more optimal, only 1 pass, no extra space, uses in-place reversal
 public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        
        if (head.next == null) return head;
        if (left == right) return head;
        
        ListNode leftPrevNode = null;
        ListNode leftNode = null;
        ListNode rightNode = null;
        ListNode curr = head;
        ListNode prev = null;
        ListNode next = null;

        int pos = 1;

        while (curr != null)
        {
            next = curr.next;

            if (pos == left) {
                //we are at the left node
                //remember its previous node so that we can make it right's next
                leftPrevNode = prev;
                //remeber this left node, so that we can make its next right's next later
                leftNode = curr;               
            }         

            //while inside the left and right range
            if (pos > left && pos <= right)
            {                
                curr.next = prev;
            }       

            if (pos == right) {
                //we are at the right node
                //set it to be after the node previous to to the left
                if (leftPrevNode != null) leftPrevNode.next = curr;

                //set node right + 1 to be left's next
                leftNode.next = next;

                //in case that the list only has 2 slots and it needs to be switched
                if (next == null && pos == 2) return curr;

                //if the left node was the list head
                //that means there is no Left Previous node
                //so that means that head must be turned into the right node
                //which is current node
                if (leftPrevNode == null) head = curr;
            }   

            pos++; //increase position
            prev = curr; //set the previous
            curr = next; //advance current
        }      

        return head;
    }
}
  
 //not optimal, order too big
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        
        if (head.next == null) return head;
       
        List<int> number = new List<int>();

        ListNode curr = head;
        int pos = 1;
        while (curr != null)
        {
            if (pos >= left && pos <= right) number.Add(curr.val);
            pos++;            
            curr = curr.next;            
        }

        curr = head;
        pos = 1;
        while (curr != null) 
        {
            if (pos >= left && pos <= right) {
                int size = number.Count;
                curr.val = number[size -1];
                number.RemoveAt(size-1);
            }
            pos++;
            curr = curr.next;
        }

        return head;
    }
}