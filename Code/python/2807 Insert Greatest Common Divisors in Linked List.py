#Given the head of a linked list head, in which each node contains an integer value.

#Between every pair of adjacent nodes, insert a new node with a value equal to the greatest common divisor of them.

#Return the linked list after insertion.

#The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def insertGreatestCommonDivisors(self, head: Optional[ListNode]) -> Optional[ListNode]:
    
        current = head #store head

        # go throught list until we read the penultimate node
        while current.next is not None:               
            # create a node to place after current
            # set its next to be current's next
            newNode = ListNode(self.GCD(current.val, current.next.val), current.next) 
            current.next = newNode # set the current's next to be this new node
            current = newNode.next # set current to be the node that is now after the new node (was previously current's next)

        return head # return the head

    # greatest common divisor function
    def GCD(self, a: int, b: int) -> int:

        while b is not 0:        
            temp = b
            b = a % b
            a = temp        
        return abs(a)