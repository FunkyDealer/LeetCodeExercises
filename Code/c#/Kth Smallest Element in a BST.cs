//Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.

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
    public int count = 0;
    public int result = 0;

    public int KthSmallest(TreeNode root, int k) {

        InOrderTraversal(root , k);

        return result;
    }

    public void InOrderTraversal(TreeNode node, int k) {
        if (node == null) return;

        //start by going to the left
        InOrderTraversal(node.left, k);

        //Do something
        //increase count
        count++;
        //if the count is the k, we found the kth smallest value
        if (count == k) {
            result = node.val;            
            return;
        }

        //go to the right
        InOrderTraversal(node.right, k);
    }
}