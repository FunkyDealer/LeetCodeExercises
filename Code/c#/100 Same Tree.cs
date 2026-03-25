/*
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        
        return PreOrderTraversal(p,q);
    }

    bool PreOrderTraversal(TreeNode p, TreeNode q) {

        if (p == null && q == null) return true;
        //if one of them is null, return false;
        if (p == null && q != null || p != null && q == null) return false;        
        
        //check values
        //if the values are different, return false
        if (p.val != q.val) return false;     
        

        //go left and right
        //if both are the same, return true
        return PreOrderTraversal(p.left, q.left) && PreOrderTraversal(p.right, q.right);

    }
}