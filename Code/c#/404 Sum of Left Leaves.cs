/*
Given the root of a binary tree, return the sum of all left leaves.

A leaf is a node with no children. A left leaf is a leaf that is the left child of another node.
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
    public int SumOfLeftLeaves(TreeNode root) {
        if (root == null) return 0;
        int sum = 0;
        PreOrderTraversalSum(root, ref sum, false);
        return sum;
    }

    void PreOrderTraversalSum(TreeNode node, ref int sum, bool left) {
        if (node == null) return;

        //action
        if (node.left == null && node.right == null && left) sum += node.val;
        
        //go left
        PreOrderTraversalSum(node.left, ref sum, true);

        //go right
        PreOrderTraversalSum(node.right, ref sum, false);
    }
}