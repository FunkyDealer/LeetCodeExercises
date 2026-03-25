/*
Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

Note: A leaf is a node with no children.
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
    public int MinDepth(TreeNode root) {
        
        if (root == null) return 0;
        int minDepth = Int32.MaxValue;
        PreOrderTraversal(root, 0, ref minDepth);
        return minDepth;

    }

    void PreOrderTraversal(TreeNode node, int currentPath, ref int minDepth) {
        if (node == null) return;
        //action
        currentPath++;
        //check for leaf
        if (node.left == null && node.right == null)
        {
            //found a leaf
            minDepth = Math.Min(minDepth, currentPath);
        }

        //go left
        PreOrderTraversal(node.left, currentPath, ref minDepth);
        //go right
        PreOrderTraversal(node.right, currentPath, ref minDepth);

        //back track
        currentPath--;
    }
}