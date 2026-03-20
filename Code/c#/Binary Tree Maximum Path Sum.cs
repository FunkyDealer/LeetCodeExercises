/*
A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence has an edge connecting them. A node can only appear in the sequence at most once. Note that the path does not need to pass through the root.

The path sum of a path is the sum of the node's values in the path.

Given the root of a binary tree, return the maximum path sum of any non-empty path.
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

    public int MaxPathSum(TreeNode root) {
        int res = root.val;

        PostOrderTraversal(root, ref res);

        return res;
    }

    public int PostOrderTraversal(TreeNode node, ref int res) {
        if (node == null) return 0;

        //go left
        //get max value
        int left = Math.Max(0, PostOrderTraversal(node.left, ref res));
        //go right
        //get max value
        int right = Math.Max(0, PostOrderTraversal(node.right, ref res));

        //do something
        //update res
        res = Math.Max(res, left + right + node.val);

        return node.val + Math.Max(left, right);
    }
}