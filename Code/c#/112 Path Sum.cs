/*
Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

A leaf is a node with no children.
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
    public bool HasPathSum(TreeNode root, int targetSum) {       
        return PreOrderTraversal(root, targetSum);    
    }

    bool PreOrderTraversal(TreeNode node, int targetSum) {

        if (node == null) return false;

        targetSum -= node.val;

        //find leaf
        if (node.right == null && node.left == null) {
            //found leaf
            if (targetSum == 0) return true;
        }

        //go left        
        if (PreOrderTraversal(node.left, targetSum)) return true;

        //go right
        if (PreOrderTraversal(node.right, targetSum)) return true;
        
        targetSum += node.val;
        return false;
    }
}