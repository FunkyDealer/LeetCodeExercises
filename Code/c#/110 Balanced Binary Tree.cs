//Given a binary tree, determine if it is Height-Balanced.

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
    public bool IsBalanced(TreeNode root) {
        if (root is null) return true;        
        if (DFS(root) == -1) return false;

        return true;
    }

    int DFS(TreeNode node)
    {
        if (node == null) return 0;

        //go left
        int left = DFS(node.left);

        //go right
        int right = DFS(node.right);

        if (left == -1 || right == -1)  return -1;

        if (Math.Abs((left - right)) > 1) return -1;
        
        return Math.Max(left, right) + 1;
    }
}