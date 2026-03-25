/*
Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
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

    public int MaxDepth(TreeNode root) {
        
        int maxPath = 0;
        PreOrderTraversal(root, 0, ref maxPath);
        return maxPath;
    }

    void PreOrderTraversal(TreeNode node, int currentPath, ref int maxPath)
    {
        if (node == null) return;

        //action
        currentPath++;

        maxPath = Math.Max(currentPath, maxPath);

        //go left
        PreOrderTraversal(node.left, currentPath, ref maxPath);

        //go right
        PreOrderTraversal(node.right, currentPath, ref maxPath);

        currentPath--;

    }
}